<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contracts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contracts))
        Me.ProjTRV = New System.Windows.Forms.TreeView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CurrTreeView = New System.Windows.Forms.TreeView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CntrctValueTextBox = New System.Windows.Forms.TextBox()
        Me.lblCurr = New System.Windows.Forms.Label()
        Me.dgvCntrcts = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvCntrcts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProjTRV
        '
        Me.ProjTRV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProjTRV.BackColor = System.Drawing.Color.Gainsboro
        Me.ProjTRV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProjTRV.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjTRV.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ProjTRV.FullRowSelect = True
        Me.ProjTRV.HideSelection = False
        Me.ProjTRV.HotTracking = True
        Me.ProjTRV.Location = New System.Drawing.Point(1, 76)
        Me.ProjTRV.Name = "ProjTRV"
        Me.ProjTRV.Size = New System.Drawing.Size(322, 331)
        Me.ProjTRV.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(841, 74)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Financial Source"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"مصادر ذاتية عن طريق تحويل مباشر", "مصادر ذاتية عن طريق اعتماد مستندي"})
        Me.ComboBox1.Location = New System.Drawing.Point(331, 103)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(185, 59)
        Me.ComboBox1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(328, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Financial Sources"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Bank"
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"بنك مصر", "البنك الأهلي المصري", "البنك العقاري المصري العربي", "بنك التنمية الصناعيه و العمال المصري", "بنك القاهرة", "المصرف المتحد (مصر)", "بنك الاسكندرية", "بنك مصر ايران للتنمية", "البنك التجاري الدولي", "البنك التجاري المغربي وفا بنك", "بنك الشركة المصرفية العربية الدولية", "بنك بلوم", "كريدي اجريكول", "بنك الامارات دبي الوطني", "بنك قناة السويس", "بنك قطر الوطني الأهلي", "بنك الاستثمار العربي", "البنك الأهلي الكويتي", "بنك عوده", "البنك الأهلي المتحد", "بنك فيصل الاسلامي المصري", "بنك التعمير و الاسكان", "بنك البركة", "بنك الكويت الوطني", "مصرف ابو ظبي الاسلامي", "بنك الاتحاد الوطني", "البنك العربي الافريقي الدولي", "بنك H.S.B.C", "بنك A.B.C", "البنك المصري لتنمية الصادرات", "المصرف العربي الدولي", "بنك أبو ظبي الأول", "سيتي بنك", "البنك العربي", "بنك المشرق", "البنك الأهلي اليوناني"})
        Me.ComboBox2.Location = New System.Drawing.Point(331, 181)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(185, 237)
        Me.ComboBox2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(519, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Currency"
        '
        'CurrTreeView
        '
        Me.CurrTreeView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrTreeView.BackColor = System.Drawing.Color.White
        Me.CurrTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CurrTreeView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrTreeView.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CurrTreeView.FullRowSelect = True
        Me.CurrTreeView.HideSelection = False
        Me.CurrTreeView.HotTracking = True
        Me.CurrTreeView.Location = New System.Drawing.Point(522, 103)
        Me.CurrTreeView.Name = "CurrTreeView"
        Me.CurrTreeView.Size = New System.Drawing.Size(312, 274)
        Me.CurrTreeView.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(519, 380)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Value"
        '
        'CntrctValueTextBox
        '
        Me.CntrctValueTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CntrctValueTextBox.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.CntrctValueTextBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CntrctValueTextBox.Location = New System.Drawing.Point(522, 396)
        Me.CntrctValueTextBox.Name = "CntrctValueTextBox"
        Me.CntrctValueTextBox.ReadOnly = True
        Me.CntrctValueTextBox.Size = New System.Drawing.Size(248, 24)
        Me.CntrctValueTextBox.TabIndex = 14
        '
        'lblCurr
        '
        Me.lblCurr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurr.AutoSize = True
        Me.lblCurr.Location = New System.Drawing.Point(779, 404)
        Me.lblCurr.Name = "lblCurr"
        Me.lblCurr.Size = New System.Drawing.Size(0, 13)
        Me.lblCurr.TabIndex = 15
        '
        'dgvCntrcts
        '
        Me.dgvCntrcts.AllowUserToAddRows = False
        Me.dgvCntrcts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCntrcts.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvCntrcts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCntrcts.Location = New System.Drawing.Point(0, 424)
        Me.dgvCntrcts.Name = "dgvCntrcts"
        Me.dgvCntrcts.Size = New System.Drawing.Size(841, 189)
        Me.dgvCntrcts.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(6, 410)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "All Contracts"
        '
        'Contracts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 613)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvCntrcts)
        Me.Controls.Add(Me.lblCurr)
        Me.Controls.Add(Me.CntrctValueTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CurrTreeView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProjTRV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Contracts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Financial Sources for Contracts - FSC"
        CType(Me.dgvCntrcts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProjTRV As System.Windows.Forms.TreeView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CurrTreeView As System.Windows.Forms.TreeView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CntrctValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblCurr As System.Windows.Forms.Label
    Friend WithEvents dgvCntrcts As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
