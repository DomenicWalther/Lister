Imports System.Runtime.InteropServices

Public Class Form1

    Private ListerFormHeight As Integer = 100

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        Timer1.Enabled = True
        Timer1.Interval = 1
        searchHandler.GetSearchList()
        taskManagerPrograms.GetPrograms()
        txtFilter.Focus()
        txtFilter.Font = listerFormHandler.GetFontForTextBoxHeight(ListerFormHeight, txtFilter.Font)
    End Sub

    Public Function OpenApplication()
        Dim hwnd As IntPtr = lbPrograms.GetItemText(lbPrograms.SelectedValue)
        ShowWindow(hwnd, 3)
        AppActivate(lbPrograms.GetItemText(lbPrograms.SelectedItem))
        HideForm()

    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        hotkeys.CheckHotkeys()
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        listBoxFilter.updateFilter()
    End Sub



End Class
