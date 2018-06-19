Module listBoxFilter
    Public DvPrograms As New DataView

    ' Checks the typed in command and filters it accordingly 
    Public Function UpdateFilter()


        DvPrograms = DtPrograms.DefaultView

        Dim filterText As String = Form1.txtFilter.Text.Split(" "c)(0)

        If SearchList.ContainsKey(filterText) Or filterText = "cmd" Then
            DvPrograms.RowFilter = "Programs LIKE '%" + filterText + "'"
        Else
            DvPrograms.RowFilter = "Programs LIKE '%" + Form1.txtFilter.Text + "%'"

        End If

        ' Sets the Forms height equal to the Height of the Listbox. If the Filter is empty it defaults to 100 - the height of the textbox
        If Form1.txtFilter.TextLength > 0 Then
            Form1.lbPrograms.Height = Form1.lbPrograms.PreferredSize.Height
            Dim listBoxHeight As Integer = Form1.lbPrograms.Height
            Form1.Size = New Size(800, 100 + listBoxHeight)
        Else
            Form1.Size = New Size(800, 100)

        End If
    End Function
End Module

