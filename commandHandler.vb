Module commandHandler

    ' Gets the Command the User typed in by removing the cmd part at the beginning and then calls the RunCommand
    Public Function getCommandFunction(selectedItem As String)
        Dim txtfilter = Form1.txtFilter.Text
        Dim itemLength As Integer = selectedItem.Length
        Dim commandQuery = txtfilter.Remove(0, itemLength + 1)
        RunCommandCom(commandQuery, True)
        listerFormHandler.HideForm()
    End Function

    ' Creates a new Process and uses the command as arguments
    Private Function RunCommandCom(command As String, permanent As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        p.Start()
    End Function
End Module
