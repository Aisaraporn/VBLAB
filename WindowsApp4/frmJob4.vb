Public Class frmJob4

    Const decR_BONUS As Double = 0.2
    Const decR_ALLOW As Double = 0.01
    Const decR_TAX As Double = 0.07
    Dim dblYearSalary, dblBobus, dblAllIncome, dblAllowance, dblTax As Double

    Private Sub radLongDate_Click(sender As Object, e As EventArgs) Handles radLongDate.Click
        lblDate.Text = Format(Now, "Long Date")
    End Sub

    Private Sub radGenDate_Click(sender As Object, e As EventArgs) Handles radGenDate.Click
        lblDate.Text = Format(Now, "General Date")
    End Sub

    Private Sub radShortDate_Click(sender As Object, e As EventArgs) Handles radShortDate.Click
        lblDate.Text = Format(Now, "Short Date")
    End Sub

    Private Sub frmJob4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now
    End Sub

    Private Sub btnCalTax_Click(sender As Object, e As EventArgs) Handles btnCalTax.Click

        dblYearSalary = Val(txtSalary.Text) * 12
        dblBobus = Val(txtSale.Text) * decR_BONUS
        dblAllIncome = dblYearSalary + dblBobus
        dblAllowance = dblAllIncome * decR_ALLOW
        dblTax = (dblAllIncome - dblAllowance) * decR_TAX


        lblYearSalary.Text = dblYearSalary.ToString("#,###.##")
        lblBonus.Text = dblBobus.ToString("#,###.##")
        lblAllIncome.Text = dblAllIncome.ToString("#,###.##")
        lblAllowance.Text = dblAllowance.ToString("#,###.##")
        lblTax.Text = dblTax.ToString("#,###.##")


    End Sub


End Class