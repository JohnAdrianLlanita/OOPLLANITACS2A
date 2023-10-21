Public Class Form2
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDbase()
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
End Class