Imports Microsoft.Win32

Module installedApplicationsHandler
    Public Sub ListAllInstalledSoftwareInListView()

        Dim Software As String = Nothing

        Dim SoftwareKey As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\"

        For Each App As String In Registry.LocalMachine.OpenSubKey(SoftwareKey).GetSubKeyNames
            dtPrograms.Rows.Add(Registry.LocalMachine.OpenSubKey(SoftwareKey & App & "\").GetValue("DisplayName"))
        Next

    End Sub


End Module
