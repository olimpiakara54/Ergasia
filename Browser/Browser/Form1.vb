Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lol As New TabPage
        Dim newlol As New lol
        newlol.Show()
        newlol.Dock = DockStyle.Fill
        newlol.TopLevel = False
        lol.Controls.Add(newlol)
        TabControl1.TabPages.Add(lol)

    End Sub
End Class
