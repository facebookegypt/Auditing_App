Imports System.Data.OleDb
Public Class CurrencyFrm
    Dim Curr_ID As Long = -1
    Private Sub CurrencyFrm_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainFrm.Enabled = True
    End Sub
    Private Sub CurrencyFrm_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Close()
        End If
    End Sub
    Private Sub CurrencyFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        If Not DBConnected() Then
            MsgBox("Error in database ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        UpdateTreeView(CurrTV, "SELECT * FROM Currencies;")
    End Sub
    Sub ClearCntrls()
        For Each Ctrla As Control In Me.Controls
            If TypeOf Ctrla Is TextBox Then
                Ctrla.Text = String.Empty
            End If
        Next
        CurrIcoPicBox.Image = My.Resources.money
        UpdateToolStripMenuItem.Enabled = False
        DeleteToolStripMenuItem.Enabled = False
        UpdateTreeView(CurrTV, "SELECT * FROM Currencies;")
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub AddNewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddNewToolStripMenuItem.Click
        ClearCntrls()
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        'User Photo=========================================
        Dim IMG As Bitmap = Nothing
        IMG = New Bitmap(CurrIcoPicBox.Image)
        Dim MyStream = New IO.MemoryStream
        IMG.Save(MyStream, Imaging.ImageFormat.Png)
        '===================================================

        Dim SqlStr As String = _
            ("INSERT INTO Currencies (CurrName,CurrSign,CurrSymbol,CurrIco) " & _
             "VALUES(@_Cnm,@_Csi,@_Csy,@_Cic)")
        Dim InsertCurrCMD As New OleDbCommand
        _ExcuteCMD(SqlStr, InsertCurrCMD)
        With InsertCurrCMD.Parameters
            .AddWithValue("@_Cnm", CurrNameTextBox.Text)
            .AddWithValue("@_Csi", CurrSignTextBox.Text)
            .AddWithValue("@_Csy", CurrSymTextBox.Text)
            .AddWithValue("@_Cic", OleDbType.VarBinary).Value = MyStream.GetBuffer()
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
        UserActionsLblStat.ForeColor = Color.Green
        UserActionsLblStat.Text = ("Saved successfully.")
        UpdateTreeView(CurrTV, "SELECT * FROM Currencies;")
        MyStream.Flush()
        MyStream.Close()
    End Sub
    Private Sub CurrIcoPicBox_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CurrIcoPicBox.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim OFD As New OpenFileDialog
            With OFD
                .Filter = ("Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png")
                If .ShowDialog = DialogResult.OK Then
                    Try
                        CurrIcoPicBox.Image = Image.FromFile(.FileName)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End With
        End If
    End Sub
    Function FindNode(SearchTerm As String, TRV As TreeView) As String
        'Reset TreeView
        TRV.CollapseAll()
        'Begin Search
        Dim AllSubjectsCount As Integer = TRV.GetNodeCount(False)
        Dim SrchRslt As Integer = 0
        For I As Integer = 0 To AllSubjectsCount - 1
            'Tolower : False case sensitive
            'Contains : False case sensitive
            If TRV.Nodes(I).Text.ToLower.Contains(SearchTerm.ToLower) Or _
                TRV.Nodes(I).Text = (SearchTerm) Then
                'Expands all search results
                TRV.Nodes(I).Expand()
                'High-light search result
                TRV.Nodes(I).BackColor = Color.Yellow
                TRV.Nodes(I).ForeColor = Color.Red
                SrchRslt += 1
            Else
                'Clear other nodes and previous search result
                TRV.Nodes(I).BackColor = Nothing
                TRV.Nodes(I).ForeColor = Nothing
            End If
            Dim trn As New TreeNode
            trn = TRV.Nodes(I)
            For Each Trn1 As TreeNode In trn.Nodes
                If Trn1.Text = SearchTerm Or _
                    Trn1.Text.ToLower.Contains(SearchTerm.ToLower) Then
                    trn.Expand()
                    Trn1.BackColor = Color.Yellow
                    Trn1.ForeColor = Color.Red
                    SrchRslt += 1
                Else
                    Trn1.BackColor = Nothing
                    Trn1.ForeColor = Nothing
                End If
            Next
        Next
        Return ("Found " & SrchRslt & " result(s).")
    End Function
    Private Sub SearchToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Dim SearchLbl1 As String = String.Empty  'Find TreeView Node [TreeNode]
        'Begin search
        SearchLbl1 = _
            InputBox("Enter any search term", "Search All TreeView")
        If String.IsNullOrEmpty(SearchLbl1) Or _
            String.IsNullOrWhiteSpace(SearchLbl1) Then
            MsgBox("Don't leave blanks.")
            Exit Sub
        End If
        UserActionsLblStat.Text = FindNode(SearchLbl1, CurrTV)
    End Sub
    Private Sub CurrTV_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles CurrTV.AfterSelect
        If String.IsNullOrEmpty(e.Node.Name) Then Exit Sub
        Curr_ID = CLng(e.Node.Name)
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        DateLbl.Text = Date.Now.ToString("ddd dd / MMMM / yyyy")
    End Sub
    Private Sub CurrTV_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CurrTV.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            'Begin display TreeNode contents on Form Controls
            If Curr_ID = -1 Then Exit Sub
            'Clear the form from previous display----------
            ClearCntrls()
            '----------------------------------------------
            Dim Sqlstr As String = _
                ("SELECT * FROM Currencies WHERE Currencies.CurrID=" & Curr_ID & ";")
            Dim SrchCMD As New OleDbCommand
            _ExcuteCMD(Sqlstr, SrchCMD)
            Dim SrchReader As OleDbDataReader = SrchCMD.ExecuteReader
            If SrchReader.HasRows Then
                While SrchReader.Read
                    CurrNameTextBox.Text = SrchReader!CurrName
                    CurrSymTextBox.Text = SrchReader!CurrSymbol
                    CurrSignTextBox.Text = SrchReader!CurrSign
                    'Curr Image-------------------------------------------------
                    Dim ImageBytes As Byte() = CType(SrchReader!CurrIco, Byte())
                    Dim MyStream As New IO.MemoryStream(ImageBytes)
                    Dim IMG As Image = Image.FromStream(MyStream)
                    CurrIcoPicBox.Image = IMG
                    MyStream.Flush()
                    MyStream.Close()
                    '-----------------------------------------------------------
                End While
                SrchReader.Close()
                UpdateToolStripMenuItem.Enabled = True
                DeleteToolStripMenuItem.Enabled = True
                SaveToolStripMenuItem.Enabled = False
            Else
                UpdateToolStripMenuItem.Enabled = False
                DeleteToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub
    Private Sub UpdateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        If Curr_ID = -1 Then Exit Sub
        If Not DBConnected() Then
            UserActionsLblStat.ForeColor = Color.Red
            UserActionsLblStat.Text = ("Database Error.")
            Exit Sub
        End If
        Dim Curname, CurSym, CurSign As String
        Curname = CurrNameTextBox.Text
        CurSym = CurrSymTextBox.Text
        CurSign = CurrSignTextBox.Text
        If String.IsNullOrEmpty(Curname) Or
                String.IsNullOrEmpty(CurSign) Or
                String.IsNullOrEmpty(CurSym) Then
            UserActionsLblStat.ForeColor = Color.Red
            UserActionsLblStat.Text = ("Don't leave blanks.")
            Exit Sub
        End If
        'User Photo=========================================
        Dim IMG As Bitmap = Nothing
        IMG = New Bitmap(CurrIcoPicBox.Image)
        Dim MyStream = New IO.MemoryStream
        IMG.Save(MyStream, Imaging.ImageFormat.Png)
        '===================================================
        Dim SqlStr As String =
            ("UPDATE Currencies SET CurrName=@ufnm, CurrSymbol=@ulnm, CurrSign=@ucid, CurrIco=@uimg " & _
             "WHERE Currencies.CurrID=@uid;")
        Dim UpdateCMD As New OleDbCommand
        _ExcuteCMD(SqlStr, UpdateCMD)
        Try
            With UpdateCMD.Parameters
                .AddWithValue("@ufnm", Curname)
                .AddWithValue("@ulnm", CurSym)
                .AddWithValue("@ucid", CurSign)
                .AddWithValue("@uimg", OleDbType.VarBinary).Value = MyStream.GetBuffer()
                .AddWithValue("@uid", Curr_ID)
            End With
            UpdateCMD.ExecuteNonQuery()
            UpdateCMD.Parameters.Clear()
        Catch ex As Exception
            UserActionsLblStat.ForeColor = Color.Red
            UserActionsLblStat.Text = ("Error in Sql Statement UPDATE : " & ex.Message)
            Exit Sub
        End Try
        Try
            Trans.Commit()
        Catch ex As Exception
            Trans.Rollback()
            UserActionsLblStat.ForeColor = Color.Red
            UserActionsLblStat.Text = ("Transaction Error : " & ex.Message)
            Exit Sub
        End Try
        UserActionsLblStat.ForeColor = Color.Green
        UserActionsLblStat.Text = ("Updated successfully.")
        Trans.Dispose()
        UpdateCMD.Dispose()
        MyStream.Flush()
        MyStream.Close()
        'Populate TreeView with Database from Access table
        UpdateTreeView(CurrTV, "SELECT * FROM Currencies;")
        'Activate Delete ToolStripMenuItem
        DeleteToolStripMenuItem.Enabled = True
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If Curr_ID = -1 Then Exit Sub
        Dim AreYouSure As String =
            MsgBox("Do you wish to delete this Currency " & CurrTV.Nodes(Curr_ID.ToString).Text & "?",
                   MsgBoxStyle.Critical + MsgBoxStyle.YesNo,
                   "Delete currency.")
        If AreYouSure = vbYes Then
            If Not DBConnected() Then
                UserActionsLblStat.ForeColor = Color.Red
                UserActionsLblStat.Text = ("Database Error.")
                Exit Sub
            End If
            Dim SqlStr As String =
            ("DELETE * FROM Currencies WHERE Currencies.CurrID=@uid;")
            Dim DeleteCmd As New OleDbCommand
            _ExcuteCMD(SqlStr, DeleteCmd)
            Try
                With DeleteCmd.Parameters
                    .AddWithValue("@uid", Curr_ID)
                End With
                DeleteCmd.ExecuteNonQuery()
                DeleteCmd.Parameters.Clear()
            Catch ex As Exception
                UserActionsLblStat.ForeColor = Color.Red
                UserActionsLblStat.Text = ("Error in Sql Statement Delete : " & ex.Message)
                Exit Sub
            End Try
            Try
                Trans.Commit()
            Catch ex As Exception
                Trans.Rollback()
                UserActionsLblStat.ForeColor = Color.Red
                UserActionsLblStat.Text = ("Transaction Error : " & ex.Message)
                Exit Sub
            End Try
            UserActionsLblStat.ForeColor = Color.Green
            UserActionsLblStat.Text = ("Deleted successfully.")
            Trans.Dispose()
            DeleteCmd.Dispose()
            'Clear Form
            ClearCntrls()
            'Populate TreeView with Database from Access table
            UpdateTreeView(CurrTV, "SELECT * FROM Currencies;")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class