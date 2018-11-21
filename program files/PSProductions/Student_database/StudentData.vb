Public Class StudentData

    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Table1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database11111DataSet)

    End Sub

    Private Sub StudentData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database11111DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Database11111DataSet.Table1)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim search As String = txtsearch.Text

        Try
            Me.Table1TableAdapter.FillByAdmnNo(Me.Database11111DataSet.Table1, search)
        Catch ex As Exception
            MsgBox("Please input a valid Number")
        End Try
    End Sub
End Class