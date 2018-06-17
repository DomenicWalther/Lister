Imports System.Runtime.InteropServices

Module applicationHandler
    ' Imports the ShowWindow Library
    <DllImport("user32.dll", SetLastError:=True)>
    Public Function ShowWindow(hWnd As IntPtr, <MarshalAs(UnmanagedType.I4)> nCmdShow As ShowWindowCommands) _
        As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    ' Gets the Item selected in the  Listbox & checks where it belongs 
    Public Function CheckResult()

        Dim selectedItem As String = Form1.lbPrograms.GetItemText(Form1.lbPrograms.SelectedItem)

        If SearchHandler.SearchList.ContainsKey(selectedItem) Then
            SearchHandler.GetSearchLink(selectedItem)
        ElseIf selectedItem = "cmd" Then
            CommandHandler.GetCommandFunction(selectedItem)
        Else
            OpenApplication()
        End If
    End Function

    ' Gets the Items Value and Opens the Window
    Private Function OpenApplication()
        Dim hwnd As IntPtr = Form1.lbPrograms.GetItemText(Form1.lbPrograms.SelectedValue)
        ShowWindow(hwnd, 3)
        AppActivate(Form1.lbPrograms.GetItemText(Form1.lbPrograms.SelectedItem))
        listerFormHandler.HideForm()
    End Function
End Module

