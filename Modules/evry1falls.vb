Imports System
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.Data.OleDb
Module evry1falls
   Public Const AdminUserName As String = ("Admin")
   Public Const AdminPassword As String = ("AhmedSamir1_")
   Public LoggedIn As Boolean = False
    Public LoggedInAsAdmin As Boolean = False
    Public LoggedInNm As String = String.Empty
    Public Frm As Form
    Public Tcntrct As String = String.Empty  'Chosen Contract
   ' SubKey under HKEY_CURRENT_USER that stores settings for this application
   Public Const SettingsLocation As String = "Software\\Financials\\Auditing\\New2013"
    Public DefaultCurrIcoLocation As String = IO.Path.Combine(Application.StartupPath & "\money.png")
   ' Get a project-specific string setting from the registry
    Public Function GetStringSetting(ByVal specificKey As String) As String
        Try
            Dim RegKey As RegistryKey = Registry.CurrentUser.CreateSubKey(SettingsLocation)
            Dim specificValue As String = RegKey.GetValue(specificKey, String.Empty).ToString()
            Return specificValue
        Catch
            Return String.Empty
        End Try
    End Function
   ' Save a project-specific string setting to the registry
   Public Sub SaveStringSetting(ByVal specificKey As String, ByVal specificValue As String)
      Try
         Dim RegKey As RegistryKey = Registry.CurrentUser.CreateSubKey(SettingsLocation)
         RegKey.SetValue(specificKey, specificValue)
      Catch
      End Try
   End Sub
   ' Return the current path
   Public Function GetAppPath() As String
      Return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location)
   End Function
    Public Function DBConnected() As Boolean
        If CN.State = 1 Then CN.Close()
        CN.ConnectionString = GetConStr()
        Try
            CN.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            Exit Function
        End Try
        Return True
    End Function
    Public Sub UpdateTreeView(TRV As TreeView, SqlStr As String)
        TRV.Nodes.Clear()
        Dim ImgLst As New ImageList()
        Dim TRN As TreeNode
        '#Region "Populate ImageList"
        'Populate ImageList With Images from Database Table [BasicInfo]---------
        TRV.ImageList = ImgLst
        Dim ImgCMD As New OleDbCommand
        _ExcuteCMD(SqlStr, ImgCMD)
        Dim ImgReader As OleDbDataReader = ImgCMD.ExecuteReader
        If ImgReader.HasRows Then
            While ImgReader.Read
                'User Photo=========================================
                Dim ImageBytes As Byte() = CType(ImgReader!CurrIco, Byte())
                Dim MyStream As New IO.MemoryStream(ImageBytes)
                Dim IMG As Image = Image.FromStream(MyStream)
                ImgLst.Images.Add(ImgReader!CurrID.ToString, IMG)
                MyStream.Flush()
                MyStream.Close()
                '===================================================
            End While
            ImgReader.Close()
        End If
        ImgCMD.Dispose()
        '---------------------------------------------------------------------------
        TRV.BeginUpdate()
        Dim SelectCMD As New OleDbCommand
        _ExcuteCMD(sqlSTR, SelectCMD)
        Dim SelectReader As OleDbDataReader = SelectCMD.ExecuteReader
        If SelectReader.HasRows Then
            While SelectReader.Read
                'TRN : Full Name
                TRN = New TreeNode(SelectReader!CurrID.ToString)
                With TRN
                    .Name = SelectReader!CurrID
                    .Text = SelectReader!CurrName & "," & "(" & SelectReader!CurrSymbol & ")" & SelectReader!CurrSign
                    .StateImageKey = SelectReader!CurrID.ToString
                    .ImageKey = SelectReader!CurrID.ToString
                    .SelectedImageKey = SelectReader!CurrID.ToString
                End With
                TRV.Nodes.Add(TRN)
            End While
            SelectReader.Close()
        End If
        TRV.EndUpdate()
    End Sub
End Module
