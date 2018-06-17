Public Module taskManagerPrograms
    Public dtPrograms As DataTable = New DataTable

    ' Defines all of the Listbox Properties
    Public Function GetPrograms() As DataTable
        Form1.lbPrograms.DataSource = GetData()
        Form1.lbPrograms.DisplayMember = "Programs"
        Form1.lbPrograms.ValueMember = "Handles"
    End Function

    ' Adds Rows & Columns by looping through the running programs & the searchList
    Private Function GetData() As DataTable
        dtPrograms.Columns.Add("Programs", GetType(String))
        dtPrograms.Columns.Add("Handles", GetType(String))

        For Each proc As Process In Process.GetProcesses
            If proc.MainWindowTitle <> "" Then
                dtPrograms.Rows.Add(proc.MainWindowTitle, proc.MainWindowHandle)
            End If
        Next

        For Each kvp As KeyValuePair(Of String, String) In SearchHandler.SearchList
            dtPrograms.Rows.Add(kvp.Key)
        Next

        dtPrograms.Rows.Add("cmd")

        Return dtPrograms
    End Function
End Module
