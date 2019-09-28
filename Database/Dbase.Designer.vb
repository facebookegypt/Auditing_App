<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dbase
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dbase))
      Me.TxtDBLoc = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.DBbrowse = New System.Windows.Forms.Button()
      Me.ConnectBtn = New System.Windows.Forms.Button()
      Me.DCBtn = New System.Windows.Forms.Button()
      Me.Lblstat = New System.Windows.Forms.Label()
      Me.SaveSetBtn = New System.Windows.Forms.Button()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'TxtDBLoc
      '
      Me.TxtDBLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.TxtDBLoc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.TxtDBLoc.Location = New System.Drawing.Point(15, 29)
      Me.TxtDBLoc.Name = "TxtDBLoc"
      Me.TxtDBLoc.ReadOnly = True
      Me.TxtDBLoc.Size = New System.Drawing.Size(713, 22)
      Me.TxtDBLoc.TabIndex = 7
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(12, 9)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(65, 17)
      Me.Label1.TabIndex = 8
      Me.Label1.Text = "Location"
      '
      'DBbrowse
      '
      Me.DBbrowse.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.DBbrowse.Location = New System.Drawing.Point(734, 29)
      Me.DBbrowse.Name = "DBbrowse"
      Me.DBbrowse.Size = New System.Drawing.Size(34, 22)
      Me.DBbrowse.TabIndex = 10
      Me.DBbrowse.Text = "..."
      Me.DBbrowse.UseVisualStyleBackColor = True
      '
      'ConnectBtn
      '
      Me.ConnectBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.ConnectBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.ConnectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.ConnectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.ConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ConnectBtn.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.ConnectBtn.Location = New System.Drawing.Point(15, 75)
      Me.ConnectBtn.Name = "ConnectBtn"
      Me.ConnectBtn.Size = New System.Drawing.Size(120, 32)
      Me.ConnectBtn.TabIndex = 11
      Me.ConnectBtn.Text = "Connect"
      Me.ConnectBtn.UseVisualStyleBackColor = True
      '
      'DCBtn
      '
      Me.DCBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.DCBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.DCBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.DCBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.DCBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.DCBtn.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.DCBtn.Location = New System.Drawing.Point(15, 113)
      Me.DCBtn.Name = "DCBtn"
      Me.DCBtn.Size = New System.Drawing.Size(120, 32)
      Me.DCBtn.TabIndex = 12
      Me.DCBtn.Text = "Disconnect"
      Me.DCBtn.UseVisualStyleBackColor = True
      '
      'Lblstat
      '
      Me.Lblstat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Lblstat.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Lblstat.Location = New System.Drawing.Point(302, 75)
      Me.Lblstat.Name = "Lblstat"
      Me.Lblstat.Size = New System.Drawing.Size(426, 41)
      Me.Lblstat.TabIndex = 13
      '
      'SaveSetBtn
      '
      Me.SaveSetBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.SaveSetBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.SaveSetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.SaveSetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.SaveSetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.SaveSetBtn.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.SaveSetBtn.Location = New System.Drawing.Point(15, 151)
      Me.SaveSetBtn.Name = "SaveSetBtn"
      Me.SaveSetBtn.Size = New System.Drawing.Size(120, 32)
      Me.SaveSetBtn.TabIndex = 14
      Me.SaveSetBtn.Text = "Save Setting"
      Me.SaveSetBtn.UseVisualStyleBackColor = True
      '
      'Button1
      '
      Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Button1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button1.Location = New System.Drawing.Point(15, 189)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(120, 32)
      Me.Button1.TabIndex = 15
      Me.Button1.Text = "Go Further"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'Dbase
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(780, 408)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.SaveSetBtn)
      Me.Controls.Add(Me.Lblstat)
      Me.Controls.Add(Me.DCBtn)
      Me.Controls.Add(Me.ConnectBtn)
      Me.Controls.Add(Me.DBbrowse)
      Me.Controls.Add(Me.TxtDBLoc)
      Me.Controls.Add(Me.Label1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "Dbase"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Manage Database"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents TxtDBLoc As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents DBbrowse As System.Windows.Forms.Button
   Friend WithEvents ConnectBtn As System.Windows.Forms.Button
   Friend WithEvents DCBtn As System.Windows.Forms.Button
   Friend WithEvents Lblstat As System.Windows.Forms.Label
   Friend WithEvents SaveSetBtn As System.Windows.Forms.Button
   Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
