Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles lgnbtn.Click

        If passtxt.Text = storedpassword(0) Then
            If usertxt.Text = Storedusername(0) Then
                MsgBox("Welcome Back")
                frmdataentry.Show()
                Me.Hide()
            End If
        ElseIf passtxt.Text = storedpassword(1) Then
            If usertxt.Text = Storedusername(1) Then
                MsgBox("Welcome Back")
                frmdataentry.Show()
                Me.Hide()
            End If
        ElseIf usertxt.Text = Storedusername(3) Then
            If passtxt.Text = storedpassword(3) Then
                MsgBox("Welcome Back")
                frmdataentry.Show()
                Me.Hide()
            End If
        ElseIf usertxt.Text = storedusername(2) Then
            If passtxt.Text = storedpassword(2) Then
                MsgBox("Welcome Back")
                frmdataentry.Show()
                Me.Hide()
            End If
        ElseIf usertxt.Text = Storedusername(4) Then
            If passtxt.Text = storedpassword(4) Then
                MsgBox("Welcome Back")
                frmdataentry.Show()
                Me.Hide()
            End If
        ElseIf usertxt.Text = Storedusername(5) Then
            If passtxt.Text = storedpassword(5) Then
                MsgBox("Welcome Back")
                frmdataentry.Show()
                Me.Hide()
            End If
        ElseIf usertxt.Text = Storedusername(6) Then
            If passtxt.Text = storedpassword(6) Then
                MsgBox("Welcome Back")
                frmdataentry.Show()
                Me.Hide()
            End If
        ElseIf usertxt.Text = Storedusername(7) Then
            If passtxt.Text = storedpassword(7) Then
                MsgBox("Welcome Back")
                frmdataentry.Show()
                Me.Hide()
            End If
        ElseIf usertxt.Text = Storedusername(8) Then
            If passtxt.Text = storedpassword(8) Then
                MsgBox("Welcome Back")
                frmdataentry.Show()
                Me.Hide()
            End If
        ElseIf passtxt.Text = storedpassword(9) Then
            If usertxt.Text = Storedusername(9) Then
                MsgBox("Welcome Back")
                frmdataentry.Show()
                Me.Hide()
            End If
        Else
            MsgBox("Incorrect username/password.")
        End If

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        storedpassword(0) = "1"
        storedpassword(1) = "tight"
        storedpassword(2) = "Hideeous"
        storedpassword(3) = "lucky"
        storedpassword(4) = "drunk"
        storedpassword(5) = "escalator"
        storedpassword(6) = "protection"
        storedpassword(7) = "lubricant"
        storedpassword(8) = "cable"
        storedpassword(9) = "doctor"
        Storedusername(0) = "1"
        Storedusername(1) = "roll"
        Storedusername(2) = "your"
        Storedusername(3) = "super"
        Storedusername(4) = "quick"
        Storedusername(5) = "for"
        Storedusername(6) = "kush"
        Storedusername(7) = "flavour"
        Storedusername(8) = "free"
        Storedusername(9) = "drink"
    End Sub

    Private Sub Helpbtn_Click(sender As Object, e As EventArgs) Handles Helpbtn.Click
        Process.Start(url)
    End Sub
End Class