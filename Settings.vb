Public Class Settings
    Public lv As New ListView

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        commandList()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        searchHandler.addSearchList(txtKey.Text, txtLink.Text)
        lv.Clear()
        commandList()
        txtKey.Clear()
        txtLink.Clear()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        MessageBox.Show(lv.SelectedItems(0).Text)
        searchHandler.removeSearchList(lv.SelectedItems(0).Text)
        lv.Clear()
        commandList()
    End Sub

    Public Function commandList()

        With lv
            .View = View.Details
            .FullRowSelect = True
            .Columns.Add("Command")
            .Columns.Add("Link")
        End With


        lv.Dock = DockStyle.Fill
        Me.Controls.Add(lv)

        For Each keyValue As KeyValuePair(Of String, String) In searchHandler.searchList
            lv.Items.Add(New ListViewItem({keyValue.Key, keyValue.Value}))
        Next
    End Function


End Class