Imports System.Data.OleDb
Public Class SbCntrctr
    Dim ContractorID As Long = -1
    Private Sub SbCntrctr_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainFrm.Enabled = True
    End Sub
    Private Sub SbCntrctr_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
    Private Sub SbCntrctr_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '=============================Contractor ListBox
        'Populate ListBox with Projects
        CntrctrLst.DataSource = Nothing
        CntrctrLst.Items.Clear()
        Dim CntrctrLstCMD As New OleDbCommand
        'You can change this Sql Statement to be .. SELECT TOP 100 .. for easy testing.
        'Of find a way to populate ComboBox with 29.8k data without waiting.
        Dim SqlStr1 As String =
            ("SELECT * FROM Contractors")
        _ExcuteCMD(SqlStr1, CntrctrLstCMD)
        Dim CntrctrLstReader As OleDbDataReader = CntrctrLstCMD.ExecuteReader
        Dim CntrctrLstItems As New Dictionary(Of String, String)()
        If CntrctrLstReader.HasRows Then
            CntrctrLst.BeginUpdate()
            While CntrctrLstReader.Read
                CntrctrLstItems.Add(CntrctrLstReader!CntrctrID.ToString, CntrctrLstReader!CntrctrNM)
            End While
            CntrctrLstReader.Close()
        Else
            CntrctrLst.DataSource = Nothing
        End If
        CntrctrLstCMD.Dispose()
        With CntrctrLst
            .DataSource = New BindingSource(CntrctrLstItems, Nothing)
            .DisplayMember = "Value"
            .ValueMember = "key"
            .Text = String.Empty
            .EndUpdate()
        End With
        '=========Load Join Contractors and Subcontractors==========================
        Dim SqlStr As String = _
            ("SELECT * FROM Contractors INNER JOIN SubContractors ON Contractors.CntrctrID=Subcontractors.CntrctrID")
        DataGrid_Work(SqlStr, DGSbCntractrs)
        With DGSbCntractrs
            .Columns(0).Visible = False
            .Columns(1).HeaderText = ("Contractor Name")
            .Columns(2).Visible = False
            .Columns(3).HeaderText = ("Sub Contractor")
            .Columns(4).HeaderText = ("Sub Contractor Representative")
            .Columns(5).Visible = False
        End With
    End Sub
    Private Sub CntrctrLst_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles CntrctrLst.SelectedValueChanged
        Dim ContractorID As Long = _
             DirectCast(CntrctrLst.SelectedItem, KeyValuePair(Of String, String)).Key()
        If ContractorID = -1 Then
            Exit Sub
        End If
        SubCntrctrNMTextBox.Text = String.Empty
        SubCntrctrRepTextBox.Text = String.Empty
        Dim SqlStr As String = _
            ("SELECT * FROM Contractors INNER JOIN SubContractors ON Contractors.CntrctrID=Subcontractors.CntrctrID" & _
             " WHERE Contractors.CntrctrID=" & ContractorID & ";")
        DataGrid_Work(SqlStr, DGSbCntractrs)
        With DGSbCntractrs
            .Columns(0).Visible = False
            .Columns(1).HeaderText = ("Contractor Name")
            .Columns(2).Visible = False
            .Columns(3).HeaderText = ("Sub Contractor")
            .Columns(4).HeaderText = ("Sub Contractor Representative")
            .Columns(5).Visible = False
        End With
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub NewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim Ctrl As Control
        For Each Ctrl In Me.Controls
            If TypeOf Ctrl Is TextBox Then
                Ctrl.Text = String.Empty
            End If
        Next
        ContractorID = -1
        CntrctrLst.Text = String.Empty
        Dim SqlStr As String = _
            ("SELECT * FROM Contractors INNER JOIN SubContractors ON Contractors.CntrctrID=Subcontractors.CntrctrID")
        DataGrid_Work(SqlStr, DGSbCntractrs)
        With DGSbCntractrs
            .Columns(0).Visible = False
            .Columns(1).HeaderText = ("Contractor Name")
            .Columns(2).Visible = False
            .Columns(3).HeaderText = ("Sub Contractor")
            .Columns(4).HeaderText = ("Sub Contractor Representative")
            .Columns(5).Visible = False
        End With
        SaveToolStripMenuItem.Enabled = True
        FindToolStripMenuItem.Enabled = True
        UpdateToolStripMenuItem.Enabled = False
        DeleteToolStripMenuItem.Enabled = False
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim ContractorID As Long = _
             DirectCast(CntrctrLst.SelectedItem, KeyValuePair(Of String, String)).Key()
        If ContractorID = -1 Then
            MsgBox("Error")
            Exit Sub
        End If

        Dim SqlStr As String = _
            ("INSERT INTO SubContractors (SubCntrctr_Co_Name,SubCntrctr_Co_Rep,CntrctrID) " & _
             "VALUES(@C1,@C2,@C3)")
        Dim InsertCurrCMD As New OleDbCommand
        _ExcuteCMD(SqlStr, InsertCurrCMD)
        With InsertCurrCMD.Parameters
            .AddWithValue("@C1", SubCntrctrNMTextBox.Text)
            .AddWithValue("@C2", SubCntrctrRepTextBox.Text)
            .AddWithValue("@C3", ContractorID)
        End With
        Try
            InsertCurrCMD.ExecuteNonQuery()
            InsertCurrCMD.Parameters.Clear()
        Catch ex As Exception
            MsgBox("Error in Sql Statement : " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Try
            Trans.Commit()
        Catch ex As Exception
            MsgBox("Error in Saving your new Currency : " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Trans.Dispose()
        InsertCurrCMD.Dispose()
        MsgBox("Saved.")
        Dim SqlStr1 As String = _
            ("SELECT * FROM Contractors INNER JOIN SubContractors ON Contractors.CntrctrID=Subcontractors.CntrctrID" & _
             " WHERE Contractors.CntrctrID=" & ContractorID & ";")
        DataGrid_Work(SqlStr1, DGSbCntractrs)
        With DGSbCntractrs
            .Columns(0).Visible = False
            .Columns(1).HeaderText = ("Contractor Name")
            .Columns(2).Visible = False
            .Columns(3).HeaderText = ("Sub Contractor")
            .Columns(4).HeaderText = ("Sub Contractor Representative")
            .Columns(5).Visible = False
        End With
    End Sub
    Private Sub UpdateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        Dim ContractorID As Long = _
             DirectCast(CntrctrLst.SelectedItem, KeyValuePair(Of String, String)).Key()
        If ContractorID = -1 Then
            MsgBox("Error")
            Exit Sub
        End If

        Dim SubCntrctrID As Long = DGSbCntractrs(2, DGSbCntractrs.CurrentRow.Index).Value
        If SubCntrctrID = -1 Then
            MsgBox("Choose SubContractor First.")
            Exit Sub
        End If
        Dim SqlStr As String = _
            ("UPDATE SubContractors SET SubCntrctr_Co_Name=@C1,SubCntrctr_Co_Rep=@C2" & _
             "WHERE SubContractors.SubCntrctr_ID=" & SubCntrctrID & ";")
        Dim UpdateCMD As New OleDbCommand
        _ExcuteCMD(SqlStr, UpdateCMD)
        With UpdateCMD.Parameters
            .AddWithValue("@C1", SubCntrctrNMTextBox.Text)
            .AddWithValue("@C2", SubCntrctrRepTextBox.Text)
        End With
        Try
            UpdateCMD.ExecuteNonQuery()
            UpdateCMD.Parameters.Clear()
        Catch ex As Exception
            MsgBox("Error in Sql Statement : " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Try
            Trans.Commit()
        Catch ex As Exception
            MsgBox("Error in Saving your new Currency : " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Trans.Dispose()
        UpdateCMD.Dispose()
        MsgBox("Updated.")
        Dim SqlStr1 As String = _
            ("SELECT * FROM Contractors INNER JOIN SubContractors ON Contractors.CntrctrID=Subcontractors.CntrctrID" & _
             " WHERE Contractors.CntrctrID=" & ContractorID & ";")
        DataGrid_Work(SqlStr1, DGSbCntractrs)
        With DGSbCntractrs
            .Columns(0).Visible = False
            .Columns(1).HeaderText = ("Contractor Name")
            .Columns(2).Visible = False
            .Columns(3).HeaderText = ("Sub Contractor")
            .Columns(4).HeaderText = ("Sub Contractor Representative")
            .Columns(5).Visible = False
        End With
    End Sub
    Private Sub DGSbCntractrs_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGSbCntractrs.CellContentClick
        If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
            SubCntrctrNMTextBox.Text = String.Empty
            SubCntrctrRepTextBox.Text = String.Empty
            UpdateToolStripMenuItem.Enabled = False
            SaveToolStripMenuItem.Enabled = True
            DeleteToolStripMenuItem.Enabled = False
            Exit Sub
        End If
        SaveToolStripMenuItem.Enabled = False
        UpdateToolStripMenuItem.Enabled = True
        DeleteToolStripMenuItem.Enabled = True
        SubCntrctrNMTextBox.Text = DGSbCntractrs(3, e.RowIndex).Value
        SubCntrctrRepTextBox.Text = DGSbCntractrs(4, e.RowIndex).Value
        Dim subContractorID = DGSbCntractrs(2, e.RowIndex).Value
    End Sub
    Private Sub FindToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FindToolStripMenuItem.Click
        Dim FindTerm As String = _
            InputBox("Enter SubContractor Name : ")
        If String.IsNullOrEmpty(FindTerm) Or _
            String.IsNullOrWhiteSpace(FindTerm) Then
            MsgBox("Leave no blanks")
            Exit Sub
        End If

        Dim SqlStr1 As String = _
           ("SELECT * FROM Contractors INNER JOIN SubContractors ON Contractors.CntrctrID=Subcontractors.CntrctrID" & _
            " WHERE SubContractors.SubCntrctr_Co_Name LIKE '%" & FindTerm & "%';")
        DataGrid_Work(SqlStr1, DGSbCntractrs)
        With DGSbCntractrs
            .Columns(0).Visible = False
            .Columns(1).HeaderText = ("Contractor Name")
            .Columns(2).Visible = False
            .Columns(3).HeaderText = ("Sub Contractor")
            .Columns(4).HeaderText = ("Sub Contractor Representative")
            .Columns(5).Visible = False
        End With
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim ContractorID As Long = _
             DirectCast(CntrctrLst.SelectedItem, KeyValuePair(Of String, String)).Key()
        If ContractorID = -1 Then
            MsgBox("Error")
            Exit Sub
        End If

        Dim SubCntrctrID As Long = DGSbCntractrs(2, DGSbCntractrs.CurrentRow.Index).Value
        If SubCntrctrID = -1 Then
            MsgBox("Choose SubContractor First.")
            Exit Sub
        End If
        Dim SqlStr As String = _
            ("DELETE * FROM SubContractors WHERE SubContractors.SubCntrctr_ID=" & SubCntrctrID & ";")
        Dim DeleteCMD As New OleDbCommand
        _ExcuteCMD(SqlStr, DeleteCMD)
        With DeleteCMD.Parameters
            .AddWithValue("@C1", SubCntrctrNMTextBox.Text)
            .AddWithValue("@C2", SubCntrctrRepTextBox.Text)
        End With
        Try
            DeleteCMD.ExecuteNonQuery()
            DeleteCMD.Parameters.Clear()
        Catch ex As Exception
            MsgBox("Error in Sql Statement : " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Try
            Trans.Commit()
        Catch ex As Exception
            MsgBox("Error in Saving your new Currency : " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Trans.Dispose()
        DeleteCMD.Dispose()
        MsgBox("Deleted.")
        Dim SqlStr1 As String = _
            ("SELECT * FROM Contractors INNER JOIN SubContractors ON Contractors.CntrctrID=Subcontractors.CntrctrID" & _
             " WHERE Contractors.CntrctrID=" & ContractorID & ";")
        DataGrid_Work(SqlStr1, DGSbCntractrs)
        With DGSbCntractrs
            .Columns(0).Visible = False
            .Columns(1).HeaderText = ("Contractor Name")
            .Columns(2).Visible = False
            .Columns(3).HeaderText = ("Sub Contractor")
            .Columns(4).HeaderText = ("Sub Contractor Representative")
            .Columns(5).Visible = False
        End With
    End Sub
End Class