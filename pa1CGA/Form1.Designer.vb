<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tbX1 = New System.Windows.Forms.TextBox()
        Me.tbY1 = New System.Windows.Forms.TextBox()
        Me.tbX2 = New System.Windows.Forms.TextBox()
        Me.tbY2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.drawingBox = New System.Windows.Forms.PictureBox()
        Me.btnDotted = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnLine = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.colorDialog = New System.Windows.Forms.ColorDialog()
        Me.toolTipDot = New System.Windows.Forms.ToolTip(Me.components)
        Me.toolTipDotted = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelOnButton = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.drawingBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbX1
        '
        Me.tbX1.Location = New System.Drawing.Point(69, 24)
        Me.tbX1.Name = "tbX1"
        Me.tbX1.Size = New System.Drawing.Size(100, 29)
        Me.tbX1.TabIndex = 0
        '
        'tbY1
        '
        Me.tbY1.Location = New System.Drawing.Point(69, 62)
        Me.tbY1.Name = "tbY1"
        Me.tbY1.Size = New System.Drawing.Size(100, 29)
        Me.tbY1.TabIndex = 1
        '
        'tbX2
        '
        Me.tbX2.Location = New System.Drawing.Point(80, 24)
        Me.tbX2.Name = "tbX2"
        Me.tbX2.Size = New System.Drawing.Size(100, 29)
        Me.tbX2.TabIndex = 2
        '
        'tbY2
        '
        Me.tbY2.Location = New System.Drawing.Point(80, 62)
        Me.tbY2.Name = "tbY2"
        Me.tbY2.Size = New System.Drawing.Size(100, 29)
        Me.tbY2.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbX1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbY1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(38, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 113)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Start Point"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Y1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "X1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbX2)
        Me.GroupBox2.Controls.Add(Me.tbY2)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(274, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 113)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "End Point"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Y2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "X2"
        '
        'drawingBox
        '
        Me.drawingBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.drawingBox.Location = New System.Drawing.Point(25, 24)
        Me.drawingBox.Name = "drawingBox"
        Me.drawingBox.Size = New System.Drawing.Size(250, 250)
        Me.drawingBox.TabIndex = 6
        Me.drawingBox.TabStop = False
        '
        'btnDotted
        '
        Me.btnDotted.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnDotted.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDotted.FlatAppearance.BorderSize = 0
        Me.btnDotted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDotted.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDotted.Location = New System.Drawing.Point(0, 125)
        Me.btnDotted.Name = "btnDotted"
        Me.btnDotted.Size = New System.Drawing.Size(174, 44)
        Me.btnDotted.TabIndex = 4
        Me.btnDotted.Text = "Dotted Line"
        Me.toolTipDotted.SetToolTip(Me.btnDotted, "horizontal, vertical, adn oblique line 45 degree")
        Me.btnDotted.UseVisualStyleBackColor = False
        '
        'btnColor
        '
        Me.btnColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnColor.FlatAppearance.BorderSize = 0
        Me.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColor.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnColor.Location = New System.Drawing.Point(0, 183)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(174, 45)
        Me.btnColor.TabIndex = 3
        Me.btnColor.Text = "Change Color"
        Me.btnColor.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(0, 246)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(174, 43)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnLine
        '
        Me.btnLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnLine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLine.FlatAppearance.BorderSize = 0
        Me.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLine.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLine.Location = New System.Drawing.Point(0, 66)
        Me.btnLine.Name = "btnLine"
        Me.btnLine.Size = New System.Drawing.Size(174, 45)
        Me.btnLine.TabIndex = 1
        Me.btnLine.Text = "Draw a Line"
        Me.btnLine.UseVisualStyleBackColor = False
        '
        'btnDot
        '
        Me.btnDot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnDot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDot.FlatAppearance.BorderSize = 0
        Me.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDot.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDot.Location = New System.Drawing.Point(0, 11)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(174, 43)
        Me.btnDot.TabIndex = 0
        Me.btnDot.Text = "Draw a Dot"
        Me.toolTipDot.SetToolTip(Me.btnDot, "input data on x1 and y1")
        Me.btnDot.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.drawingBox)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(22, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(306, 289)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Result"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 131)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Panel2.Controls.Add(Me.panelOnButton)
        Me.Panel2.Controls.Add(Me.btnDotted)
        Me.Panel2.Controls.Add(Me.btnColor)
        Me.Panel2.Controls.Add(Me.btnLine)
        Me.Panel2.Controls.Add(Me.btnDot)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(352, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(174, 316)
        Me.Panel2.TabIndex = 10
        '
        'panelOnButton
        '
        Me.panelOnButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.panelOnButton.Location = New System.Drawing.Point(161, 11)
        Me.panelOnButton.Name = "panelOnButton"
        Me.panelOnButton.Size = New System.Drawing.Size(13, 43)
        Me.panelOnButton.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 131)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(352, 316)
        Me.Panel3.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 447)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Let's Draw a Line with Me! ^__^"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.drawingBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbX1 As TextBox
    Friend WithEvents tbY1 As TextBox
    Friend WithEvents tbX2 As TextBox
    Friend WithEvents tbY2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents drawingBox As PictureBox
    Friend WithEvents btnLine As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnColor As Button
    Friend WithEvents colorDialog As ColorDialog
    Friend WithEvents toolTipDot As ToolTip
    Friend WithEvents btnDotted As Button
    Friend WithEvents toolTipDotted As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents panelOnButton As Panel
End Class
