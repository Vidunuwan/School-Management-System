Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String
        Dim password As String
        username = txtUsername.Text
        password = txtPassword.Text
        If username = "Vidu" And password = "123456" Then

            Me.Hide()
            Form2.Show()
        Else
            txtUsername.Clear()
            txtPassword.Clear()
            MsgBox("Check username and password")

        End If



    End Sub
End Class
