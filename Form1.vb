

Public Class Form1
    Private ReadOnly ListerFormHeight As Integer = 100

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Timer1.Enabled = True
        Timer1.Interval = 1
        GetSearchList()
        GetPrograms()
        txtFilter.Focus()
        txtFilter.Font = GetFontForTextBoxHeight(ListerFormHeight, txtFilter.Font)
    End Sub

    Public Function OpenApplication()
        Dim hwnd As IntPtr = lbPrograms.GetItemText(lbPrograms.SelectedValue)
        ShowWindow(hwnd, 3)
        AppActivate(lbPrograms.GetItemText(lbPrograms.SelectedItem))
        HideForm()
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CheckHotkeys()
    End Sub

    Private Sub TxtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        UpdateFilter()
    End Sub
End Class
