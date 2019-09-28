Public Class Edit_Contract

   Private Sub Edit_Contract_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      '   Dim objReader As IO.StreamReader = Nothing
      '  Try
      'objReader = New System.IO.StreamReader("..\..\ini\SqlCmd.sql")
      'Txt1.Text = objReader.ReadToEnd()
      'objReader.Close()
      'Catch ex As Exception
      ' MessageBox.Show(ex.ToString(), "ERROR Please contact Developer", MessageBoxButtons.OK, MessageBoxIcon.Error)
      ' End Try
   End Sub
   Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
      'Create New
      Dim objwriter As IO.StreamWriter = Nothing
      Try
         objwriter = New System.IO.StreamWriter("..\..\ini\" & SqlFileNm.Text & "")
         objwriter.Write(Txt1.Text)
      Catch ex As Exception
         MessageBox.Show(ex.ToString(), "ERROR Please contact Developer", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
      objwriter.Close()
   End Sub
   Private Sub RegisterButton_Click(sender As System.Object, e As System.EventArgs) Handles RegisterButton.Click
      'Update
      Dim objwriter As IO.StreamWriter = Nothing
      Try
         objwriter = New System.IO.StreamWriter("..\..\ini\SqlCmd.sql", False)
         objwriter.Write(Txt1.Text)
      Catch ex As Exception
         MessageBox.Show(ex.ToString(), "ERROR Please contact Developer", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
      objwriter.Close()
   End Sub
End Class