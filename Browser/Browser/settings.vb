Public Class settings
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.StartPage

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.StartPage = TextBox1.Text
        MsgBox("Granted")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.StartPage = ("https://www.google.com")
        MsgBox("Done")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False

    End Sub
End Class