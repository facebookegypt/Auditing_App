Imports System.Data
Imports System.Data.OleDb
Public Class MyContracts
   Public OpenedTbl As String = ""
   Dim Data1 As String = ""
   Private Sub MyContracts_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
      If LoggedInAsAdmin Then
         ArchID.ReadOnly = False
      End If
    End Sub
    Private Sub MyContracts_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Escape) Then Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
   Private Sub MyContracts_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim SqlStr1 As String = ""

      Try
            DBConnected()
            SqlStr1 = ("SELECT * FROM [Contracts] WHERE [Contracts].[CntrctID] <> '';")
            With CMD
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = SqlStr1
            End With
            Dim DataRdr As OleDbDataReader = CMD.ExecuteReader
            CntrctLst.Items.Clear()
            Do While DataRdr.Read = True
                Data1 = DataRdr!ProjNm
                Data1 &= "|" & DataRdr!CntrctNM
                Data1 &= "|" & DataRdr!CntrctID
                CntrctLst.Items.Add(Data1)
            Loop
            DataRdr.Close()
        Catch ex As Exception
            MsgBox("Error :" & ex.Message)
        End Try
    End Sub
    Private Sub CntrctLst_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CntrctLst.SelectedIndexChanged
        If CntrctLst.SelectedIndex = -1 Then Exit Sub
        Dim Tclicked() As String = CntrctLst.SelectedItem.ToString.Split("|")
        OpenedTbl = ""
        Dim SqlStr2 As String = ""
        Try
            DBConnected()
            SqlStr2 = ("SELECT * FROM [Contracts] WHERE [Contracts].[CntrctID] ='" & Tclicked(2) & "';")    'ContractID 14/2/2019
            Dim CMDFech As New OleDbCommand
            With CMDFech
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = SqlStr2
            End With
            Dim DataRdr1 As OleDbDataReader = CMDFech.ExecuteReader
            DataRdr1.Read()
            ArchID.Text = (DataRdr1!CntrctID)
            Tcntrct = (DataRdr1!CntrctNM)
            DataRdr1.Close()
        Catch ex As Exception
            MsgBox("Error :" & ex.Message)
        End Try
    End Sub
   Private Sub ConnectBtn_Click(sender As System.Object, e As System.EventArgs) Handles ConnectBtn.Click
        Try
            If CntrctLst.SelectedIndex = -1 Then
                MsgBox("Choose Contract")
                ConnectBtn.BackColor = Color.WhiteSmoke
                Exit Sub
            End If
            DataGrid_Work("SELECT * FROM [" & ArchID.Text & "]", DGV)
            ConnectBtn.BackColor = Color.LightGreen
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Dim SqlStr As String = String.Empty
        'SqlStr = ("SELECT * FROM [" & ArchID.Text & "] WHERE [" & ArchID.Text & "].[CntrctID] ='" & Tclicked(2) & "';")
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            If String.IsNullOrEmpty(ArchID.Text) Then
                MsgBox("Choose contract")
                Exit Sub
            End If
            If String.IsNullOrEmpty(TextBox2.Text) Then
                MsgBox("Enter Section Name.")
                Exit Sub
            End If
            Dim SqlStr As String = String.Empty
            SqlStr = ("UPDATE [" & ArchID.Text & "] SET SectionNM='" & DGV(1, DGV.CurrentCell.RowIndex).Value & "' WHERE ID= " & DGV(0, DGV.CurrentCell.RowIndex).Value)
            With CMD
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = SqlStr
            End With
            Dim Onh As Integer = CMD.ExecuteNonQuery
            MsgBox("Section Updated.")
            DataGrid_Work("SELECT * FROM [" & ArchID.Text & "]", DGV)
            With DGV
                .Columns(0).HeaderText = ("م.")
                .Columns(1).HeaderText = ("القسم")
            End With
        Catch ex As Exception
            MsgBox("New Section Error : " & ex.Message)
        End Try
    End Sub
    Private Sub DGV_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        Try
            Dim sqlsTr As String = String.Empty
            Dim k As String = String.Empty
            Dim nS As Integer = DGV.Columns.Count - 1
            For Ns1 As Integer = 1 To nS
                k = DGV(Ns1, DGV.CurrentCell.RowIndex).Value
            Next
            sqlsTr = ("UPDATE [" & ArchID.Text & "] SET SectionNM='" & DGV(1, DGV.CurrentCell.RowIndex).Value & "' WHERE ID = " & DGV(0, DGV.CurrentCell.RowIndex).Value)
            With CMD
                .Connection = CN
                .CommandType = CommandType.Text
                .CommandText = sqlsTr
            End With
            Dim Onh As Integer = CMD.ExecuteNonQuery
            DataGrid_Work("SELECT * FROM [" & ArchID.Text & "]", DGV)
            With DGV
                .Columns(0).HeaderText = ("م.")
                .Columns(1).HeaderText = ("القسم")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DGV_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEnter
        Try
            If e.ColumnIndex = -1 Or e.RowIndex = -1 Then Exit Sub
            If DGV(1, e.RowIndex).Selected Then
                DGV(1, e.RowIndex).ReadOnly = False
            Else
                DGV.ReadOnly = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DGV_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DGV.KeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                Dim AreYouSure As String = MsgBox("Delete ?", MsgBoxStyle.YesNo, "Sure?")
                If AreYouSure = vbYes Then
                        Dim sqlsTr As String = String.Empty
                        sqlsTr = ("DELETE * FROM [" & ArchID.Text & "] WHERE ID = " & DGV(0, DGV.CurrentCell.RowIndex).Value)
                        With CMD
                            .Connection = CN
                            .CommandType = CommandType.Text
                            .CommandText = sqlsTr
                        End With
                        Dim oNH As Integer = CMD.ExecuteNonQuery
                        MsgBox("Deleted.")
                        DataGrid_Work("SELECT * FROM [" & ArchID.Text & "]", DGV)
                        With DGV
                            .Columns(0).HeaderText = ("م.")
                            .Columns(1).HeaderText = ("القسم")
                        End With
                    End If
                Else
                    Exit Sub
                End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                Button1_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class