Imports System.Data.OleDb
Public Class Dalil
   Dim SQLsTR As String = ""

   Private Sub Dalil_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
      If e.KeyChar = ChrW(Keys.Escape) Then
         Me.Dispose()
      End If
   End Sub
   Private Sub Dalil_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DBConnected()
   End Sub

   Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
      If Not IsNumeric(TextBox1.Text) Then
         SendKeys.Send("{BACKSPACE}")
         Beep()
         TextBox1.Text = Trim("")
         TextBox2.Text = Trim("")
         Exit Sub
      End If
      If TextBox1.Text = Trim("") Then TextBox1.Text = Trim("")
      Dim CMDDalil As New OleDbCommand
        SQLsTR = ("SELECT * FROM Dalil where AccNo = '" & Trim(TextBox1.Text) & "'")
      With CMDDalil
         .Connection = CN
         .CommandType = Data.CommandType.Text
         .CommandText = sqlstr
      End With
      Dim drDalil As OleDbDataReader = CMDDalil.ExecuteReader
      If drDalil.Read = False Then
         TextBox2.Text = ("لا يوجد حساب بهذا الرقم")
         Exit Sub
      End If
      If IsDBNull(drDalil!AccNm) Then
         TextBox2.Text = ("0000000")
         Exit Sub
      End If
      TextBox2.Text = Trim(drDalil!AccNm)
      TextBox3.Text = Trim(drDalil!AccDesc.ToString)
      drDalil.Close()
   End Sub
   Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
      If String.IsNullOrEmpty(TextBox1.Text) Then
         MsgBox("أكتب رقم الحساب أولا")
         Exit Sub
      End If

   End Sub
   Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
      If String.IsNullOrEmpty(TextBox1.Text) Then
         MsgBox("أكتب رقم الحساب أولا")
         Exit Sub
      End If
      If TextBox2.Text = ("لا يوجد حساب بهذا الرقم") Then
         MsgBox("أكتب رقم حساب صحيح أولا")
         Exit Sub
      End If
      SQLsTR = ""
      SQLsTR = ("UPDATE Dalil SET AccNm = '" & TextBox2.Text & "', AccDesc = '" & TextBox3.Text.Trim & "' WHERE AccNo = '" & TextBox1.Text.Trim & "'")
      With CMD
         .Connection = CN
         .CommandType = Data.CommandType.Text
         .CommandText = SQLsTR
      End With
      Dim Onh As Int16 = CMD.ExecuteNonQuery
      MsgBox(Onh & " Updated")
   End Sub
End Class