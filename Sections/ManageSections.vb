Imports System.Data.OleDb
Public Class ManageSections
   Sub UpdateLst(ByVal Lst As ListBox, TablNm As String, FldNm As String)
      Lst.Items.Clear()
      With CMD
         .Connection = CN
         .CommandType = Data.CommandType.Text
         .CommandText = "SELECT * FROM " & TablNm
      End With
      Dim DataR As OleDbDataReader = CMD.ExecuteReader
      Do Until DataR.Read = False
         Lst.Items.Add(DataR(FldNm))
      Loop
      DataR.Close()
   End Sub
    Private Sub SPC_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SPC.Panel2.Paint

    End Sub
    Private Sub ManageSections_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBConnected()
      UpdateLst(LstSec, "Sections", "SecNm")
      UpdateLst(LstDep, "Department", "DepNm")
    End Sub
   Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
      Try
         If Not String.IsNullOrEmpty(TxtSecNm.Text) Then
            With CMD
               .Connection = CN
               .CommandType = Data.CommandType.Text
               .CommandText = "Insert Into Sections (SecNm) VALUES ('" & TxtSecNm.Text.Trim & "')"
            End With
            Dim Onh As Integer = CMD.ExecuteNonQuery
            UpdateLst(LstSec, "Sections", "SecNm")
            MsgBox(Onh & " Saved")
         Else
            MsgBox("أدخل اسم القطاع أولا")
            Exit Sub
         End If
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try

   End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TxtSecNm.Clear()
    End Sub
   Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
      Try
         If Not String.IsNullOrEmpty(TxtDep.Text) Then
            With CMD
               .Connection = CN
               .CommandType = Data.CommandType.Text
               .CommandText = "Insert Into Department (DepNm) VALUES ('" & TxtDep.Text.Trim & "')"
            End With
            Dim Onh As Integer = CMD.ExecuteNonQuery
            UpdateLst(LstDep, "Department", "DepNm")
            MsgBox(Onh & " Saved")
         Else
            MsgBox("أدخل اسم الادارة أولا")
            Exit Sub
         End If
      Catch ex As Exception
         MsgBox(ex.Message)
      End Try

   End Sub
End Class