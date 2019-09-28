Imports System.Data.OleDb
Public Class Cntrctrs
    Public CMDB As New OleDbCommandBuilder
    Dim DS As New Data.DataSet
   Dim SQL As String = "SELECT * FROM Contractors"
   Dim connection As New OleDbConnection(GetConStr)
    Dim dataadapter As New OleDbDataAdapter(SQL, connection)
    Private Sub Cntrctrs_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainFrm.Enabled = True
    End Sub
   Private Sub Cntrctrs_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      connection.Open()
      dataadapter.Fill(DS, "Contractors")
      DGCntractrs.DataSource = DS
      DGCntractrs.DataMember = "Contractors"
      DGCntractrs.Columns(0).HeaderText = ("ID")
      DGCntractrs.Columns(1).HeaderText = ("اسم المقاول")
      Dim L As Integer = DGCntractrs.Columns.Count
      With DGCntractrs
            For I As Integer = 0 To L - 1
                .Columns(I).Width = DGCntractrs.Width / L
            Next
      End With
        DGCntractrs.Columns(0).ReadOnly = True
        connection.Close()
   End Sub
    Private Sub DGCntractrs_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DGCntractrs.KeyDown
        If e.KeyCode = Keys.Escape Then
            If DS.HasChanges Then
                MsgBox("لقد اجريت تعديلات على المقاولين, هل تريد حفظ هذه التغيرات ؟", _
                        vbYesNoCancel + MsgBoxStyle.MsgBoxRight + vbCritical, _
                        "تعديلات على المقاولين")
                If vbYes Then
                    'ThisDset.AcceptChanges()
                    CMDB.DataAdapter = dataadapter
                    dataadapter.Update(DS, "Contractors")
                    MsgBox("تم اعتماد التعديلات")
                End If
            End If
            Close()
        End If
    End Sub
End Class