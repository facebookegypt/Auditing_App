<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BanksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrencyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DalilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewContractToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditContractsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContractorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContractsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubContractorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasicInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BonusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageSectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewUserProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChangeLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStrpTimeDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StripTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CLRD = New System.Windows.Forms.ColorDialog()
        Me.FDL = New System.Windows.Forms.FontDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.PassWordText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UserNameText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.MainMenu.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.BackColor = System.Drawing.Color.AliceBlue
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProjectsToolStripMenuItem, Me.InvoicesToolStripMenuItem, Me.EmployeesToolStripMenuItem, Me.SectionsToolStripMenuItem, Me.ToolStripMenuItem1, Me.DatabaseToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MainMenu.Size = New System.Drawing.Size(675, 25)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "My Main Menu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BanksToolStripMenuItem, Me.CurrencyToolStripMenuItem, Me.DalilToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(45, 21)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'BanksToolStripMenuItem
        '
        Me.BanksToolStripMenuItem.Name = "BanksToolStripMenuItem"
        Me.BanksToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BanksToolStripMenuItem.Text = "Banks"
        '
        'CurrencyToolStripMenuItem
        '
        Me.CurrencyToolStripMenuItem.Name = "CurrencyToolStripMenuItem"
        Me.CurrencyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CurrencyToolStripMenuItem.Text = "Currency"
        '
        'DalilToolStripMenuItem
        '
        Me.DalilToolStripMenuItem.Name = "DalilToolStripMenuItem"
        Me.DalilToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DalilToolStripMenuItem.Text = "Dalil"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ProjectsToolStripMenuItem
        '
        Me.ProjectsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripSeparator2, Me.NewContractToolStripMenuItem, Me.EditContractsToolStripMenuItem, Me.ToolStripMenuItem4, Me.ContractorsToolStripMenuItem, Me.ContractsToolStripMenuItem, Me.SubContractorsToolStripMenuItem})
        Me.ProjectsToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectsToolStripMenuItem.Name = "ProjectsToolStripMenuItem"
        Me.ProjectsToolStripMenuItem.Size = New System.Drawing.Size(74, 21)
        Me.ProjectsToolStripMenuItem.Text = "&Projects"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.NewToolStripMenuItem.Text = "&New Project"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(175, 6)
        '
        'NewContractToolStripMenuItem
        '
        Me.NewContractToolStripMenuItem.Name = "NewContractToolStripMenuItem"
        Me.NewContractToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.NewContractToolStripMenuItem.Text = "New &Contract"
        '
        'EditContractsToolStripMenuItem
        '
        Me.EditContractsToolStripMenuItem.Name = "EditContractsToolStripMenuItem"
        Me.EditContractsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.EditContractsToolStripMenuItem.Text = "Edit Cont&racts"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(175, 6)
        '
        'ContractorsToolStripMenuItem
        '
        Me.ContractorsToolStripMenuItem.Name = "ContractorsToolStripMenuItem"
        Me.ContractorsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ContractorsToolStripMenuItem.Text = "C&ontractors"
        '
        'ContractsToolStripMenuItem
        '
        Me.ContractsToolStripMenuItem.Name = "ContractsToolStripMenuItem"
        Me.ContractsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ContractsToolStripMenuItem.Text = "Contracts"
        '
        'SubContractorsToolStripMenuItem
        '
        Me.SubContractorsToolStripMenuItem.Name = "SubContractorsToolStripMenuItem"
        Me.SubContractorsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SubContractorsToolStripMenuItem.Text = "SubContractors"
        '
        'InvoicesToolStripMenuItem
        '
        Me.InvoicesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewInvoiceToolStripMenuItem})
        Me.InvoicesToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.InvoicesToolStripMenuItem.Name = "InvoicesToolStripMenuItem"
        Me.InvoicesToolStripMenuItem.Size = New System.Drawing.Size(76, 21)
        Me.InvoicesToolStripMenuItem.Text = "&Invoices"
        '
        'NewInvoiceToolStripMenuItem
        '
        Me.NewInvoiceToolStripMenuItem.Name = "NewInvoiceToolStripMenuItem"
        Me.NewInvoiceToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.NewInvoiceToolStripMenuItem.Text = "New Invoice"
        '
        'EmployeesToolStripMenuItem
        '
        Me.EmployeesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicInfoToolStripMenuItem, Me.ToolStripMenuItem3, Me.BonusToolStripMenuItem})
        Me.EmployeesToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
        Me.EmployeesToolStripMenuItem.Size = New System.Drawing.Size(92, 21)
        Me.EmployeesToolStripMenuItem.Text = "&Employees"
        '
        'BasicInfoToolStripMenuItem
        '
        Me.BasicInfoToolStripMenuItem.Name = "BasicInfoToolStripMenuItem"
        Me.BasicInfoToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.BasicInfoToolStripMenuItem.Text = "Basic Info"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(172, 6)
        '
        'BonusToolStripMenuItem
        '
        Me.BonusToolStripMenuItem.Name = "BonusToolStripMenuItem"
        Me.BonusToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.BonusToolStripMenuItem.Text = "Bo&nus 50 && 80"
        '
        'SectionsToolStripMenuItem
        '
        Me.SectionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageSectionsToolStripMenuItem})
        Me.SectionsToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionsToolStripMenuItem.Name = "SectionsToolStripMenuItem"
        Me.SectionsToolStripMenuItem.Size = New System.Drawing.Size(75, 21)
        Me.SectionsToolStripMenuItem.Text = "Section&s"
        '
        'ManageSectionsToolStripMenuItem
        '
        Me.ManageSectionsToolStripMenuItem.Name = "ManageSectionsToolStripMenuItem"
        Me.ManageSectionsToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ManageSectionsToolStripMenuItem.Text = "Manage Sections"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageUserToolStripMenuItem, Me.CreateUserToolStripMenuItem, Me.ToolStripMenuItem2, Me.ViewUserProfile, Me.LogoutToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(59, 21)
        Me.ToolStripMenuItem1.Text = "&Users"
        '
        'ManageUserToolStripMenuItem
        '
        Me.ManageUserToolStripMenuItem.Enabled = False
        Me.ManageUserToolStripMenuItem.Name = "ManageUserToolStripMenuItem"
        Me.ManageUserToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ManageUserToolStripMenuItem.Text = "Manage User"
        '
        'CreateUserToolStripMenuItem
        '
        Me.CreateUserToolStripMenuItem.Enabled = False
        Me.CreateUserToolStripMenuItem.Name = "CreateUserToolStripMenuItem"
        Me.CreateUserToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CreateUserToolStripMenuItem.Text = "Create &User"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(162, 6)
        '
        'ViewUserProfile
        '
        Me.ViewUserProfile.Enabled = False
        Me.ViewUserProfile.Name = "ViewUserProfile"
        Me.ViewUserProfile.Size = New System.Drawing.Size(165, 22)
        Me.ViewUserProfile.Text = "View P&rofile"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Enabled = False
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocationToolStripMenuItem, Me.ToolStripSeparator3, Me.ChangeLocationToolStripMenuItem, Me.ChangeSettingsToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(80, 21)
        Me.DatabaseToolStripMenuItem.Text = "&Database"
        '
        'LocationToolStripMenuItem
        '
        Me.LocationToolStripMenuItem.Name = "LocationToolStripMenuItem"
        Me.LocationToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.LocationToolStripMenuItem.Text = "Info"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(184, 6)
        '
        'ChangeLocationToolStripMenuItem
        '
        Me.ChangeLocationToolStripMenuItem.Name = "ChangeLocationToolStripMenuItem"
        Me.ChangeLocationToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ChangeLocationToolStripMenuItem.Text = "Change Location"
        '
        'ChangeSettingsToolStripMenuItem
        '
        Me.ChangeSettingsToolStripMenuItem.Name = "ChangeSettingsToolStripMenuItem"
        Me.ChangeSettingsToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ChangeSettingsToolStripMenuItem.Text = "Change Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(52, 21)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrpTimeDate, Me.ToolStripStatusLabel1, Me.StripTime, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 417)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(675, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStrpTimeDate
        '
        Me.ToolStrpTimeDate.Name = "ToolStrpTimeDate"
        Me.ToolStrpTimeDate.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(11, 17)
        Me.ToolStripStatusLabel1.Text = "|"
        '
        'StripTime
        '
        Me.StripTime.Name = "StripTime"
        Me.StripTime.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(11, 17)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(284, 17)
        Me.ToolStripStatusLabel3.Text = "Auditing Application (C) Ahmed Samir @ 2013"
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RegisterButton)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.OKButton)
        Me.GroupBox1.Controls.Add(Me.PassWordText)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.UserNameText)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(120, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 194)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'RegisterButton
        '
        Me.RegisterButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.RegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RegisterButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegisterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegisterButton.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterButton.Location = New System.Drawing.Point(37, 145)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(120, 32)
        Me.RegisterButton.TabIndex = 6
        Me.RegisterButton.Text = "&LogOut"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClearButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(163, 145)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(119, 32)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OKButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OKButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OKButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKButton.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKButton.Location = New System.Drawing.Point(288, 145)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(119, 32)
        Me.OKButton.TabIndex = 4
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'PassWordText
        '
        Me.PassWordText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PassWordText.BackColor = System.Drawing.Color.White
        Me.PassWordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PassWordText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassWordText.Location = New System.Drawing.Point(122, 75)
        Me.PassWordText.Name = "PassWordText"
        Me.PassWordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassWordText.Size = New System.Drawing.Size(285, 25)
        Me.PassWordText.TabIndex = 3
        Me.PassWordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'UserNameText
        '
        Me.UserNameText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserNameText.BackColor = System.Drawing.Color.White
        Me.UserNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserNameText.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameText.Location = New System.Drawing.Point(122, 32)
        Me.UserNameText.Name = "UserNameText"
        Me.UserNameText.Size = New System.Drawing.Size(285, 25)
        Me.UserNameText.TabIndex = 2
        Me.UserNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "User Name"
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(0, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(675, 102)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Welcome"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(120, 344)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(77, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Remember"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'MainFrm
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(675, 439)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "MainFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditing Department - Financials Sector 2013"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
   Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
   Friend WithEvents ToolStrpTimeDate As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents Timer1 As System.Windows.Forms.Timer
   Friend WithEvents StripTime As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents CLRD As System.Windows.Forms.ColorDialog
   Friend WithEvents FDL As System.Windows.Forms.FontDialog
   Friend WithEvents ProjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents NewContractToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents EditContractsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents UserNameText As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents PassWordText As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents OKButton As System.Windows.Forms.Button
   Friend WithEvents ClearButton As System.Windows.Forms.Button
   Friend WithEvents RegisterButton As System.Windows.Forms.Button
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents LocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents ChangeLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ChangeSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ViewUserProfile As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents CreateUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ManageUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BonusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SectionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ManageSectionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents BasicInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents ContractorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
   Friend WithEvents DalilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContractsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvoicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewInvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurrencyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubContractorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BanksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
