Public Class About

   Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles OKbtn.Click
      Me.Dispose()
   End Sub

   Private Sub About_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

   End Sub

   Private Sub OKbtn_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles OKbtn.KeyPress
      If e.KeyChar = ChrW(Keys.Escape) Then
         Me.Dispose()
      End If
   End Sub
End Class