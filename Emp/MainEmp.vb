Imports System.Data.OleDb
Public Class MainEmp

    Private Sub MainEmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBConnected()
        If Not LoggedInAsAdmin Then
            But1.Enabled = False
            But2.Enabled = False
            But3.Enabled = False
        End If
        Label5.Text = LoggedInNm
        'Combo
        
    End Sub

    Private Sub CboSec_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboSec.DropDown
        CboSec.Items.Clear()
        Dim CMDSec As New OleDbCommand
        With CMDSec
            .Connection = CN
            .CommandType = Data.CommandType.Text
            .CommandText = "SELECT * FROM Sections"
        End With

        Dim DataR As OleDbDataReader = CMDSec.ExecuteReader

        Do Until DataR.Read = False
            CboSec.Items.Add(DataR!SecNm)
        Loop
        DataR.Close()
    End Sub
    Private Sub CboSec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSec.SelectedIndexChanged

    End Sub
End Class