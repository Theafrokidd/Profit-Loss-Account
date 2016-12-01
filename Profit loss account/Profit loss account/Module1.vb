Module Module1
    Public storedpassword(10) As String
    Public Storedusername(10) As String
    Public income As Decimal
    Public expenditure As Decimal
    Public sales As Decimal
    Public proloss As Decimal
    Public corptax As Decimal
    Public netpro As Decimal
    Public rent As Decimal
    Public accfee As Decimal
    Public postage As Decimal
    Public traveling As Decimal
    Public print As Decimal
    Public stock As Decimal
    Public gas As Decimal
    Public expenses As Decimal
    Public broad As Decimal
    Public fixed As Decimal
    Public phone As Decimal
    Public land As Decimal
    Public usernum As Integer
    Public password As String
    Public username As String
    Public elect As Decimal
    Public insur As Decimal
    Public url As String = "https://docs.google.com/document/d/1whQmTNbnu1x0fd4fQulcyYDQrIbrXDhEoLfunLRtjCQ/edit?usp=sharing"
    Public Sub display()
        Form2.totinclbl.Text = Format(CDec(income), "#0.00")
        Form2.Totexplbl.Text = Format(CDec(expenditure), "#0.00")
        proloss = income - expenditure
        Form2.Proloslbl.Text = Format(CDec(proloss), "#0.00")

        If proloss >= 0 Then
            Form2.corpolbl.Text = Format(tax(proloss), "#0.00")
        Else
            Form2.corpolbl.Text = "0.00"
        End If
        Form2.netprolbl.Text = Format(CDec(proloss - Form2.corpolbl.Text), "#0.00")
    End Sub
    Function tax(i)
        i = income / 5
        Return i
    End Function
End Module
