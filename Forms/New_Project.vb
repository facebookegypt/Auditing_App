Imports System.Data.OleDb
Imports System.Data
Public Class New_Project
    Public CMDB As New OleDb.OleDbCommandBuilder
    Dim DS As New DataSet
    Dim SQL As String = "SELECT * FROM Projects"
    Dim connection As New OleDbConnection(GetConStr)
    Dim dataadapter As New OleDbDataAdapter(SQL, connection)
    Private Sub New_Project_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainFrm.Enabled = True
    End Sub
    Private Sub New_Project_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If DS.HasChanges Then
                MsgBox("لقد اجريت تعديلات على المشروعات, هل تريد حفظ هذه التغيرات ؟", _
                        vbYesNoCancel + MsgBoxStyle.MsgBoxRight + vbCritical, _
                        "تعديلات على المشروعات")
                If vbYes Then
                    'ThisDset.AcceptChanges()
                    CMDB.DataAdapter = dataadapter
                    Try
                        dataadapter.Update(DS, "Projects")
                    Catch ex As Exception
                        MsgBox("مشكله : لم يتم اعتماد التعديل" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
                        Close()
                    End Try
                    MsgBox("تم اعتماد التعديلات")
                End If
            End If
            Close()
        End If
    End Sub
    Private Sub New_Project_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Using disconnected mode to facitate the (Add, Edit, Delete) process.
        connection.Open()
        dataadapter.Fill(DS, "Projects")
        DGProjects.DataSource = DS
        DGProjects.DataMember = "Projects"
        DGProjects.Columns(0).HeaderText = ("م.")
        DGProjects.Columns(0).ReadOnly = True
        DGProjects.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        'DGProjects.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGProjects.Columns(1).HeaderText = ("اسم المشروع")
        DGProjects.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        DGProjects.Columns(2).HeaderText = ("نبذه عن المشروع")
        DGProjects.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'DGProjects.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DGProjects.Columns(0).ReadOnly = True
        connection.Close()
    End Sub
End Class