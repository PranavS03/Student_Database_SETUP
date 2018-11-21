Imports System.IO


Public Class Form1
    Dim imgName As String
    Private Sub ChangeBackgroundColourToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
        GroupBox1.BackColor = ColorDialog1.Color
        GroupBox2.BackColor = ColorDialog1.Color
        If Me.BackColor = Color.Black Then
            Me.ForeColor = Color.White
            Me.GroupBox1.ForeColor = Color.White
            Me.GroupBox2.ForeColor = Color.White
            Me.Button1.BackColor = Color.Gray
            Button2.BackColor = Color.Gray
            Button4.BackColor = Color.Gray
            Button5.BackColor = Color.Gray
            Button6.BackColor = Color.Gray
            Button7.BackColor = Color.Gray
            Button3.BackColor = Color.Gray
            Button8.BackColor = Color.Gray
            Button9.BackColor = Color.Gray
        
        End If
        If Me.BackColor = Color.Black = False Then
            Me.ForeColor = Color.Black
            Me.GroupBox1.ForeColor = Color.Black
            Me.GroupBox2.ForeColor = Color.Black
            Me.Button1.BackColor = Color.White
            Button2.BackColor = Color.White
            Button4.BackColor = Color.White
            Button5.BackColor = Color.White
            Button6.BackColor = Color.White
            Button7.BackColor = Color.White
            Button3.BackColor = Color.White
            Button8.BackColor = Color.White
            Button9.BackColor = Color.White
          


        End If
    End Sub

    Private Sub RestartApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartApplicationToolStripMenuItem.Click
        Panel1.Location = New Point(-222, 0)
        Do Until Panel1.Location.X = -10
            Panel1.Location = New Point(Panel1.Location.X + 1, 0)
        Loop
        Do Until Panel1.Location.X = 0
            Panel1.Location = New Point(Panel1.Location.X + 1, 0)
            System.Threading.Thread.Sleep(20)
        Loop
    End Sub

    Private Sub ResetBackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database11111DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Database11111DataSet.Table1)
        'TODO: This line of code loads data into the 'Database11111DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Database11111DataSet.Table1)

        Timer1.Start()

        Table1BindingSource.AddNew()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MsgBox("Are You Sure You Want To Exit?", MsgBoxStyle.YesNo, "EXIT") = MsgBoxResult.Yes Then
            Me.Close()
            End

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error GoTo SaveErr
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(Database11111DataSet.Table1)
        MsgBox("STUDENT INFORMATION HAS BEEN SAVED", MsgBoxStyle.Information, "SAVED")
SaveErr:
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Table1BindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Table1BindingSource.MoveNext()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Table1BindingSource.MoveFirst()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Table1BindingSource.MoveLast()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Table1BindingSource.AddNew()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Table1BindingSource.RemoveCurrent()
        Catch ex As Exception
            MsgBox("There is nothing to delete")
        End Try
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label11.Text = DateTime.Now.ToLongTimeString
        Label12.Text = DateTime.Now.ToLongDateString
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs)
    
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs)
        Me.Table1TableAdapter.Fill(Me.Database11111DataSet.Table1)

    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            Dim fbd As New FolderBrowserDialog
            If fbd.ShowDialog = vbOK Then
                File.Copy("Database11111.mdb", fbd.SelectedPath & "\SR Backup.mdb")
                MsgBox("Backup created on the give location. Please do not change the file name or it may not be restored", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            Dim fbd As New FolderBrowserDialog
            If fbd.ShowDialog = vbOK Then
                File.Delete("Database11111.mdb")
                File.Copy(fbd.SelectedPath & "\SR Backup.mdb", "Database11111.mdb")
                MsgBox("Restored", MsgBoxStyle.Information)
                Application.Restart()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FeaturesOfTheApp.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim dlgImage As FileDialog = New OpenFileDialog()
            dlgImage.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png;*.ico)|*.jpg;*.bmp;*.gif;*.png;*.ico"

            If dlgImage.ShowDialog() = DialogResult.OK Then
                imgName = dlgImage.FileName

                Dim newimg As New Bitmap(imgName)

                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox1.Image = DirectCast(newimg, Image)
            End If

            dlgImage = Nothing
        Catch ae As System.ArgumentException
            imgName = " "

            MessageBox.Show(ae.Message.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    
    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        Panel1.Location = New Point(0, 0)
        Do Until Panel1.Location.X = -190
            Panel1.Location = New Point(Panel1.Location.X - 1, 0)
        Loop
        Do Until Panel1.Location.X = -222
            Panel1.Location = New Point(Panel1.Location.X - 1, 0)
        Loop
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.ForeColor = Color.White
        Panel1.ForeColor = Color.Black
        Me.GroupBox1.ForeColor = Color.Black
        Me.GroupBox2.ForeColor = Color.Black
        Me.BackColor = Color.White
        GroupBox1.BackColor = Color.White
        GroupBox2.BackColor = Color.White

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MenuStrip1.BackColor = Color.Gray
        Me.BackColor = Color.Gray
        GroupBox1.BackColor = Color.Gray
        GroupBox2.BackColor = Color.Gray
        Button11.Visible = False
        Button16.Visible = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        FeaturesOfTheApp.ShowDialog()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        AboutBox1.Show()

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        StudentData.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
       
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        MenuStrip1.BackColor = Color.White
        Me.BackColor = Color.White
        GroupBox1.BackColor = Color.White
        GroupBox2.BackColor = Color.White
        Button11.Visible = True
        Button16.Visible = False
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
       

        Me.Hide()


       







    End Sub
End Class
