<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab5
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gpbOther = New System.Windows.Forms.GroupBox()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.radMember = New System.Windows.Forms.RadioButton()
        Me.gpbPaid = New System.Windows.Forms.GroupBox()
        Me.radCredit = New System.Windows.Forms.RadioButton()
        Me.radPaid = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.gpbOther.SuspendLayout()
        Me.gpbPaid.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณการขาย"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ราคาขาย"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "จำนวนซื้อ"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(59, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "เป็นเงิน"
        '
        'txtProduct
        '
        Me.txtProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduct.Location = New System.Drawing.Point(289, 43)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(163, 26)
        Me.txtProduct.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(289, 77)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(163, 26)
        Me.txtPrice.TabIndex = 2
        '
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(289, 112)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(163, 26)
        Me.txtUnit.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(70, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ส่วนลด"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(70, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "จำนวนเงินที่ต้องชำระ"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(70, 408)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ยอดค้างชำระ"
        '
        'gpbOther
        '
        Me.gpbOther.Controls.Add(Me.radOther)
        Me.gpbOther.Controls.Add(Me.radMember)
        Me.gpbOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbOther.Location = New System.Drawing.Point(42, 209)
        Me.gpbOther.Name = "gpbOther"
        Me.gpbOther.Size = New System.Drawing.Size(223, 90)
        Me.gpbOther.TabIndex = 2
        Me.gpbOther.TabStop = False
        Me.gpbOther.Text = "ประเภทสินค้า"
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Location = New System.Drawing.Point(122, 49)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(101, 24)
        Me.radOther.TabIndex = 0
        Me.radOther.TabStop = True
        Me.radOther.Text = "ลูกค้าทั่วไป"
        Me.radOther.UseVisualStyleBackColor = True
        '
        'radMember
        '
        Me.radMember.AutoSize = True
        Me.radMember.Location = New System.Drawing.Point(26, 49)
        Me.radMember.Name = "radMember"
        Me.radMember.Size = New System.Drawing.Size(75, 24)
        Me.radMember.TabIndex = 0
        Me.radMember.TabStop = True
        Me.radMember.Text = "สมาชิก"
        Me.radMember.UseVisualStyleBackColor = True
        '
        'gpbPaid
        '
        Me.gpbPaid.Controls.Add(Me.radCredit)
        Me.gpbPaid.Controls.Add(Me.radPaid)
        Me.gpbPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbPaid.Location = New System.Drawing.Point(289, 209)
        Me.gpbPaid.Name = "gpbPaid"
        Me.gpbPaid.Size = New System.Drawing.Size(192, 90)
        Me.gpbPaid.TabIndex = 2
        Me.gpbPaid.TabStop = False
        Me.gpbPaid.Text = "การชำระเงิน"
        '
        'radCredit
        '
        Me.radCredit.AutoSize = True
        Me.radCredit.Location = New System.Drawing.Point(122, 49)
        Me.radCredit.Name = "radCredit"
        Me.radCredit.Size = New System.Drawing.Size(53, 24)
        Me.radCredit.TabIndex = 0
        Me.radCredit.TabStop = True
        Me.radCredit.Text = "เชื่อ"
        Me.radCredit.UseVisualStyleBackColor = True
        '
        'radPaid
        '
        Me.radPaid.AutoSize = True
        Me.radPaid.Location = New System.Drawing.Point(26, 49)
        Me.radPaid.Name = "radPaid"
        Me.radPaid.Size = New System.Drawing.Size(46, 24)
        Me.radPaid.TabIndex = 0
        Me.radPaid.TabStop = True
        Me.radPaid.Text = "สด"
        Me.radPaid.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(289, 437)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(163, 31)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(279, 153)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(185, 25)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDiscount.Location = New System.Drawing.Point(286, 334)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(163, 23)
        Me.lblDiscount.TabIndex = 4
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPaid
        '
        Me.lblPaid.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPaid.Location = New System.Drawing.Point(286, 368)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(163, 23)
        Me.lblPaid.TabIndex = 4
        Me.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCredit
        '
        Me.lblCredit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCredit.Location = New System.Drawing.Point(286, 408)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(163, 23)
        Me.lblCredit.TabIndex = 4
        Me.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmLab5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 515)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.gpbPaid)
        Me.Controls.Add(Me.gpbOther)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab5"
        Me.Text = "frmLab5"
        Me.gpbOther.ResumeLayout(False)
        Me.gpbOther.PerformLayout()
        Me.gpbPaid.ResumeLayout(False)
        Me.gpbPaid.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents gpbOther As GroupBox
    Friend WithEvents radMember As RadioButton
    Friend WithEvents radOther As RadioButton
    Friend WithEvents gpbPaid As GroupBox
    Friend WithEvents radCredit As RadioButton
    Friend WithEvents radPaid As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblPaid As Label
    Friend WithEvents lblCredit As Label
End Class
