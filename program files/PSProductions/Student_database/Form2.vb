Public Class Form2


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        CircularProgress1.Value += 10
        If CircularProgress1.Value = 200 Then
            Label2.Visible = False
            Label3.Visible = True
        End If
        If CircularProgress1.Value = 300 Then
            Label3.Visible = False
            Label4.Visible = True
        End If
        If CircularProgress1.Value = 400 Then

            Timer1.Stop()

            Form1.Show()
            Form1.WindowState = FormWindowState.Maximized
            Form3.Show()
            Me.Hide()


        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub CircularProgress1_ValueChanged(sender As Object, e As EventArgs) Handles CircularProgress1.ValueChanged
        CircularProgress1.IsRunning = Not CircularProgress1.IsRunning
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class