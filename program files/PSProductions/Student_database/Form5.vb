Public Class Form5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "GitUser" And TextBox2.Text = "1324" Then
            Me.Hide()
            Form4.Panel1.Location = New Point(-222, 0)
            Do Until Form4.Panel1.Location.X = -10
                Form4.Panel1.Location = New Point(Form4.Panel1.Location.X + 1, 0)
            Loop
            Do Until Form4.Panel1.Location.X = 0
                Form4.Panel1.Location = New Point(Form4.Panel1.Location.X + 1, 0)
                System.Threading.Thread.Sleep(20)
            Loop
            TextBox1.Clear()
            TextBox2.Clear()
        Else
            MsgBox("Username or Password is incorrect", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class