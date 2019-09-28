<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.OKbtn = New System.Windows.Forms.Button()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
      Me.Label1.Location = New System.Drawing.Point(216, 221)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(169, 17)
      Me.Label1.TabIndex = 1
      Me.Label1.Text = "Ahmed Samir Barghouth"
      '
      'Label2
      '
      Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
      Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
      Me.Label2.Location = New System.Drawing.Point(210, 0)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(219, 133)
      Me.Label2.TabIndex = 2
      Me.Label2.Text = "Financial Section"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
      Me.Label3.Location = New System.Drawing.Point(232, 250)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(153, 17)
      Me.Label3.TabIndex = 3
      Me.Label3.Text = "Auditing Despartment"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
      Me.Label4.Location = New System.Drawing.Point(259, 279)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(141, 17)
      Me.Label4.TabIndex = 4
      Me.Label4.Text = "Auditing Application"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.BackColor = System.Drawing.Color.DimGray
      Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.ForeColor = System.Drawing.Color.GhostWhite
      Me.Label5.Location = New System.Drawing.Point(3, 337)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(189, 15)
      Me.Label5.TabIndex = 5
      Me.Label5.Text = "CopyRight (C) Evry1falls @ 2013"
      '
      'OKbtn
      '
      Me.OKbtn.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.OKbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
      Me.OKbtn.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.OKbtn.Location = New System.Drawing.Point(210, 332)
      Me.OKbtn.Name = "OKbtn"
      Me.OKbtn.Size = New System.Drawing.Size(219, 23)
      Me.OKbtn.TabIndex = 1
      Me.OKbtn.Text = "&OK"
      Me.OKbtn.UseVisualStyleBackColor = True
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.ForeColor = System.Drawing.Color.Blue
      Me.Label6.Location = New System.Drawing.Point(231, 133)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(176, 22)
      Me.Label6.TabIndex = 6
      Me.Label6.Text = "Auditing Application"
      '
      'PictureBox1
      '
      Me.PictureBox1.BackColor = System.Drawing.Color.DimGray
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
      Me.PictureBox1.Image = Global.Auditing.My.Resources.Resources.Logo_Aboutform
      Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(210, 355)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
      Me.PictureBox1.TabIndex = 0
      Me.PictureBox1.TabStop = False
      '
      'About
      '
      Me.AcceptButton = Me.OKbtn
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.Silver
      Me.ClientSize = New System.Drawing.Size(429, 355)
      Me.Controls.Add(Me.Label6)
      Me.Controls.Add(Me.OKbtn)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.PictureBox1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "About"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "About"
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents OKbtn As System.Windows.Forms.Button
   Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
