Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDbase()
        txtFNameSearch.Enabled = False
        txtLNameSearch.Enabled = False
        txtCourseSearch.Enabled = False
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        SaveRecord()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchData()

    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
