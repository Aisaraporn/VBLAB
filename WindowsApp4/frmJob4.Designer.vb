<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJob4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblYearSalary = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblAllIncome = New System.Windows.Forms.Label()
        Me.lblAllowance = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radLongDate = New System.Windows.Forms.RadioButton()
        Me.radGenDate = New System.Windows.Forms.RadioButton()
        Me.radShortDate = New System.Windows.Forms.RadioButton()
        Me.btnCalTax = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณภาษี(อย่างหยาบ)"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "วันที่"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(102, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "เงินเดือน"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(102, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ยอดขายทั้้งปี"
        '
        'lblYearSalary
        '
        Me.lblYearSalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblYearSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblYearSalary.Location = New System.Drawing.Point(252, 202)
        Me.lblYearSalary.Name = "lblYearSalary"
        Me.lblYearSalary.Size = New System.Drawing.Size(172, 24)
        Me.lblYearSalary.TabIndex = 0
        Me.lblYearSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBonus
        '
        Me.lblBonus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBonus.Location = New System.Drawing.Point(252, 242)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(172, 18)
        Me.lblBonus.TabIndex = 0
        Me.lblBonus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAllIncome
        '
        Me.lblAllIncome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblAllIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAllIncome.Location = New System.Drawing.Point(252, 275)
        Me.lblAllIncome.Name = "lblAllIncome"
        Me.lblAllIncome.Size = New System.Drawing.Size(172, 24)
        Me.lblAllIncome.TabIndex = 0
        Me.lblAllIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAllowance
        '
        Me.lblAllowance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblAllowance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllowance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAllowance.Location = New System.Drawing.Point(252, 315)
        Me.lblAllowance.Name = "lblAllowance"
        Me.lblAllowance.Size = New System.Drawing.Size(172, 24)
        Me.lblAllowance.TabIndex = 0
        Me.lblAllowance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTax.Location = New System.Drawing.Point(252, 357)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(172, 24)
        Me.lblTax.TabIndex = 0
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(252, 87)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(172, 24)
        Me.lblDate.TabIndex = 0
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(255, 125)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(169, 20)
        Me.txtSalary.TabIndex = 1
        '
        'txtSale
        '
        Me.txtSale.Location = New System.Drawing.Point(255, 163)
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(169, 20)
        Me.txtSale.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(102, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 18)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "รับเงินเดือนโบนัส"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(102, 275)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 24)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "รวมรายได้"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(102, 202)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 24)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "เงินเดือนทั้งปี"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(102, 315)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 24)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "หักค่าลดหย่อน"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(102, 357)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 24)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "ภาษ๊ที่ต้องชำระ"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Cyan
        Me.GroupBox1.Controls.Add(Me.radLongDate)
        Me.GroupBox1.Controls.Add(Me.radGenDate)
        Me.GroupBox1.Controls.Add(Me.radShortDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(430, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 116)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รูปแแบบวันที่"
        '
        'radLongDate
        '
        Me.radLongDate.AutoSize = True
        Me.radLongDate.Location = New System.Drawing.Point(16, 68)
        Me.radLongDate.Name = "radLongDate"
        Me.radLongDate.Size = New System.Drawing.Size(166, 22)
        Me.radLongDate.TabIndex = 0
        Me.radLongDate.TabStop = True
        Me.radLongDate.Text = "วันที่แบบ Long Date"
        Me.radLongDate.UseVisualStyleBackColor = True
        '
        'radGenDate
        '
        Me.radGenDate.AutoSize = True
        Me.radGenDate.Location = New System.Drawing.Point(16, 45)
        Me.radGenDate.Name = "radGenDate"
        Me.radGenDate.Size = New System.Drawing.Size(188, 22)
        Me.radGenDate.TabIndex = 0
        Me.radGenDate.TabStop = True
        Me.radGenDate.Text = "วันที่แบบ General Date"
        Me.radGenDate.UseVisualStyleBackColor = True
        '
        'radShortDate
        '
        Me.radShortDate.AutoSize = True
        Me.radShortDate.Location = New System.Drawing.Point(16, 19)
        Me.radShortDate.Name = "radShortDate"
        Me.radShortDate.Size = New System.Drawing.Size(170, 22)
        Me.radShortDate.TabIndex = 0
        Me.radShortDate.TabStop = True
        Me.radShortDate.Text = "วันที่แบบ Short Date"
        Me.radShortDate.UseVisualStyleBackColor = True
        '
        'btnCalTax
        '
        Me.btnCalTax.BackColor = System.Drawing.Color.Yellow
        Me.btnCalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalTax.Location = New System.Drawing.Point(449, 275)
        Me.btnCalTax.Name = "btnCalTax"
        Me.btnCalTax.Size = New System.Drawing.Size(185, 75)
        Me.btnCalTax.TabIndex = 4
        Me.btnCalTax.Text = "คำนวณ"
        Me.btnCalTax.UseVisualStyleBackColor = False
        '
        'frmJob4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 489)
        Me.Controls.Add(Me.btnCalTax)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSale)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblAllowance)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblYearSalary)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblAllIncome)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblBonus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmJob4"
        Me.Text = "frmJob4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblYearSalary As Label
    Friend WithEvents lblBonus As Label
    Friend WithEvents lblAllIncome As Label
    Friend WithEvents lblAllowance As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtSale As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radGenDate As RadioButton
    Friend WithEvents radShortDate As RadioButton
    Friend WithEvents radLongDate As RadioButton
    Friend WithEvents btnCalTax As Button
End Class
