Imports System.Data.OleDb
Public Class BasicInfo
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
   Private Sub OKButton_Click(sender As System.Object, e As System.EventArgs) Handles OKButton.Click
      Dim CmdEmp As New OleDbCommand
        DBConnected()
      Dim SqlStr As String = _
          "INSERT INTO Emp (EmpNm,EmpSerial,EmpFixed,EmpDep,EmpSec,EmpDist,EmpDt,EmpJnm,EmpRank) "
      SqlStr = SqlStr + "VALUES('" & Tname.Text & "','" & TSerial.Text & "','" & "50" & "','" & TDep.Text & "','" & Tsec.Text & "', "
      SqlStr = SqlStr + "'" & Tdist.Text & "','" & Tdate.Value.ToShortDateString & "','" & TjNM.Text & "','" & Trnk.Text & "')"
      With CmdEmp
         .Connection = CN
         .CommandType = Data.CommandType.Text
         .CommandText = SqlStr
      End With
      Dim Onh As Integer = CmdEmp.ExecuteNonQuery
      MsgBox(Onh & " Saved.")
   End Sub
   Private Sub BasicInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      UpdateLst(Tsec, "Sections", "SecNm")
      UpdateLst(TDep, "Department", "DepNm")
   End Sub
End Class