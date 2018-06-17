Module listerFormHandler
    'Hides the Form & resets it to it's Standard Form
    Public Function HideForm()
        Form1.Hide()
        Form1.txtFilter.Clear()
        dtPrograms.Reset()
        DvPrograms.RowFilter = ""
        Form1.lbPrograms.DataSource = Nothing
        Form1.lbPrograms.Items.Clear()
    End Function

    'Shows the Form & updates the Listbox with Programs & other Functions
    Public Function ShowForm()
        Form1.Show()
        GetPrograms()
        UpdateFilter()
        Form1.txtFilter.Focus()
        AppActivate("Lister")
    End Function


    ' Single-line textbox height is set by the size of the font, not the TextBox.Height property.
    ' The calculation the textbox uses to determine its height is:
    ' Height = ( Font Size * Font line Spacing / Font Em Height ) + 7
    ' We can reverse this calculation to obtain the font size needed for a desired height:
    ' Font Size = ( height - 7 ) * Font Em Height / Font Line Spacing
    ' This function will return a font object that will set the size of your textbox
    Public Function GetFontForTextBoxHeight(textBoxHeight As Integer, OriginalFont As Font)

        Dim desiredHeight = textBoxHeight

        Dim textFont = New Font(OriginalFont.FontFamily,
                                OriginalFont.Size,
                                OriginalFont.Style,
                                GraphicsUnit.Pixel)

        If desiredHeight < 8 Then
            desiredHeight = 8
        End If

        Dim FontEmSize As Long = textFont.FontFamily.GetEmHeight(textFont.Style)
        Dim FontLineSpacing As Long = textFont.FontFamily.GetLineSpacing(textFont.Style)

        Dim EmSize As Long = (desiredHeight - 7) * FontEmSize / FontLineSpacing

        textFont = New Font(textFont.FontFamily, EmSize, textFont.Style, GraphicsUnit.Pixel)

        Return textFont
    End Function
End Module

