Imports Awesomium.Core

Public Class lol
    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        settings.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lol_Load(sender As Object, e As EventArgs) Handles Me.Load
        WebControl1.Source = New Uri(My.Settings.StartPage)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebControl1.Source = New Uri(My.Settings.StartPage)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If WebControl1.CanGoBack Then
            WebControl1.GoBack()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If WebControl1.CanGoForward Then
            WebControl1.GoForward()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If WebControl1.IsNavigating Then
            WebControl1.Stop()

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebControl1.Reload(ignoreCache:=True)

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".org") Then
            Try
                WebControl1.Source = New Uri(TextBox1.Text)

            Catch ex As System.UriFormatException
                WebControl1.Source = New Uri("http://" + TextBox1.Text)
                TextBox1.Text = ("http://" + TextBox1.Text)

            End Try
        Else : WebControl1.Source = New Uri("https://www.google.gr/?gfe_rd=cr&ei=mdQ-WN23Aq6T8Qf-govoAw&gws_rd=ssl#q=" & TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".org") Then
                Try
                    WebControl1.Source = New Uri(TextBox1.Text)

                Catch ex As System.UriFormatException
                    WebControl1.Source = New Uri("http://" + TextBox1.Text)
                    TextBox1.Text = ("http://" + TextBox1.Text)

                End Try
            Else : WebControl1.Source = New Uri("https://www.google.gr/?gfe_rd=cr&ei=mdQ-WN23Aq6T8Qf-govoAw&gws_rd=ssl#q=" & TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(sender As Object, e As Awesomium.Core.ShowCreatedWebViewEventArgs) Handles WebControl1.ShowCreatedWebView
        PictureBox1.Visible = False

        Parent.Text = WebControl1.Title
        TextBox1.Text = WebControl1.Source.ToString
    End Sub

    Private Sub WebControl1_LoadingFrame(sender As Object, e As LoadingFrameEventArgs) Handles WebControl1.LoadingFrame
        PictureBox1.Visible = True

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("This programme was created by me and thats all you need to know :)")


    End Sub
End Class
