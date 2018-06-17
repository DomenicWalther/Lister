Public Class Settings
    Public lv As New ListView


    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateSearchList()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        MessageBox.Show("The button is actually working!")
        searchHandler.addSearchList(txtKey.Text, txtLink.Text)
    End Sub

    Public Function updateSearchList()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
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