Imports System.Runtime.InteropServices

Public Module hotkeys

    <DllImport("user32.dll")>
    Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Short
    End Function

    Const KeyDownBit As Integer = &H8000

    ' Defines the KeyDown Events from the Form1 Elements
    Public WithEvents keyDown1 As ListBox = Form1.lbPrograms
    Public WithEvents keyDown2 As TextBox = Form1.txtFilter

    Public Function checkHotkeys() As Boolean

        If (GetAsyncKeyState(Keys.LWin) And KeyDownBit) = KeyDownBit AndAlso (GetAsyncKeyState(Keys.O) And KeyDownBit) = KeyDownBit Then
            If Form1.Visible Then
                AppActivate("Lister")
            Else
                listerFormHandler.ShowForm()
            End If


        ElseIf (GetAsyncKeyState(Keys.Escape) And KeyDownBit) = KeyDownBit Then
            listerFormHandler.HideForm()
        End If

    End Function

    Private Sub keyDown1_keyDown(sender As Object, e As KeyEventArgs) Handles keyDown1.KeyDown, keyDown2.KeyDown
        If e.KeyCode = Keys.Enter And Form1.lbPrograms.GetItemText(Form1.lbPrograms.SelectedItem) <> "" Then
            applicationHandler.checkResult()
        End If
    End Sub


End Module
