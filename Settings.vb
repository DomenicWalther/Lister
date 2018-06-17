Public Class Settings
    Public lv As New ListView

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CommandList()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddSearchList(txtKey.Text, txtLink.Text)
        lv.Clear()
        CommandList()
        txtKey.Clear()
        txtLink.Clear()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        MessageBox.Show(lv.SelectedItems(0).Text)
        RemoveSearchList(lv.SelectedItems(0).Text)
        lv.Clear()
        CommandList()
    End Sub

    Public Function CommandList()

        With lv
            .View = View.Details
            .FullRowSelect = True
            .Columns.Add("Command")
            .Columns.Add("Link")
        End With


        lv.Dock = DockStyle.Fill
        Me.Controls.Add(lv)

        For Each keyValue As KeyValuePair(Of String, String) In SearchList
            lv.Items.Add(New ListViewItem({keyValue.Key, keyValue.Value}))
        Next
    End Function
End Class