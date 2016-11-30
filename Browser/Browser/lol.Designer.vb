<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lol
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KappaBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.WebControl1 = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1450, 46)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Browser.My.Resources.Resources.loading_anim
        Me.PictureBox1.Location = New System.Drawing.Point(1403, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(631, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(707, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.Location = New System.Drawing.Point(1344, 11)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(58, 24)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "Enter"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(221, 11)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(58, 22)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Help"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(565, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(59, 22)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Home"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(502, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(57, 22)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Reload"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(447, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 22)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Stop"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(366, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 22)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(285, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KappaBrowserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1450, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KappaBrowserToolStripMenuItem
        '
        Me.KappaBrowserToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.KappaBrowserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.KappaBrowserToolStripMenuItem.Image = Global.Browser.My.Resources.Resources.internet_web_browser
        Me.KappaBrowserToolStripMenuItem.Name = "KappaBrowserToolStripMenuItem"
        Me.KappaBrowserToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.KappaBrowserToolStripMenuItem.Text = "KappaBrowser"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = Global.Browser.My.Resources.Resources.internet_web_browser
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.WebControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1450, 765)
        Me.Panel2.TabIndex = 1
        '
        'WebControl1
        '
        Me.WebControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebControl1.Location = New System.Drawing.Point(0, 0)
        Me.WebControl1.Size = New System.Drawing.Size(1450, 765)
        Me.WebControl1.TabIndex = 0
        '
        'lol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 811)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "lol"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "lol"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Private WithEvents WebControl1 As Awesomium.Windows.Forms.WebControl
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KappaBrowserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
