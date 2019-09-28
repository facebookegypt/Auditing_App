<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageSections
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageSections))
      Me.SPC = New System.Windows.Forms.SplitContainer()
      Me.Button3 = New System.Windows.Forms.Button()
      Me.Button2 = New System.Windows.Forms.Button()
      Me.LstSec = New System.Windows.Forms.ListBox()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.OKButton = New System.Windows.Forms.Button()
      Me.TxtSecNm = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Button4 = New System.Windows.Forms.Button()
      Me.TxtDep = New System.Windows.Forms.TextBox()
      Me.ListBox1 = New System.Windows.Forms.ListBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.LstDep = New System.Windows.Forms.ListBox()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.Button5 = New System.Windows.Forms.Button()
      Me.Button6 = New System.Windows.Forms.Button()
      Me.Button7 = New System.Windows.Forms.Button()
      CType(Me.SPC, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SPC.Panel1.SuspendLayout()
      Me.SPC.Panel2.SuspendLayout()
      Me.SPC.SuspendLayout()
      Me.SuspendLayout()
      '
      'SPC
      '
      Me.SPC.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SPC.Location = New System.Drawing.Point(0, 0)
      Me.SPC.Name = "SPC"
      '
      'SPC.Panel1
      '
      Me.SPC.Panel1.Controls.Add(Me.Button7)
      Me.SPC.Panel1.Controls.Add(Me.Button5)
      Me.SPC.Panel1.Controls.Add(Me.Button6)
      Me.SPC.Panel1.Controls.Add(Me.Label4)
      Me.SPC.Panel1.Controls.Add(Me.LstDep)
      Me.SPC.Panel1.Controls.Add(Me.Label3)
      Me.SPC.Panel1.Controls.Add(Me.ListBox1)
      Me.SPC.Panel1.Controls.Add(Me.Button4)
      Me.SPC.Panel1.Controls.Add(Me.TxtDep)
      Me.SPC.Panel1.Controls.Add(Me.Label2)
      '
      'SPC.Panel2
      '
      Me.SPC.Panel2.Controls.Add(Me.Button3)
      Me.SPC.Panel2.Controls.Add(Me.Button2)
      Me.SPC.Panel2.Controls.Add(Me.LstSec)
      Me.SPC.Panel2.Controls.Add(Me.Button1)
      Me.SPC.Panel2.Controls.Add(Me.OKButton)
      Me.SPC.Panel2.Controls.Add(Me.TxtSecNm)
      Me.SPC.Panel2.Controls.Add(Me.Label1)
      Me.SPC.Size = New System.Drawing.Size(740, 518)
      Me.SPC.SplitterDistance = 355
      Me.SPC.TabIndex = 7
      '
      'Button3
      '
      Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Button3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button3.Location = New System.Drawing.Point(211, 470)
      Me.Button3.Name = "Button3"
      Me.Button3.Size = New System.Drawing.Size(119, 32)
      Me.Button3.TabIndex = 21
      Me.Button3.Text = "Edit"
      Me.Button3.UseVisualStyleBackColor = True
      '
      'Button2
      '
      Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Button2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button2.Location = New System.Drawing.Point(16, 470)
      Me.Button2.Name = "Button2"
      Me.Button2.Size = New System.Drawing.Size(119, 32)
      Me.Button2.TabIndex = 20
      Me.Button2.Text = "Delete"
      Me.Button2.UseVisualStyleBackColor = True
      '
      'LstSec
      '
      Me.LstSec.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.LstSec.ForeColor = System.Drawing.Color.RoyalBlue
      Me.LstSec.FormattingEnabled = True
      Me.LstSec.ItemHeight = 17
      Me.LstSec.Location = New System.Drawing.Point(16, 278)
      Me.LstSec.Name = "LstSec"
      Me.LstSec.RightToLeft = System.Windows.Forms.RightToLeft.Yes
      Me.LstSec.Size = New System.Drawing.Size(314, 174)
      Me.LstSec.TabIndex = 19
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
      Me.Button1.Location = New System.Drawing.Point(16, 60)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(119, 32)
      Me.Button1.TabIndex = 18
      Me.Button1.Text = "New"
      Me.Button1.UseVisualStyleBackColor = True
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
      Me.OKButton.Location = New System.Drawing.Point(211, 60)
      Me.OKButton.Name = "OKButton"
      Me.OKButton.Size = New System.Drawing.Size(119, 32)
      Me.OKButton.TabIndex = 17
      Me.OKButton.Text = "OK"
      Me.OKButton.UseVisualStyleBackColor = True
      '
      'TxtSecNm
      '
      Me.TxtSecNm.BackColor = System.Drawing.Color.White
      Me.TxtSecNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.TxtSecNm.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.TxtSecNm.ForeColor = System.Drawing.Color.Teal
      Me.TxtSecNm.Location = New System.Drawing.Point(16, 29)
      Me.TxtSecNm.Name = "TxtSecNm"
      Me.TxtSecNm.Size = New System.Drawing.Size(314, 25)
      Me.TxtSecNm.TabIndex = 6
      Me.TxtSecNm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(328, 9)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(41, 17)
      Me.Label1.TabIndex = 5
      Me.Label1.Text = "القطاع"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(287, 9)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(39, 17)
      Me.Label2.TabIndex = 21
      Me.Label2.Text = "الادارة"
      '
      'Button4
      '
      Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.Button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Button4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button4.Location = New System.Drawing.Point(207, 60)
      Me.Button4.Name = "Button4"
      Me.Button4.Size = New System.Drawing.Size(119, 32)
      Me.Button4.TabIndex = 24
      Me.Button4.Text = "OK"
      Me.Button4.UseVisualStyleBackColor = True
      '
      'TxtDep
      '
      Me.TxtDep.BackColor = System.Drawing.Color.White
      Me.TxtDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.TxtDep.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.TxtDep.ForeColor = System.Drawing.Color.Teal
      Me.TxtDep.Location = New System.Drawing.Point(12, 29)
      Me.TxtDep.Name = "TxtDep"
      Me.TxtDep.Size = New System.Drawing.Size(314, 25)
      Me.TxtDep.TabIndex = 23
      Me.TxtDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'ListBox1
      '
      Me.ListBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.ListBox1.ForeColor = System.Drawing.Color.RoyalBlue
      Me.ListBox1.FormattingEnabled = True
      Me.ListBox1.ItemHeight = 17
      Me.ListBox1.Location = New System.Drawing.Point(12, 137)
      Me.ListBox1.Name = "ListBox1"
      Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
      Me.ListBox1.Size = New System.Drawing.Size(314, 89)
      Me.ListBox1.TabIndex = 25
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(285, 117)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(41, 17)
      Me.Label3.TabIndex = 26
      Me.Label3.Text = "القطاع"
      '
      'LstDep
      '
      Me.LstDep.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.LstDep.ForeColor = System.Drawing.Color.RoyalBlue
      Me.LstDep.FormattingEnabled = True
      Me.LstDep.ItemHeight = 17
      Me.LstDep.Location = New System.Drawing.Point(12, 278)
      Me.LstDep.Name = "LstDep"
      Me.LstDep.RightToLeft = System.Windows.Forms.RightToLeft.Yes
      Me.LstDep.Size = New System.Drawing.Size(314, 174)
      Me.LstDep.TabIndex = 27
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(278, 258)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(48, 17)
      Me.Label4.TabIndex = 28
      Me.Label4.Text = "الادارات"
      '
      'Button5
      '
      Me.Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Button5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button5.Location = New System.Drawing.Point(207, 470)
      Me.Button5.Name = "Button5"
      Me.Button5.Size = New System.Drawing.Size(119, 32)
      Me.Button5.TabIndex = 30
      Me.Button5.Text = "Edit"
      Me.Button5.UseVisualStyleBackColor = True
      '
      'Button6
      '
      Me.Button6.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.Button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Button6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button6.Location = New System.Drawing.Point(12, 470)
      Me.Button6.Name = "Button6"
      Me.Button6.Size = New System.Drawing.Size(119, 32)
      Me.Button6.TabIndex = 29
      Me.Button6.Text = "Delete"
      Me.Button6.UseVisualStyleBackColor = True
      '
      'Button7
      '
      Me.Button7.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.Button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Button7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button7.Location = New System.Drawing.Point(12, 60)
      Me.Button7.Name = "Button7"
      Me.Button7.Size = New System.Drawing.Size(119, 32)
      Me.Button7.TabIndex = 31
      Me.Button7.Text = "New"
      Me.Button7.UseVisualStyleBackColor = True
      '
      'ManageSections
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(740, 518)
      Me.Controls.Add(Me.SPC)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.Name = "ManageSections"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "القطاعات"
      Me.SPC.Panel1.ResumeLayout(False)
      Me.SPC.Panel1.PerformLayout()
      Me.SPC.Panel2.ResumeLayout(False)
      Me.SPC.Panel2.PerformLayout()
      CType(Me.SPC, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SPC.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents SPC As System.Windows.Forms.SplitContainer
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents TxtSecNm As System.Windows.Forms.TextBox
   Friend WithEvents OKButton As System.Windows.Forms.Button
   Friend WithEvents Button1 As System.Windows.Forms.Button
   Friend WithEvents Button3 As System.Windows.Forms.Button
   Friend WithEvents Button2 As System.Windows.Forms.Button
   Friend WithEvents LstSec As System.Windows.Forms.ListBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Button4 As System.Windows.Forms.Button
   Friend WithEvents TxtDep As System.Windows.Forms.TextBox
   Friend WithEvents Button5 As System.Windows.Forms.Button
   Friend WithEvents Button6 As System.Windows.Forms.Button
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents LstDep As System.Windows.Forms.ListBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
   Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
