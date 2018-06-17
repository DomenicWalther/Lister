Module listerFormHandler

    'Hides the Form & resets it to it's Standard Form
    Public Function HideForm()
        Form1.Hide()
        Form1.txtFilter.Clear()
        taskManagerPrograms.dtPrograms.Reset()
        listBoxFilter.DvPrograms.RowFilter = ""
        Form1.lbPrograms.DataSource = Nothing
        Form1.lbPrograms.Items.Clear()
    End Function

    'Shows the Form & updates the Listbox with Programs & other Functions
    Public Function ShowForm()
        Form1.Show()
        taskManagerPrograms.GetPrograms()
        listBoxFilter.updateFilter()
        Form1.txtFilter.Focus()
        AppActivate("Lister")
    End Function


    ' Single-line textbox height is set by the size of the font, not the TextBox.Height property.
    ' The calculation the textbox uses to determine its height is:
    ' Height = ( Font Size * Font line Spacing / Font Em Height ) + 7
    ' We can reverse this calculation to obtain the font size needed for a desired height:
    ' Font Size = ( height - 7 ) * Font Em Height / Font Line Spacing
    ' This function will return a font object that will set the size of your textbox
    Public Function GetFontForTextBoxHeight(TextBoxHeight As Integer, OriginalFont As Font)

        Dim DesiredHeight = TextBoxHeight

        Dim TextFont As Font = New Font(OriginalFont.FontFamily,
OriginalFont.Size,
OriginalFont.Style,
GraphicsUnit.Pixel)

        If DesiredHeight < 8 Then
            DesiredHeight = 8
        End If

        Dim FontEmSize As Long = TextFont.FontFamily.GetEmHeight(TextFont.Style)
        Dim FontLineSpacing As Long = TextFont.FontFamily.GetLineSpacing(TextFont.Style)

        Dim EmSize As Long = (DesiredHeight - 7) * FontEmSize / FontLineSpacing

        TextFont = New Font(TextFont.FontFamily, EmSize, TextFont.Style, GraphicsUnit.Pixel)

        Return TextFont
    End Function
End Module
