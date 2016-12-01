Public Class Form2
    Private Sub resbtn_Click(sender As Object, e As EventArgs) Handles resbtn.Click
        frmdataentry.Show()
        Me.Close()
    End Sub

    Private Sub pribtn_Click(sender As Object, e As EventArgs) Handles pribtn.Click

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("Result.txt", True)
        file.WriteLine("Total Income:" & income)
        file.WriteLine("Total Expenditure:" & expenditure)
        file.WriteLine("Profit / Loss:" & proloss)
        file.WriteLine("Corporate tax:" & corptax)
        file.WriteLine("Net Profit:" & netpro)
        file.Close()


        Dim p As New Process
        Dim info As New ProcessStartInfo
        info.FileName = "Result.txt"
        info.Verb = "print"
        p.StartInfo = info
        p.Start()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start(url)
    End Sub
End Class