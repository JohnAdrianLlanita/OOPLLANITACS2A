Public Class Form2
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form1.Show()
        Me.Dispose()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDbase()
        LoadCourse()
        LoadAllData()

        With dgvData
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .RowsDefaultCellStyle.BackColor = Color.Beige
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
        End With
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If cboCourse.SelectedIndex = 0 Then
            DisplayData("BSIT")
        ElseIf cboCourse.SelectedIndex = 1 Then
            DisplayData("BSCS")
        ElseIf cboCourse.SelectedIndex = 2 Then
            DisplayData("CBA")
        ElseIf cboCourse.SelectedIndex = 3 Then
            DisplayData("COA")
        ElseIf cboCourse.SelectedIndex = 4 Then
            DisplayData("CME")
        ElseIf cboCourse.SelectedIndex = 5 Then
            DisplayData("CHMT")
        Else
            MsgBox("No Record Found!!!!!!!")

        End If

    End Sub
End Class