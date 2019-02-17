Imports Munch.Log

Public Class LoginForm

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

End Class