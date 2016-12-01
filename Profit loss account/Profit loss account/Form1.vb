Public Class frmdataentry


    Private Sub btnCalcu_Click(sender As Object, e As EventArgs) Handles btnCalcu.Click
        sales = salestxt.Text
        rent = renttxt.Text
        gas = gastxt.Text
        broad = broadtxt.Text
        land = landtxt.Text
        phone = phonetxt.Text
        fixed = fixedtxt.Text
        expenses = expensetxt.Text
        stock = stocktxt.Text
        elect = electtxt.Text
        print = printtxt.Text
        traveling = traveltxt.Text
        insur = insurtxt.Text
        accfee = accounttxt.Text
        expenditure = rent + broad + gas + land + expenses + stock + traveling + insur + accfee + phone + print + fixed
        income = sales
        display()
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Helpbtn_Click(sender As Object, e As EventArgs) Handles Helpbtn.Click
        Process.Start(url)
    End Sub
End Class
