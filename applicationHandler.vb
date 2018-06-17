Imports System.Runtime.InteropServices

Module applicationHandler

    ' Imports the ShowWindow Library
    <DllImport("user32.dll", SetLastError:=True)>
    Public Function ShowWindow(hWnd As IntPtr, <MarshalAs(UnmanagedType.I4)> nCmdShow As ShowWindowCommands) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    ' Gets the Item selected in the  Listbox & checks where it belongs 
    Public Function checkResult()

        Dim selectedItem As String = Form1.lbPrograms.GetItemText(Form1.lbPrograms.SelectedItem)

        If searchHandler.searchList.ContainsKey(selectedItem) Then
            searchHandler.getSearchLink(selectedItem)
        ElseIf selectedItem = "cmd" Then
            commandHandler.getCommandFunction(selectedItem)
        Else
            openApplication()
        End If
    End Function

    ' Gets the Items Value and Opens the Window
    Private Function openApplication()
        Dim hwnd As IntPtr = Form1.lbPrograms.GetItemText(Form1.lbPrograms.SelectedValue)
        ShowWindow(hwnd, 3)
        AppActivate(Form1.lbPrograms.GetItemText(Form1.lbPrograms.SelectedItem))
        listerFormHandler.HideForm()
    End Function

End Module
