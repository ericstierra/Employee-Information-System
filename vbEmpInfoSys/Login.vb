Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String
        Dim password As String
        username = "Admin"
        password = "cc103"

        If txtUsername.Text = username And txtPass.Text = password Then
            MsgBox("You have successfully logged in!", MsgBoxStyle.Information, "Welcome to Employee's Information System")
            txtUsername.Clear()
            txtPass.Clear()
            AddEntry.Show()
            Me.Hide()
        Else
            MsgBox("Sorry wrong username or password. Please try again!", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub
End Class