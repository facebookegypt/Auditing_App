<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasicInfo
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BasicInfo))
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.TjNM = New System.Windows.Forms.ComboBox()
      Me.Trnk = New System.Windows.Forms.ComboBox()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.Tdist = New System.Windows.Forms.TextBox()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.TDep = New System.Windows.Forms.ListBox()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.Tsec = New System.Windows.Forms.ListBox()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Tdate = New System.Windows.Forms.DateTimePicker()
      Me.Tname = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.TSerial = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.OKButton = New System.Windows.Forms.Button()
      Me.But1 = New System.Windows.Forms.Button()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.GroupBox1.SuspendLayout()
      Me.SuspendLayout()
      '
      'GroupBox1
      '
      Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
      Me.GroupBox1.Controls.Add(Me.Button1)
      Me.GroupBox1.Controls.Add(Me.But1)
      Me.GroupBox1.Controls.Add(Me.TjNM)
      Me.GroupBox1.Controls.Add(Me.Trnk)
      Me.GroupBox1.Controls.Add(Me.Label8)
      Me.GroupBox1.Controls.Add(Me.Label7)
      Me.GroupBox1.Controls.Add(Me.Tdist)
      Me.GroupBox1.Controls.Add(Me.Label6)
      Me.GroupBox1.Controls.Add(Me.TDep)
      Me.GroupBox1.Controls.Add(Me.Label5)
      Me.GroupBox1.Controls.Add(Me.Tsec)
      Me.GroupBox1.Controls.Add(Me.Label4)
      Me.GroupBox1.Controls.Add(Me.Label3)
      Me.GroupBox1.Controls.Add(Me.Tdate)
      Me.GroupBox1.Controls.Add(Me.Tname)
      Me.GroupBox1.Controls.Add(Me.Label2)
      Me.GroupBox1.Controls.Add(Me.TSerial)
      Me.GroupBox1.Controls.Add(Me.Label1)
      Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
      Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
      Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
      Me.GroupBox1.Size = New System.Drawing.Size(857, 345)
      Me.GroupBox1.TabIndex = 2
      Me.GroupBox1.TabStop = False
      '
      'TjNM
      '
      Me.TjNM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.TjNM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.TjNM.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.TjNM.FormattingEnabled = True
      Me.TjNM.Items.AddRange(New Object() {"محاسب", "باحث", "مهندس", "فنى", "عامل"})
      Me.TjNM.Location = New System.Drawing.Point(138, 25)
      Me.TjNM.Name = "TjNM"
      Me.TjNM.Size = New System.Drawing.Size(203, 23)
      Me.TjNM.TabIndex = 29
      '
      'Trnk
      '
      Me.Trnk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.Trnk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Trnk.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Trnk.FormattingEnabled = True
      Me.Trnk.Items.AddRange(New Object() {"كبير", "ثالث", "ثان", "اول", "مدير عام", "رئيس قطاع", "رئيس قطاعات"})
      Me.Trnk.Location = New System.Drawing.Point(138, 56)
      Me.Trnk.Name = "Trnk"
      Me.Trnk.Size = New System.Drawing.Size(203, 23)
      Me.Trnk.TabIndex = 28
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(379, 61)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(41, 17)
      Me.Label8.TabIndex = 27
      Me.Label8.Text = "الدرجه"
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(347, 25)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(73, 17)
      Me.Label7.TabIndex = 25
      Me.Label7.Text = "مسمى وظيفى"
      '
      'Tdist
      '
      Me.Tdist.BackColor = System.Drawing.Color.White
      Me.Tdist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Tdist.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Tdist.Location = New System.Drawing.Point(567, 312)
      Me.Tdist.Name = "Tdist"
      Me.Tdist.Size = New System.Drawing.Size(200, 25)
      Me.Tdist.TabIndex = 23
      Me.Tdist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(775, 314)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(70, 17)
      Me.Label6.TabIndex = 22
      Me.Label6.Text = "جهة الصرف"
      '
      'TDep
      '
      Me.TDep.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
      Me.TDep.ForeColor = System.Drawing.Color.DodgerBlue
      Me.TDep.FormattingEnabled = True
      Me.TDep.IntegralHeight = False
      Me.TDep.ItemHeight = 17
      Me.TDep.Location = New System.Drawing.Point(491, 219)
      Me.TDep.Name = "TDep"
      Me.TDep.RightToLeft = System.Windows.Forms.RightToLeft.Yes
      Me.TDep.ScrollAlwaysVisible = True
      Me.TDep.Size = New System.Drawing.Size(276, 81)
      Me.TDep.TabIndex = 21
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(806, 219)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(39, 17)
      Me.Label5.TabIndex = 20
      Me.Label5.Text = "الادارة"
      '
      'Tsec
      '
      Me.Tsec.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
      Me.Tsec.ForeColor = System.Drawing.Color.DodgerBlue
      Me.Tsec.FormattingEnabled = True
      Me.Tsec.IntegralHeight = False
      Me.Tsec.ItemHeight = 17
      Me.Tsec.Location = New System.Drawing.Point(491, 125)
      Me.Tsec.Name = "Tsec"
      Me.Tsec.RightToLeft = System.Windows.Forms.RightToLeft.Yes
      Me.Tsec.ScrollAlwaysVisible = True
      Me.Tsec.Size = New System.Drawing.Size(276, 81)
      Me.Tsec.TabIndex = 19
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(804, 125)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(41, 17)
      Me.Label4.TabIndex = 11
      Me.Label4.Text = "القطاع"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(812, 90)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(33, 17)
      Me.Label3.TabIndex = 9
      Me.Label3.Text = "الاسم"
      '
      'Tdate
      '
      Me.Tdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Tdate.Location = New System.Drawing.Point(567, 57)
      Me.Tdate.Name = "Tdate"
      Me.Tdate.Size = New System.Drawing.Size(200, 22)
      Me.Tdate.TabIndex = 8
      '
      'Tname
      '
      Me.Tname.BackColor = System.Drawing.Color.White
      Me.Tname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Tname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Tname.Location = New System.Drawing.Point(567, 88)
      Me.Tname.Name = "Tname"
      Me.Tname.Size = New System.Drawing.Size(200, 25)
      Me.Tname.TabIndex = 3
      Me.Tname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(775, 61)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(71, 17)
      Me.Label2.TabIndex = 7
      Me.Label2.Text = "تاريخ التعيين"
      '
      'TSerial
      '
      Me.TSerial.BackColor = System.Drawing.Color.White
      Me.TSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.TSerial.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.TSerial.Location = New System.Drawing.Point(567, 23)
      Me.TSerial.Name = "TSerial"
      Me.TSerial.Size = New System.Drawing.Size(200, 25)
      Me.TSerial.TabIndex = 1
      Me.TSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(787, 25)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(58, 17)
      Me.Label1.TabIndex = 3
      Me.Label1.Text = "رقم العامل"
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
      Me.OKButton.Location = New System.Drawing.Point(723, 351)
      Me.OKButton.Name = "OKButton"
      Me.OKButton.Size = New System.Drawing.Size(119, 32)
      Me.OKButton.TabIndex = 7
      Me.OKButton.Text = "حفظ"
      Me.OKButton.UseVisualStyleBackColor = True
      '
      'But1
      '
      Me.But1.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.But1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.But1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.But1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.But1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.But1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.But1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But1.Image = Global.Auditing.My.Resources.Resources.toolpro
        Me.But1.Location = New System.Drawing.Point(99, 54)
        Me.But1.Name = "But1"
        Me.But1.Size = New System.Drawing.Size(33, 24)
        Me.But1.TabIndex = 30
        Me.But1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.But1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Auditing.My.Resources.Resources.toolpro
      Me.Button1.Location = New System.Drawing.Point(99, 22)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(33, 24)
      Me.Button1.TabIndex = 31
      Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
      Me.Button1.UseVisualStyleBackColor = True
      '
      'BasicInfo
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(857, 479)
      Me.Controls.Add(Me.OKButton)
      Me.Controls.Add(Me.GroupBox1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "BasicInfo"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "بيانات موظفين"
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents Tname As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents TSerial As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Tdate As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents OKButton As System.Windows.Forms.Button
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Tsec As System.Windows.Forms.ListBox
   Friend WithEvents TDep As System.Windows.Forms.ListBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Tdist As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents TjNM As System.Windows.Forms.ComboBox
   Friend WithEvents Trnk As System.Windows.Forms.ComboBox
   Friend WithEvents Button1 As System.Windows.Forms.Button
   Friend WithEvents But1 As System.Windows.Forms.Button
End Class
