Public Class Form4

 Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Table1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LOGINFORALLDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.LOGINFORALLDataSet.Table1)

    End Sub

    Private Sub YESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YESToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub NOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NOToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        RefreshToolStripMenuItem.Enabled = False
        Me.Width = 619
        Me.Height = 304
        TextBox4.Text = ""
        TextBox3.Text = ""
        TextBox6.Text = ""
        Label10.Visible = True
        Label13.Visible = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Width = 324
        Me.Height = 304
        Label14.Visible = False
        Label15.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Table1BindingSource.AddNew()
        Button1.Hide()

        TextBox4.Enabled = True
        TextBox3.Enabled = True
        Label10.Visible = False
        Label13.Visible = False
        Label14.Visible = True
        Label15.Visible = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error GoTo SaveErr
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(LOGINFORALLDataSet.Table1)

        If MsgBox("ACCOUNT SAVED", MsgBoxStyle.Information, "SAVED") = MsgBoxResult.Ok Then
            Me.Width = 324
            Me.Height = 304
            Button1.Visible = True
            Label14.Visible = False
            Label15.Visible = False
        End If
SaveErr:

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id As String
        Dim username As String
        Dim password As String

        Try
            id = TextBox5.Text

            username = TextBox1.Text
            password = TextBox2.Text

            If Me.Table1TableAdapter.ScalarQueryL(id, username, password) Then
                Timer1.Start()
                CircularProgress1.Visible = True
                Label6.Visible = True
                Arrow.ShowDialog()
            Else
              


                LinkLabel1.Visible = True
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox5.Clear()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    
        CircularProgress1.Value += 10
        If CircularProgress1.Value = 300 Then
            Timer1.Stop()
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckAllAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckAllAccountsToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Height = 338

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox1.Show()
        PictureBox2.Hide()
      
        TextBox2.UseSystemPasswordChar = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox2.Show()
        PictureBox1.Hide()
        
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub CircularProgress1_ValueChanged(sender As Object, e As EventArgs) Handles CircularProgress1.ValueChanged
        CircularProgress1.IsRunning = Not CircularProgress1.IsRunning
    End Sub

    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs)
        Table1BindingSource.EndEdit()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Panel1.Location = New Point(0, 0)
        Do Until Panel1.Location.X = -190
            Panel1.Location = New Point(Panel1.Location.X - 1, 0)
        Loop
        Do Until Panel1.Location.X = -305
            Panel1.Location = New Point(Panel1.Location.X - 1, 0)
        Loop
        If MsgBox("Change(s) if made Saved", MsgBoxStyle.OkOnly, "Changes Saved") = MsgBoxResult.Yes Then
            On Error GoTo SaveErr
            Table1BindingSource.EndEdit()
            Table1TableAdapter.Update(LOGINFORALLDataSet.Table1)

SaveErr:




        Else



        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Table1BindingSource.MoveNext()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Table1BindingSource.MovePrevious()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Table1BindingSource.RemoveCurrent()

    End Sub
End Class