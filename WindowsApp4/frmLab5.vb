Public Class frmLab5
    Dim decTotal, decDiscount, decNet, decCredit As Double

    Private Sub radPaid_Click(sender As Object, e As EventArgs) Handles radPaid.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        lblTotal.Text = decTotal
    End Sub

    Private Sub radOther_Click(sender As Object, e As EventArgs) Handles radOther.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
        gpbPaid.Enabled = False
        radPaid.Checked = True
    End Sub

    Private Sub radCredit_Click(sender As Object, e As EventArgs) Handles radCredit.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub frmLab5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radMember.Select()
        radPaid.Select()
    End Sub

    Private Sub radMember_Click(sender As Object, e As EventArgs) Handles radMember.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
        gpbPaid.Enabled = True
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        decDiscount = 0
        Dim Sale1 As String = Val(txtProduct.Text)
        Dim Sale2 As Integer = Val(txtPrice.Text)
        Dim Sale3 As Integer = Val(txtUnit.Text)

        If Sale1 = "" Or Sale2 <= 0 Or Sale3 <= 0 Then

            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
        Else
            If radMember.Checked And radPaid.Checked Then
                If decTotal < 1000 Then
                    decDiscount = 0
                ElseIf decTotal < 5000 Then
                    decDiscount = 0.05 * decTotal
                ElseIf decTotal < 10000 Then
                    decDiscount = 0.1 * decTotal
                ElseIf decTotal >= 10000 Then
                    decDiscount = 0.15 * decTotal
                End If
                decNet = decTotal - decDiscount
            ElseIf radMember.Checked And radCredit.Checked Then
                decDiscount = 0
                decNet = decTotal
                decCredit = decTotal
            Else
                decNet = decTotal - 0
                decCredit = 0
            End If
        End If

        lblTotal.Text = FormatNumber(decTotal)
        lblPaid.Text = FormatNumber(decNet)
        lblDiscount.Text = FormatNumber(decDiscount)
        lblCredit.Text = FormatNumber(decCredit)


    End Sub
End Class