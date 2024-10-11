Public Class Form1
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim name As String
        Dim age As Integer
        Dim favcolor As String
        'diplay name age and favcolor
        name = txtName.Text()
        age = txtAge.Text()
        favcolor = txtColor.Text()
        'diplay msg box
        MessageBox.Show(name & age & favcolor)
    End Sub
End Class
