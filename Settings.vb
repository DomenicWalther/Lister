Public Class Settings
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        searchHandler.addSearchList(txtKey.Text, txtLink.Text)
    End Sub

End Class