Public Module TaskManagerPrograms
    Public DtPrograms As DataTable = New DataTable

    ' Defines all of the Listbox Properties
    Public Function GetPrograms() As DataTable
        Form1.lbPrograms.DataSource = GetData()
        Form1.lbPrograms.DisplayMember = "Programs"
        Form1.lbPrograms.ValueMember = "Handles"
    End Function

    ' Adds Rows & Columns by looping through the running programs & the searchList
    Private Function GetData() As DataTable
        DtPrograms.Columns.Add("Programs", GetType(String))
        DtPrograms.Columns.Add("Handles", GetType(String))

        For Each proc As Process In Process.GetProcesses
            If proc.MainWindowTitle <> "" Then
                DtPrograms.Rows.Add(proc.MainWindowTitle, proc.MainWindowHandle)
            End If
        Next

        For Each kvp As KeyValuePair(Of String, String) In SearchList
            DtPrograms.Rows.Add(kvp.Key)
        Next

        DtPrograms.Rows.Add("cmd")
        ListAllInstalledSoftwareInListView()
        Return DtPrograms
    End Function
End Module
