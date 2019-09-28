Imports System.Data
Imports System.Data.OleDb
Public Class DB_Struct
   Dim SELECTED_TABLE As String = ""
   Dim SELECTED_FIELD As String = ""
   Dim SELECTED_DATATYPE As String = ""
   Public Avail_CMD_TABLE(3) As String
   Public SQLStmnt As String = ""
   Private Sub ConnectBtn_Click(sender As System.Object, e As System.EventArgs) Handles ConnectBtn.Click
      If CheckDB(TxtDBLoc.Text.Trim) Then
         Lblstat.Text = ("Connected")
         GetAllTables(CN, TV1)
         TV1.Sort()
      End If
   End Sub
   Private Sub DB_Struct_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
      If e.KeyChar = ChrW(Keys.Escape) Then
         Me.Dispose()
      End If
   End Sub
   Private Sub DB_Struct_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      Dim objReader As IO.StreamReader = Nothing
      Try
         objReader = New System.IO.StreamReader("..\..\ini\ConStr.txt")
         Dim Tlin() As String = objReader.ReadToEnd().Split(vbCrLf)
         TxtDBLoc.Text = Tlin(0)
      Catch ex As Exception
         MessageBox.Show(ex.ToString(), "ERROR Please contact Developer", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
      objReader.Close()
   End Sub
   Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
      If String.IsNullOrEmpty(SQLString.Text) Then
         Exit Sub
        End If
        TxtRslt.Text = String.Empty
      'run SQL Command
      Dim objwriter1 As IO.StreamWriter = Nothing
      ' Start a local transaction with ReadCommitted isolation level.
        Dim SS As OleDbTransaction = CN.BeginTransaction(IsolationLevel.ReadCommitted)
        Dim SqlStr As String = SQLString.Text.Trim
        Dim StrLen As Integer = SqlStr.Length - 1   'Block size
        Dim NumLines As Integer = SqlStr.Split(";").Length - 1 'Number of blocks to be executed
        Dim SqlExectued As Integer = 1
        Dim ExCMD As New OleDbCommand
        For I As Integer = 0 To NumLines - 1 'How many SemiColons !
            Dim SqlExecutedlen As Integer = SqlStr.IndexOf(";")
            Dim SqlStrTobeExec As String = SqlStr.Substring(I, SqlExecutedlen) 'From
            With ExCMD
                .Connection = CN
                .CommandType = CommandType.Text
                ' Assign transaction object for a pending local transaction.
                .Transaction = SS
                'Many SQL Commands in the textbox separated by ;
                .CommandText = SqlStrTobeExec
                .ExecuteNonQuery()
            End With
            Try
                SS.Commit()
            Catch ex As Exception
                SS.Rollback()
                ' Do nothing here; transaction is not active.
                TxtRslt.Text = "Transaction Error :" & vbCrLf & (ex.ToString() & vbCrLf & "ERROR Please contact Developer")
                Exit For
                Exit Sub
            End Try
            SqlExectued = SqlStrTobeExec.Length
        Next
        SS.Dispose()
        ' Commit the transaction
         Application.DoEvents()
         objwriter1 = New System.IO.StreamWriter("..\..\ini\SQL" & Now.Day & Now.Minute & ".sql", True)
         objwriter1.Write(vbCrLf & LoggedInNm & " on " & Now.ToLongDateString & vbCrLf & SQLString.Text.Trim & vbCrLf)
         objwriter1.Close()
         ConnectBtn_Click(sender, e)
         TxtRslt.Text = ""
         TxtRslt.Text = "SQL Statement executed successfully"
      'Prevent app to execute statement already executed
        SQLStmnt = String.Empty
   End Sub
   Private Sub TV1_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TV1.AfterSelect
      Dim I As Integer = TV1.Nodes.Count - 1
      For N As Integer = 0 To I
         If TV1.SelectedNode.Level.ToString = 0 Then
            'TY.Text = TV1.SelectedNode.Text & " " & "is TABLE"
            'TABLES
            SELECTED_TABLE = TV1.SelectedNode.Text
         ElseIf TV1.SelectedNode.Level.ToString = 1 Then
            ' TY.Text = TV1.SelectedNode.Text & " " & "is FIELD"
            '  TY.Text += vbCrLf & "Derived from " & TV1.SelectedNode.Parent.Text
            'FIELDS
            SELECTED_FIELD = TV1.SelectedNode.Text
            SELECTED_TABLE = TV1.SelectedNode.Parent.Text
         ElseIf TV1.SelectedNode.Level.ToString = 2 Then
            '  TY.Text = TV1.SelectedNode.Text & " " & "is DATATYPE"
            '  TY.Text += vbCrLf & "Derived from " & TV1.SelectedNode.Parent.Text
            'DATATYPES
            SELECTED_DATATYPE = TV1.SelectedNode.Text
            SELECTED_TABLE = TV1.SelectedNode.Parent.Text
         Else
            'TY.Text = ""
            Exit Sub
         End If
      Next
   End Sub
   Private Sub TV1_NodeMouseClick(sender As Object, e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TV1.NodeMouseClick
      If e.Button = Windows.Forms.MouseButtons.Right And e.Node.IsSelected = True And e.Node.Level.ToString = 0 Then
         TblMnuStrp.Show(MousePosition.X, MousePosition.Y)
      End If
   End Sub
   Private Sub DROPToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DROPToolStripMenuItem.Click
      SQLStmnt &= ("DROP TABLE [" & SELECTED_TABLE & "];") & vbCrLf
      SQLString.Text = SQLStmnt
   End Sub
   Private Sub TV1_NodeMouseDoubleClick(sender As Object, e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TV1.NodeMouseDoubleClick
      If e.Button = Windows.Forms.MouseButtons.Left And e.Node.IsSelected = True And e.Node.Level.ToString = 1 Then
         Dim NodeCMD As New OleDbCommand
         With NodeCMD
            .Connection = CN
            .CommandType = CommandType.Text
            .CommandText = ("SELECT * FROM [" & e.Node.Parent.Text & "]")
         End With
         Dim NodeReader As OleDbDataReader = NodeCMD.ExecuteReader
         TxtRslt.Text = ""
         While NodeReader.Read = True
            If IsDBNull(NodeReader("" & e.Node.Text & "")) Then
               TxtRslt.Text &= ("0000000")
               Exit Sub
            End If
            TxtRslt.Text &= NodeReader("" & e.Node.Text & "") & vbCrLf
         End While
         NodeReader.Close()
      End If
   End Sub
End Class