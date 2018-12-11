<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab3
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.lblFWhite = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBSky = New System.Windows.Forms.Label()
        Me.lblBWhite = New System.Windows.Forms.Label()
        Me.lblBBlack = New System.Windows.Forms.Label()
        Me.lblBRed = New System.Windows.Forms.Label()
        Me.lblBBrown = New System.Windows.Forms.Label()
        Me.lblBOrange = New System.Windows.Forms.Label()
        Me.lblBViolet = New System.Windows.Forms.Label()
        Me.lblBBlue = New System.Windows.Forms.Label()
        Me.lblBYellow = New System.Windows.Forms.Label()
        Me.lblBGreen = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(311, 74)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(246, 48)
        Me.txtInput.TabIndex = 0
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.Yellow
        Me.btnUp.Location = New System.Drawing.Point(564, 74)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(75, 23)
        Me.btnUp.TabIndex = 1
        Me.btnUp.Text = "+"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDown.Location = New System.Drawing.Point(564, 104)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(75, 23)
        Me.btnDown.TabIndex = 2
        Me.btnDown.Text = "-"
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(353, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ขนาดฟอนต์"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFSky)
        Me.GroupBox1.Controls.Add(Me.lblFBlack)
        Me.GroupBox1.Controls.Add(Me.lblFWhite)
        Me.GroupBox1.Controls.Add(Me.lblFViolet)
        Me.GroupBox1.Controls.Add(Me.lblFBrown)
        Me.GroupBox1.Controls.Add(Me.lblFGreen)
        Me.GroupBox1.Controls.Add(Me.lblFYellow)
        Me.GroupBox1.Controls.Add(Me.lblFBlue)
        Me.GroupBox1.Controls.Add(Me.lblFOrange)
        Me.GroupBox1.Controls.Add(Me.lblFRed)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 205)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 144)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ForeColor"
        '
        'lblFSky
        '
        Me.lblFSky.BackColor = System.Drawing.Color.Aqua
        Me.lblFSky.Location = New System.Drawing.Point(289, 88)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(39, 23)
        Me.lblFSky.TabIndex = 1
        '
        'lblFBlack
        '
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.Location = New System.Drawing.Point(289, 38)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(39, 23)
        Me.lblFBlack.TabIndex = 0
        '
        'lblFWhite
        '
        Me.lblFWhite.BackColor = System.Drawing.Color.White
        Me.lblFWhite.Location = New System.Drawing.Point(219, 88)
        Me.lblFWhite.Name = "lblFWhite"
        Me.lblFWhite.Size = New System.Drawing.Size(39, 23)
        Me.lblFWhite.TabIndex = 1
        '
        'lblFViolet
        '
        Me.lblFViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblFViolet.Location = New System.Drawing.Point(216, 38)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(42, 23)
        Me.lblFViolet.TabIndex = 0
        '
        'lblFBrown
        '
        Me.lblFBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFBrown.Location = New System.Drawing.Point(145, 88)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(39, 23)
        Me.lblFBrown.TabIndex = 1
        '
        'lblFGreen
        '
        Me.lblFGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFGreen.Location = New System.Drawing.Point(145, 38)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(39, 23)
        Me.lblFGreen.TabIndex = 0
        '
        'lblFYellow
        '
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.Location = New System.Drawing.Point(81, 88)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(39, 23)
        Me.lblFYellow.TabIndex = 1
        '
        'lblFBlue
        '
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.Location = New System.Drawing.Point(78, 38)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(42, 23)
        Me.lblFBlue.TabIndex = 0
        '
        'lblFOrange
        '
        Me.lblFOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFOrange.Location = New System.Drawing.Point(20, 88)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(37, 23)
        Me.lblFOrange.TabIndex = 1
        '
        'lblFRed
        '
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.Location = New System.Drawing.Point(17, 38)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(40, 23)
        Me.lblFRed.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblBSky)
        Me.GroupBox2.Controls.Add(Me.lblBWhite)
        Me.GroupBox2.Controls.Add(Me.lblBBlack)
        Me.GroupBox2.Controls.Add(Me.lblBRed)
        Me.GroupBox2.Controls.Add(Me.lblBBrown)
        Me.GroupBox2.Controls.Add(Me.lblBOrange)
        Me.GroupBox2.Controls.Add(Me.lblBViolet)
        Me.GroupBox2.Controls.Add(Me.lblBBlue)
        Me.GroupBox2.Controls.Add(Me.lblBYellow)
        Me.GroupBox2.Controls.Add(Me.lblBGreen)
        Me.GroupBox2.Location = New System.Drawing.Point(446, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 153)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BgColor"
        '
        'lblBSky
        '
        Me.lblBSky.BackColor = System.Drawing.Color.Aqua
        Me.lblBSky.Location = New System.Drawing.Point(295, 88)
        Me.lblBSky.Name = "lblBSky"
        Me.lblBSky.Size = New System.Drawing.Size(39, 23)
        Me.lblBSky.TabIndex = 1
        '
        'lblBWhite
        '
        Me.lblBWhite.BackColor = System.Drawing.Color.White
        Me.lblBWhite.Location = New System.Drawing.Point(225, 88)
        Me.lblBWhite.Name = "lblBWhite"
        Me.lblBWhite.Size = New System.Drawing.Size(39, 23)
        Me.lblBWhite.TabIndex = 1
        '
        'lblBBlack
        '
        Me.lblBBlack.BackColor = System.Drawing.Color.Black
        Me.lblBBlack.Location = New System.Drawing.Point(295, 38)
        Me.lblBBlack.Name = "lblBBlack"
        Me.lblBBlack.Size = New System.Drawing.Size(39, 23)
        Me.lblBBlack.TabIndex = 0
        '
        'lblBRed
        '
        Me.lblBRed.BackColor = System.Drawing.Color.Red
        Me.lblBRed.Location = New System.Drawing.Point(23, 38)
        Me.lblBRed.Name = "lblBRed"
        Me.lblBRed.Size = New System.Drawing.Size(40, 23)
        Me.lblBRed.TabIndex = 0
        '
        'lblBBrown
        '
        Me.lblBBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBBrown.Location = New System.Drawing.Point(154, 88)
        Me.lblBBrown.Name = "lblBBrown"
        Me.lblBBrown.Size = New System.Drawing.Size(39, 23)
        Me.lblBBrown.TabIndex = 1
        '
        'lblBOrange
        '
        Me.lblBOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBOrange.Location = New System.Drawing.Point(26, 88)
        Me.lblBOrange.Name = "lblBOrange"
        Me.lblBOrange.Size = New System.Drawing.Size(37, 23)
        Me.lblBOrange.TabIndex = 1
        '
        'lblBViolet
        '
        Me.lblBViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblBViolet.Location = New System.Drawing.Point(222, 38)
        Me.lblBViolet.Name = "lblBViolet"
        Me.lblBViolet.Size = New System.Drawing.Size(42, 23)
        Me.lblBViolet.TabIndex = 0
        '
        'lblBBlue
        '
        Me.lblBBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBBlue.Location = New System.Drawing.Point(84, 38)
        Me.lblBBlue.Name = "lblBBlue"
        Me.lblBBlue.Size = New System.Drawing.Size(42, 23)
        Me.lblBBlue.TabIndex = 0
        '
        'lblBYellow
        '
        Me.lblBYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBYellow.Location = New System.Drawing.Point(87, 88)
        Me.lblBYellow.Name = "lblBYellow"
        Me.lblBYellow.Size = New System.Drawing.Size(39, 23)
        Me.lblBYellow.TabIndex = 1
        '
        'lblBGreen
        '
        Me.lblBGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBGreen.Location = New System.Drawing.Point(151, 38)
        Me.lblBGreen.Name = "lblBGreen"
        Me.lblBGreen.Size = New System.Drawing.Size(39, 23)
        Me.lblBGreen.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(178, 83)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(101, 20)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "กำหนดตัวเลข"
        '
        'cboSize
        '
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"12", "14", "16", "18", "20", "22", "24", "26", "28", "30", "32", "34", "36", "38", "40", "42", "44", "46", "48", "50"})
        Me.cboSize.Location = New System.Drawing.Point(446, 153)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(121, 21)
        Me.cboSize.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(227, 415)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(345, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "น.ส.อิสราภรณ์ สุพรม BIS2N1 60342110045-0"
        '
        'frmLab3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 453)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "frmLab3"
        Me.Text = "frmAssign3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents cboZize As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFSky As Label
    Friend WithEvents lblFBlack As Label
    Friend WithEvents lblFWhite As Label
    Friend WithEvents lblFViolet As Label
    Friend WithEvents lblFBrown As Label
    Friend WithEvents lblFGreen As Label
    Friend WithEvents lblFYellow As Label
    Friend WithEvents lblFBlue As Label
    Friend WithEvents lblFOrange As Label
    Friend WithEvents lblFRed As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblBSky As Label
    Friend WithEvents lblBWhite As Label
    Friend WithEvents lblBBlack As Label
    Friend WithEvents lblBRed As Label
    Friend WithEvents lblBOrange As Label
    Friend WithEvents lblBViolet As Label
    Friend WithEvents lblBBlue As Label
    Friend WithEvents lblBYellow As Label
    Friend WithEvents lblBGreen As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblBBrown As Label
    Friend WithEvents cboSize As ComboBox
    Friend WithEvents Label2 As Label
End Class
