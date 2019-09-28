Imports System.IO
Imports System.Data.OleDb
Public Class MainFrm
   Dim Dpath As String()
   Dim RemChk As String = "False"
   Sub clearall()
      For Each CTL As Control In Me.GroupBox1.Controls
         If TypeOf CTL Is TextBox Then
            CTL.Text = Trim("")
         End If
      Next
   End Sub
   Private Sub MainFrm_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
      Me.Width = GetStringSetting("Width")
      Me.Height = GetStringSetting("Height")
      'ColorSettings
      Dim MyColor As Color
      MyColor = Color.FromName(GetStringSetting("BackColor"))
      If MyColor.B < 255 Then
         MyColor = Color.LightGray
         Me.BackColor = MyColor
      End If
      Me.BackColor = MyColor
      'End ColorSettings
      'Database===============================================
      Dim FS As IO.FileStream
      If File.Exists("..\..\Ini\ConStr.txt") Then
         FS = File.OpenRead("..\..\Ini\ConStr.txt")
         Dim StreamRdr As StreamReader = New StreamReader(FS)
         Dim Dloc As String = StreamRdr.ReadToEnd
         Dpath = Dloc.Split(vbCrLf)
         If CheckDB(Dpath(0)) Then
            GroupBox1.Enabled = True
         Else
            GroupBox1.Enabled = True
         End If
         StreamRdr.Close()
         StreamRdr.Dispose()
      Else
         GroupBox1.Enabled = False
      End If
      '=======================================================
   End Sub
   Private Sub MainFrm_BackColorChanged(sender As Object, e As System.EventArgs) Handles Me.BackColorChanged
      SaveStringSetting("BackColor", Me.BackColor.ToString)
   End Sub
   Private Sub MainFrm_Deactivate(sender As Object, e As System.EventArgs) Handles Me.Deactivate
      SaveStringSetting("Width", Me.Width.ToString)
      SaveStringSetting("Height", Me.Height.ToString)
      SaveStringSetting("BackColor", Me.BackColor.ToString)
   End Sub
   Private Sub MainFrm_FontChanged(sender As Object, e As System.EventArgs) Handles Me.FontChanged
      SaveStringSetting("BackColor", Me.Font.Name)
   End Sub
   Private Sub MainFrm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      SaveStringSetting("Width", Me.Width.ToString)
      SaveStringSetting("Height", Me.Height.ToString)
      SaveStringSetting("BackColor", Me.BackColor.ToString)
      Call ExitToolStripMenuItem_Click(sender, e)
   End Sub
   Private Sub MainFrm_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
      'Escape Press
      If e.KeyChar = Chr(Keys.Escape) Then
         If RemChk = "False" Then
            SaveStringSetting("User", "".ToString)
            SaveStringSetting("Pass", "".ToString)
         ElseIf RemChk = "True" Then
            SaveStringSetting("User", UserNameText.Text.ToString)
            SaveStringSetting("Pass", PassWordText.Text.ToString)
         End If

         SaveStringSetting("Width", Me.Width.ToString)
         SaveStringSetting("Height", Me.Height.ToString)
         SaveStringSetting("BackColor", Me.BackColor.ToString)
         Call ExitToolStripMenuItem_Click(sender, e)
      End If
   End Sub
   Private Sub MainFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      RemChk = GetStringSetting("Remember")
      If RemChk = "False" Then
         CheckBox1.CheckState = CheckState.Unchecked
         UserNameText.Text = ""
         PassWordText.Text = ""
      ElseIf RemChk = "True" Then
         CheckBox1.CheckState = CheckState.Checked
         UserNameText.Text = GetStringSetting("User")
         PassWordText.Text = GetStringSetting("Pass")
      Else
         CheckBox1.CheckState = CheckState.Indeterminate
      End If
      Timer1.Enabled = True
   End Sub
   Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim Msg As String
      Msg = MsgBox("Do you want to exit?", vbYesNo + MsgBoxStyle.Information, _
                   Application.ProductName + " - Exit")
        If Msg = vbYes Then
            End
        ElseIf Msg = vbNo Then
            Exit Sub
        End If
   End Sub
   Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
      'Date & Time setting
      ToolStrpTimeDate.Text = "Date [" & Format(Now, "dddd  dd, MMMM, yyyy") & " ]"
      StripTime.Text = "Time GMT+2 [" & Format(Now, "hh:mm:ss tt") & " ]"
   End Sub
   Private Sub SettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
      Dim My_Settings As New Settings
      If LoggedInAsAdmin Then
            My_Settings.Show()
            Me.Enabled = False
      Else
         MsgBox("Not Allowed : " & vbCrLf & _
                 "Admins Only.")
         Exit Sub
      End If
   End Sub
   Private Sub MainFrm_ResizeEnd(sender As Object, e As System.EventArgs) Handles Me.ResizeEnd
      SaveStringSetting("Width", Me.Width.ToString)
      SaveStringSetting("Height", Me.Height.ToString)
      SaveStringSetting("BackColor", Me.BackColor.ToString)
      Me.StartPosition = FormStartPosition.CenterScreen
   End Sub
   Private Sub BackColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
      CLRD.ShowDialog()
      Me.BackColor = CLRD.Color
      SaveStringSetting("BackColor", Me.BackColor.ToString)
   End Sub
   Private Sub FontColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
      FDL.ShowDialog()
      Me.Font = FDL.Font
   End Sub
   Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
      About.ShowDialog()
   End Sub
   Private Sub RegisterButton_Click(sender As System.Object, e As System.EventArgs) Handles RegisterButton.Click
        If LoggedInAsAdmin Then
            GroupBox1.Enabled = True
            UserNameText.Enabled = True
            PassWordText.Enabled = True
            UserNameText.SelectAll()
            OKButton.Enabled = True
         ClearButton.Enabled = True
         LoggedInAsAdmin = False
        End If
   End Sub
   Private Sub ClearButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearButton.Click
      clearall()
   End Sub
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Try
            If String.IsNullOrWhiteSpace(UserNameText.Text) Or String.IsNullOrWhiteSpace(PassWordText.Text) Then
                MsgBox("- Login failed." & vbCrLf & "UserName Or Password is not correct or empty.", _
                       MsgBoxStyle.Critical, Application.ProductName)
                LoggedIn = False
                Exit Sub
            End If
            'Admin
            If UserNameText.Text = AdminUserName And PassWordText.Text = AdminPassword Then
                PassWordText.Enabled = False
                UserNameText.Enabled = False
                LogoutToolStripMenuItem.Enabled = True
                ViewUserProfile.Enabled = True
                OKButton.Enabled = False
                ClearButton.Enabled = False '
                ManageUserToolStripMenuItem.Enabled = True
                LoggedIn = False
                RegisterButton.Enabled = True
                LoggedInAsAdmin = True
                LoggedInNm = "Admin"
                CreateUserToolStripMenuItem.Enabled = True
                Me.Text = Me.Text + (" -|- Admin : Admin")
                Exit Sub
            Else
                LoggedInAsAdmin = False
                LoggedInNm = UserNameText.Text.Trim
            End If

            With CMD
                .Connection = CN
                .CommandType = Data.CommandType.Text
                .CommandText = ("Select * from Regs Where UserName = '" & UserNameText.Text & "'")
            End With
            Dim DR As OleDbDataReader = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                'check Password
                If DR!PassWord = PassWordText.Text Then
                    GroupBox1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Cover1.Png")
                    GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
                    PassWordText.Enabled = False
                    UserNameText.Enabled = False
                    LogoutToolStripMenuItem.Enabled = True
                    ViewUserProfile.Enabled = True
                    OKButton.Enabled = False
                    ManageUserToolStripMenuItem.Enabled = False
                    ClearButton.Enabled = False
                    RegisterButton.Enabled = False
                    DR.Close()
                    LoggedIn = True
                    Me.Text = Me.Text + " -|- User : " & UserNameText.Text
                    LoggedInNm = UserNameText.Text.Trim
                Else
                    MsgBox("Incorrect Password")
                    DR.Close()
                    LoggedIn = False
                    Exit Sub
                End If
            Else
                MsgBox("No users/admins")
                DR.Close()
                LoggedIn = False
                Exit Sub
            End If
            DR.Close()
        Catch ex As Exception
            MsgBox("ERROR Database connection is closed : " & ex.Message)
        End Try
        
    End Sub
   Private Sub ChangeLocationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChangeLocationToolStripMenuItem.Click
      'Change Database location
      If LoggedInAsAdmin Then
         Dbase.Show(Me)
      End If
   End Sub
   Private Sub LocationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LocationToolStripMenuItem.Click
      Try
         If LoggedInAsAdmin Then
            MsgBox( _
             "Database Location : " & Dpath(0) & vbCrLf & _
             "Connection String : " & CN.ConnectionString & vbCrLf & _
             "Connection Status : " & CN.State.ToString)
         End If
      Catch ex As Exception
         Dbase.ShowDialog()
      End Try
   End Sub
   Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
      Me.Refresh()
   End Sub
   Private Sub ChangeSettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChangeSettingsToolStripMenuItem.Click
      If LoggedInAsAdmin Then
         Dbase.ShowDialog()
      End If
   End Sub
   Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
      'LogOut
      GroupBox1.BackgroundImage = Nothing
      PassWordText.Enabled = True
      PassWordText.Text = ""
      UserNameText.Enabled = True
      UserNameText.Text = ""
      LogoutToolStripMenuItem.Enabled = False
      ViewUserProfile.Enabled = False
      OKButton.Enabled = True
      ClearButton.Enabled = True
   End Sub
   Private Sub CreateUserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreateUserToolStripMenuItem.Click
      'Create User
      If LoggedInAsAdmin Then
         Reg.Show(Me)
      End If
   End Sub
   Private Sub ManageUserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ManageUserToolStripMenuItem.Click
      If LoggedInAsAdmin Then
         ManageUsrs.ShowDialog()
      End If
   End Sub
   Private Sub NewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItem.Click
      If LoggedInAsAdmin Then
            New_Project.Show()
            Me.Enabled = False
      Else

      End If
   End Sub
   Private Sub NewContractToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewContractToolStripMenuItem.Click
      If LoggedInAsAdmin Then
            New_Contract.Show()
            Me.Enabled = False
      Else

      End If
    End Sub
    Private Sub BonusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BonusToolStripMenuItem.Click
        'Bonus 50 80 75
      MainEmp.ShowDialog()
    End Sub
    Private Sub ManageSectionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageSectionsToolStripMenuItem.Click
      ManageSections.ShowDialog()
    End Sub
   Private Sub BasicInfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BasicInfoToolStripMenuItem.Click
      BasicInfo.ShowDialog()
   End Sub
   Private Sub ContractorsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ContractorsToolStripMenuItem.Click
      If LoggedInAsAdmin Then
            Cntrctrs.Show(Me)
      Else

      End If
   End Sub
   Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
      SaveStringSetting("Remember", CheckBox1.Checked.ToString)
   End Sub
   Private Sub DalilToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DalilToolStripMenuItem.Click
      If LoggedInAsAdmin Then
         Dalil.ShowDialog()
      Else
         Dalil.ShowDialog()
      End If
   End Sub
   Private Sub EditContractsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditContractsToolStripMenuItem.Click
      If LoggedInAsAdmin Then
         Edit_Contract.ShowDialog()
      Else
      End If
   End Sub
   Private Sub ContractsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ContractsToolStripMenuItem.Click
        Dim ThisContract As New Contracts
        If LoggedInAsAdmin Then
            ThisContract.Show(Me)
            Enabled = False
        Else
        End If
   End Sub
    Private Sub CurrencyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CurrencyToolStripMenuItem.Click
        Dim CurrForm As New CurrencyFrm
        If LoggedInAsAdmin Then
            CurrForm.Show(Me)
            Me.Enabled = False
        Else
        End If
    End Sub
    Private Sub SubContractorsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SubContractorsToolStripMenuItem.Click
        Dim CurrForm As New SbCntrctr
        If LoggedInAsAdmin Then
            CurrForm.Show(Me)
            Me.Enabled = False
        Else
        End If
    End Sub
    Private Sub BanksToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BanksToolStripMenuItem.Click
        Dim CurrForm As New BanksForm
        If LoggedInAsAdmin Then
            CurrForm.Show(Me)
            Me.Enabled = False
        Else
        End If
    End Sub
End Class
