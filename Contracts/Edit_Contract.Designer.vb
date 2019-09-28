<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Contract
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
      Me.Txt1 = New System.Windows.Forms.TextBox()
      Me.RegisterButton = New System.Windows.Forms.Button()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.SqlFileNm = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'Txt1
      '
      Me.Txt1.BackColor = System.Drawing.Color.White
      Me.Txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Txt1.Dock = System.Windows.Forms.DockStyle.Top
      Me.Txt1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Txt1.Location = New System.Drawing.Point(0, 0)
      Me.Txt1.Multiline = True
      Me.Txt1.Name = "Txt1"
      Me.Txt1.Size = New System.Drawing.Size(771, 143)
      Me.Txt1.TabIndex = 32
      Me.Txt1.Text = "--------"
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
      Me.RegisterButton.Location = New System.Drawing.Point(12, 149)
      Me.RegisterButton.Name = "RegisterButton"
      Me.RegisterButton.Size = New System.Drawing.Size(120, 32)
      Me.RegisterButton.TabIndex = 33
      Me.RegisterButton.Text = "Update"
      Me.RegisterButton.UseVisualStyleBackColor = True
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
      Me.Button1.Location = New System.Drawing.Point(12, 401)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(120, 32)
      Me.Button1.TabIndex = 34
      Me.Button1.Text = "Save New"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'SqlFileNm
      '
      Me.SqlFileNm.BackColor = System.Drawing.Color.White
      Me.SqlFileNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.SqlFileNm.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.SqlFileNm.Location = New System.Drawing.Point(151, 407)
      Me.SqlFileNm.Name = "SqlFileNm"
      Me.SqlFileNm.Size = New System.Drawing.Size(192, 25)
      Me.SqlFileNm.TabIndex = 35
      Me.SqlFileNm.Text = "New_File.Sql"
      '
      'Edit_Contract
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(771, 469)
      Me.Controls.Add(Me.SqlFileNm)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.RegisterButton)
      Me.Controls.Add(Me.Txt1)
      Me.Name = "Edit_Contract"
      Me.Text = "Edit_Contract"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents Txt1 As System.Windows.Forms.TextBox
   Friend WithEvents RegisterButton As System.Windows.Forms.Button
   Friend WithEvents Button1 As System.Windows.Forms.Button
   Friend WithEvents SqlFileNm As System.Windows.Forms.TextBox
End Class
