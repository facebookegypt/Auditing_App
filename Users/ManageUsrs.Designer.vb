<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUsrs
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageUsrs))
      Me.UserPass1 = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.ArchUsrLst = New System.Windows.Forms.ListBox()
      Me.UstsLst = New System.Windows.Forms.ListBox()
      Me.OKButton = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'UserPass1
      '
      Me.UserPass1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.UserPass1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UserPass1.Location = New System.Drawing.Point(107, 156)
      Me.UserPass1.Name = "UserPass1"
      Me.UserPass1.Size = New System.Drawing.Size(163, 22)
      Me.UserPass1.TabIndex = 2
      Me.UserPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(6, 163)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(59, 15)
      Me.Label2.TabIndex = 11
      Me.Label2.Text = "Password"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(6, 9)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(65, 15)
      Me.Label1.TabIndex = 9
      Me.Label1.Text = "User Name"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(6, 188)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(50, 15)
      Me.Label3.TabIndex = 13
      Me.Label3.Text = "Archive"
      '
      'ArchUsrLst
      '
      Me.ArchUsrLst.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.ArchUsrLst.FormattingEnabled = True
      Me.ArchUsrLst.ItemHeight = 15
      Me.ArchUsrLst.Location = New System.Drawing.Point(107, 188)
      Me.ArchUsrLst.Name = "ArchUsrLst"
      Me.ArchUsrLst.Size = New System.Drawing.Size(245, 79)
      Me.ArchUsrLst.TabIndex = 3
      '
      'UstsLst
      '
      Me.UstsLst.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UstsLst.FormattingEnabled = True
      Me.UstsLst.ItemHeight = 15
      Me.UstsLst.Location = New System.Drawing.Point(107, 9)
      Me.UstsLst.Name = "UstsLst"
      Me.UstsLst.Size = New System.Drawing.Size(163, 139)
      Me.UstsLst.TabIndex = 1
      '
      'OKButton
      '
      Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.OKButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod
      Me.OKButton.FlatAppearance.BorderSize = 0
      Me.OKButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.OKButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.OKButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.OKButton.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.OKButton.Image = CType(resources.GetObject("OKButton.Image"), System.Drawing.Image)
      Me.OKButton.Location = New System.Drawing.Point(12, 433)
      Me.OKButton.Name = "OKButton"
      Me.OKButton.Size = New System.Drawing.Size(119, 29)
      Me.OKButton.TabIndex = 16
      Me.OKButton.Text = "&Update User"
      Me.OKButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.OKButton.UseCompatibleTextRendering = True
      Me.OKButton.UseVisualStyleBackColor = True
      '
      'ManageUsrs
      '
      Me.AcceptButton = Me.OKButton
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(636, 474)
      Me.Controls.Add(Me.OKButton)
      Me.Controls.Add(Me.UstsLst)
      Me.Controls.Add(Me.ArchUsrLst)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.UserPass1)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "ManageUsrs"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Manage User"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents UserPass1 As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents ArchUsrLst As System.Windows.Forms.ListBox
   Friend WithEvents UstsLst As System.Windows.Forms.ListBox
   Friend WithEvents OKButton As System.Windows.Forms.Button
End Class
