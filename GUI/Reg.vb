Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Reg
    Sub clearall()
      For Each CTL As Control In Me.GroupBox1.Controls
         If TypeOf CTL Is TextBox Then
            CTL.Text = Trim("")
         End If
      Next
    End Sub
    Private Sub OKButton_Click(sender As System.Object, e As System.EventArgs) Handles OKButton.Click
        If Trim(AdminUname.Text) <> AdminUserName Or Trim(AdminP.Text) <> AdminPassWord Then
            MsgBox("- Registeration failed." & vbCrLf & "Admin UserName Or Password is not correct.", _
                   MsgBoxStyle.Critical, Application.ProductName)
            AdminUname.Select()
            Exit Sub
        End If

      If String.IsNullOrWhiteSpace(Uname.Text) Or String.IsNullOrWhiteSpace(Pass.Text) Then
         MsgBox("- Registeration failed." & vbCrLf & "UserName Or Password and Empty.", _
                MsgBoxStyle.Critical, Application.ProductName)
         Uname.Select()
         Exit Sub
      End If

      Dim ThisUser, ThisPass As String
      ThisUser = Uname.Text.Trim
      ThisPass = Pass.Text.Trim
      'Register New User
        DBConnected()
      Dim SqlStr As String = ("")
      SqlStr = _
          ("Insert INTO Regs ([UDate],UserName,[PassWord],Uname,CntrctNM,ProjNM,Rank,ArchID) " & _
           "VALUES (#" & Now.ToShortDateString & "#,'" & ThisUser & "','" & ThisPass & "','" & AdminUname.Text & "','','','User','')")
      Dim CMD As New OleDbCommand
      With CMD
         .Connection = CN
         .CommandType = CommandType.Text
         .CommandText = SQLSTR
      End With
      Dim Onh As Integer = CMD.ExecuteNonQuery
      MsgBox("User Saved " & Onh)
    End Sub
    Private Sub ClearButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearButton.Click
        clearall()
    End Sub
   Private Sub CancelButton_Click(sender As System.Object, e As System.EventArgs) Handles CancelBtn.Click
      Me.Close()
   End Sub
   Private Sub Reg_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
      'Escape Press
      If e.KeyChar = Chr(Keys.Escape) Then
         Me.Dispose()
      End If
   End Sub
   Private Sub Reg_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
   End Sub
End Class