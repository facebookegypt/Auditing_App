Imports System.Data
Imports System.Data.OleDb
Public Class ManageUsrs
   Private Sub ManageUsrs_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
      If e.KeyChar = Chr(Keys.Escape) Then
         Me.Dispose()
      End If
   End Sub

   Private Sub CreateNewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBConnected()
      Try
         If LoggedInAsAdmin Then
            Dim SQLStr As String = ("Select * From Regs Where Regs.Rank = 'User'")
            With CMD
               .Connection = CN
               .CommandType = Data.CommandType.Text
               .CommandText = SQLStr
            End With
            UstsLst.Items.Clear()
            Dim DR As System.Data.OleDb.OleDbDataReader = CMD.ExecuteReader
            If DR.HasRows = False Then
               DR.Close()
               Exit Sub
            End If
            Do Until DR.Read = False
               UstsLst.Items.Add(DR!UserName.ToString)
            Loop
            DR.Close()
         End If
      Catch ex As Exception
         MsgBox("Error Connecting to Users Table : " & ex.Message)
      End Try

      Try
         Dim Data2 As String = ""
         Dim SqlStr3 As String = ""
         SqlStr3 = ("SELECT * FROM Contracts WHERE ID <> '';")
         Dim CMDGetArch As New OleDbCommand
         With CMDGetArch
            .Connection = CN
            .CommandType = CommandType.Text
            .CommandText = SqlStr3
         End With
         Dim DataRdrUsr As OleDbDataReader = CMDGetArch.ExecuteReader
         ArchUsrLst.Items.Clear()
         Do While DataRdrUsr.Read = True
            Data2 = DataRdrUsr!ProjNm
            Data2 &= "|" & DataRdrUsr!CntrctNM
            ArchUsrLst.Items.Add(Data2)
         Loop
         DataRdrUsr.Close()
      Catch ex As Exception
         MsgBox("Error :" & ex.Message)
      End Try
   End Sub
   Private Sub UstsLst_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles UstsLst.SelectedIndexChanged
      Try
         Dim SQLStrPass As String = ("Select * From Regs Where Regs.Rank = 'User' AND UserName = '" & UstsLst.SelectedItem.ToString & "'")
         Dim CMDGetPass As New OleDbCommand
         With CMDGetPass
            .Connection = CN
            .CommandType = Data.CommandType.Text
            .CommandText = SQLStrPass
         End With
         Dim DataPassReader As OleDbDataReader = CMDGetPass.ExecuteReader
         DataPassReader.Read()
         UserPass1.Text = (DataPassReader!PassWord)
         DataPassReader.Close()
      Catch ex As Exception
         MsgBox("Error reading User Data : " & ex.Message)
      End Try

   End Sub

   Private Sub OKButton_Click(sender As System.Object, e As System.EventArgs) Handles OKButton.Click
      'Update USER info
      Try
         Dim CMDUpdateUsr As New OleDbCommand
         Dim SqlUpdtUsr As String = ""
         SqlUpdtUsr = ("UPDATE Regs SET Udate = #" & Now.ToShortDateString & "#, PassWord='" & UserPass1.Text.Trim & "', ArchID = '" & ArchUsrLst.SelectedItem.ToString & "'")
         With CMDUpdateUsr
            .Connection = CN
            .CommandType = CommandType.Text
            .CommandText = SqlUpdtUsr
         End With
         Dim Onh As Integer = CMDUpdateUsr.ExecuteNonQuery
         MsgBox("Done!")
      Catch ex As Exception
         MsgBox("Error Updating USER INFO : " & ex.Message)
      End Try

   End Sub
End Class