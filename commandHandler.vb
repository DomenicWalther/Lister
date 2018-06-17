Module CommandHandler
    ' Gets the Command the User typed in by removing the cmd part at the beginning and then calls the RunCommand
    Public Function GetCommandFunction(selectedItem As String)
        Dim txtfilter = Form1.txtFilter.Text
        Dim itemLength As Integer = selectedItem.Length
        Dim commandQuery = txtfilter.Remove(0, itemLength + 1)
        RunCommandCom(commandQuery, True)
        HideForm()
    End Function

    ' Creates a new Process and uses the command as arguments
    Private Function RunCommandCom(command As String, permanent As Boolean)
        Dim cmdProcess = New Process()
        Dim processInfo = New ProcessStartInfo()
        processInfo.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command
        processInfo.FileName = "cmd.exe"
        cmdProcess.StartInfo = processInfo
        cmdProcess.Start()
    End Function
End Module
