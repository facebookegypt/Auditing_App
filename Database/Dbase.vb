Imports System.IO
Imports System.Text

Public Class Dbase

    Private Sub Dbase_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainFrm.Enabled = True
    End Sub

    Private Sub Dbase_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Close()
        End If
    End Sub
    Private Sub Dbase_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim fs As FileStream
        If Not File.Exists("..\..\Ini\ConStr.txt") Then
            fs = File.Create("..\..\Ini\ConStr.txt")
            'Create file if not exist
            fs.Close()
            fs.Dispose()
            Dim StreamRdr As StreamReader = New StreamReader("..\..\Ini\ConStr.txt")
            Dim ConStr As String = StreamRdr.ReadLine
            TxtDBLoc.Text = ConStr
            StreamRdr.Close()
            StreamRdr.Dispose()
            Lblstat.Text = ("Settings were created for Database")
        Else
            Dim StreamRdr As StreamReader = New StreamReader("..\..\Ini\ConStr.txt")
            Dim ConStr As String = StreamRdr.ReadToEnd
            Dim This1 As String() = ConStr.Split(vbCrLf)
            If String.IsNullOrEmpty(ConStr) Then
                StreamRdr.Close()
                StreamRdr.Dispose()
                ConnStr = ""
                Lblstat.Text = ("No Database was choosen")
                Exit Sub
            Else
                TxtDBLoc.Text = This1(0)
                If (This1(1).TrimStart) = "True" Then
                    SaveSetBtn.Enabled = False
                    StreamRdr.Close()
                    StreamRdr.Dispose()
                    Lblstat.Text = ("Database settings were already set")
                Else
                    SaveSetBtn.Enabled = True
                    StreamRdr.Close()
                    StreamRdr.Dispose()
                    Lblstat.Text = ("Database settings weren't set")
                End If
                StreamRdr.Close()
                StreamRdr.Dispose()
            End If
            StreamRdr.Close()
            StreamRdr.Dispose()
        End If
    End Sub
    Private Sub DBbrowse_Click(sender As System.Object, e As System.EventArgs) Handles DBbrowse.Click
        Dim Ofd As New OpenFileDialog
        With Ofd
            .Filter = ("Microsoft Access Database 2003 (*.mdb)|*.mdb")
            .Title = ("Locate MS-Access 2003 Database")
            .ShowDialog()
            TxtDBLoc.Text = .FileName
        End With
    End Sub
    Private Sub DCBtn_Click(sender As System.Object, e As System.EventArgs) Handles DCBtn.Click
        'Disconnects the Database
        If CN.State = 1 Then CN.Close()

        IO.File.WriteAllText("..\..\Ini\ConStr.txt", "" & vbCrLf & "False")
        TxtDBLoc.Text = ""
        Lblstat.Text = ("Database is disconnected")
    End Sub
    Private Sub ConnectBtn_Click(sender As System.Object, e As System.EventArgs) Handles ConnectBtn.Click
        If CheckDB(TxtDBLoc.Text.Trim) = True Then
            Lblstat.Text = ("Database found and connected")
            'Save the new Database Connection String.
            If IO.File.Exists("..\..\Ini\ConStr.txt") And FileLen("..\..\Ini\ConStr.txt") <= 0 Then
                IO.File.WriteAllText("..\..\Ini\ConStr.txt", TxtDBLoc.Text & vbCrLf & "False")

            End If
        End If
    End Sub
    Private Sub SaveSetBtn_Click(sender As System.Object, e As System.EventArgs) Handles SaveSetBtn.Click
        If IO.File.Exists("..\..\Ini\ConStr.txt") And FileLen("..\..\Ini\ConStr.txt") >= 0 Then
            IO.File.WriteAllText("..\..\Ini\ConStr.txt", TxtDBLoc.Text & vbCrLf & "True")
            Lblstat.Text = ("Connection Settings Saved")
        End If
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        DB_Struct.Show(Me)
    End Sub
End Class