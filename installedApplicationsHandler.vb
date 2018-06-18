Imports Microsoft.Win32

Module installedApplicationsHandler
    Public Sub ListAllInstalledSoftwareInListView()

        Dim software As String = Nothing

        Dim softwareKey As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\"

        For Each App As String In Registry.LocalMachine.OpenSubKey(softwareKey).GetSubKeyNames
            dtPrograms.Rows.Add(Registry.LocalMachine.OpenSubKey(softwareKey & App & "\").GetValue("DisplayName"))
        Next

    End Sub


End Module
