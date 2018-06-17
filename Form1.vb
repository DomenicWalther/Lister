Imports System.Runtime.InteropServices

Public Class Form1

    Private listerFormHeight As Integer = 100

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        Timer1.Enabled = True
        Timer1.Interval = 1
        searchHandler.getSearchList()
        taskManagerPrograms.GetPrograms()
        txtFilter.Focus()
        txtFilter.Font = listerFormHandler.GetFontForTextBoxHeight(listerFormHeight, txtFilter.Font)

        Dim settingsForm As Settings
        settingsForm = New Settings()
        settingsForm.Show()
    End Sub

    Public Function openApplication()
        Dim hwnd As IntPtr = lbPrograms.GetItemText(lbPrograms.SelectedValue)
        ShowWindow(hwnd, 3)
        AppActivate(lbPrograms.GetItemText(lbPrograms.SelectedItem))
        hideForm()

    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        hotkeys.checkHotkeys()
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        listBoxFilter.updateFilter()
    End Sub



End Class
