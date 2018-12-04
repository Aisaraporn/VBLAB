Public Class frm2
    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim Sale1 As Double
        Dim Sale2 As Double
        Dim TotalSale As Double
        Dim Commit1 As Double
        Dim Commit2 As Double
        Dim TotalCommit As Double

        Sale1 = Val(txtComputer.Text)
        Sale2 = Val(txtPrinter.Text)

        TotalSale = Sale1 + Sale2
        lblTotalSale.Text = TotalSale

        Commit1 = Sale1 * 5 / 100
        lblCommition1.Text = Commit1

        Commit2 = Sale2 * 10 / 100
        lblCommition2.Text = Commit2

        TotalCommit = Commit1 + Commit2
        lblTotalCommition.Text = TotalCommit

        lblSale1.Text = Sale1
        lblSale2.Text = Sale2


    End Sub
End Class