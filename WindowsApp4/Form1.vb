Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblMoney.Text = Val(txtSalary.Text) * 12
        lblVat.Text = Val(lblMoney.Text) * 5 / 100
        lblTotal.Text = Val(lblMoney.Text) - Val(lblVat.Text)
    End Sub
End Class
