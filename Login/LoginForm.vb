Imports Munch.Log
Imports Munch.Theme

Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPalette()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim user As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        ' TODO: This is temporary, need to add credential / profile system in.
        If user = "" And password = "" Then
            logger.Info($"{user} successfully logged in.")
            Me.Hide()
            Main.Show()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Sub LoadPalette()
        Dim font As Font = GetFont()
        Dim palette As Palette = GetPalette()
        TableLayoutPanel1.BackColor = palette.primary
        Label1.Font = font
        Label1.ForeColor = palette.accent
        Label2.Font = font
        Label2.ForeColor = palette.accent
        TextBox1.Font = font
        TextBox1.ForeColor = palette.accent
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = font
        TextBox2.ForeColor = palette.accent
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        Button1.Font = font
        Button1.ForeColor = palette.accent
        Button1.BackColor = palette.secondary
        Button2.Font = font
        Button2.ForeColor = palette.accent
        Button2.BackColor = palette.secondary
        ' TODO: need to make sure buttons are flat style
        ' TODO: need to set on-click or hover button color
    End Sub

End Class