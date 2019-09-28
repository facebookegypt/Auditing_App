<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DB_Struct
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DB_Struct))
      Me.TxtDBLoc = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.ConnectBtn = New System.Windows.Forms.Button()
      Me.Lblstat = New System.Windows.Forms.Label()
      Me.SQLString = New System.Windows.Forms.TextBox()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.TV1 = New System.Windows.Forms.TreeView()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.TblMnuStrp = New System.Windows.Forms.ContextMenuStrip(Me.components)
      Me.DROPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
      Me.TxtRslt = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.TblMnuStrp.SuspendLayout()
      Me.SuspendLayout()
      '
      'TxtDBLoc
      '
      Me.TxtDBLoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TxtDBLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.TxtDBLoc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.TxtDBLoc.Location = New System.Drawing.Point(3, 20)
      Me.TxtDBLoc.Name = "TxtDBLoc"
      Me.TxtDBLoc.ReadOnly = True
      Me.TxtDBLoc.Size = New System.Drawing.Size(782, 22)
      Me.TxtDBLoc.TabIndex = 2
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(0, 0)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(65, 17)
      Me.Label1.TabIndex = 1
      Me.Label1.Text = "Location"
      '
      'ConnectBtn
      '
      Me.ConnectBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.ConnectBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.ConnectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.ConnectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.ConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ConnectBtn.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.ConnectBtn.Location = New System.Drawing.Point(3, 48)
      Me.ConnectBtn.Name = "ConnectBtn"
      Me.ConnectBtn.Size = New System.Drawing.Size(120, 41)
      Me.ConnectBtn.TabIndex = 12
      Me.ConnectBtn.Text = "Connect"
      Me.ConnectBtn.UseVisualStyleBackColor = True
      '
      'Lblstat
      '
      Me.Lblstat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Lblstat.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Lblstat.Location = New System.Drawing.Point(129, 48)
      Me.Lblstat.Name = "Lblstat"
      Me.Lblstat.Size = New System.Drawing.Size(426, 32)
      Me.Lblstat.TabIndex = 14
      '
      'SQLString
      '
      Me.SQLString.AcceptsReturn = True
      Me.SQLString.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.SQLString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.SQLString.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.SQLString.Location = New System.Drawing.Point(240, 126)
      Me.SQLString.Multiline = True
      Me.SQLString.Name = "SQLString"
      Me.SQLString.Size = New System.Drawing.Size(545, 363)
      Me.SQLString.TabIndex = 19
      '
      'Label4
      '
      Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label4.AutoSize = True
      Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(237, 106)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(38, 17)
      Me.Label4.TabIndex = 20
      Me.Label4.Text = "SQL"
      '
      'Button1
      '
      Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
      Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Button1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button1.Location = New System.Drawing.Point(452, 82)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(120, 41)
      Me.Button1.TabIndex = 26
      Me.Button1.Text = "RUN SQL"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'TV1
      '
      Me.TV1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.TV1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.TV1.ForeColor = System.Drawing.Color.Black
      Me.TV1.LineColor = System.Drawing.Color.ForestGreen
      Me.TV1.Location = New System.Drawing.Point(3, 126)
      Me.TV1.Name = "TV1"
      Me.TV1.ShowNodeToolTips = True
      Me.TV1.Size = New System.Drawing.Size(231, 363)
      Me.TV1.TabIndex = 28
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(0, 106)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(109, 17)
      Me.Label2.TabIndex = 27
      Me.Label2.Text = "Basic Structure"
      '
      'TblMnuStrp
      '
      Me.TblMnuStrp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DROPToolStripMenuItem})
      Me.TblMnuStrp.Name = "TblMnuStrp"
      Me.TblMnuStrp.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
      Me.TblMnuStrp.Size = New System.Drawing.Size(108, 26)
      '
      'DROPToolStripMenuItem
      '
      Me.DROPToolStripMenuItem.Name = "DROPToolStripMenuItem"
      Me.DROPToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
      Me.DROPToolStripMenuItem.Text = "Delete"
      '
      'TxtRslt
      '
      Me.TxtRslt.AcceptsReturn = True
      Me.TxtRslt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TxtRslt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.TxtRslt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.TxtRslt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
      Me.TxtRslt.Location = New System.Drawing.Point(791, 126)
      Me.TxtRslt.Multiline = True
      Me.TxtRslt.Name = "TxtRslt"
      Me.TxtRslt.ScrollBars = System.Windows.Forms.ScrollBars.Both
      Me.TxtRslt.Size = New System.Drawing.Size(272, 363)
      Me.TxtRslt.TabIndex = 29
      '
      'Label3
      '
      Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label3.AutoSize = True
      Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(791, 106)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(51, 17)
      Me.Label3.TabIndex = 30
      Me.Label3.Text = "Result"
      '
      'DB_Struct
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1075, 493)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.TxtRslt)
      Me.Controls.Add(Me.TV1)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.SQLString)
      Me.Controls.Add(Me.Lblstat)
      Me.Controls.Add(Me.ConnectBtn)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.TxtDBLoc)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "DB_Struct"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Database Structure"
      Me.TblMnuStrp.ResumeLayout(False)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents TxtDBLoc As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents ConnectBtn As System.Windows.Forms.Button
   Friend WithEvents Lblstat As System.Windows.Forms.Label
   Friend WithEvents SQLString As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Button1 As System.Windows.Forms.Button
   Friend WithEvents TV1 As System.Windows.Forms.TreeView
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents TblMnuStrp As System.Windows.Forms.ContextMenuStrip
   Friend WithEvents DROPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents TxtRslt As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
