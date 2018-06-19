Module SearchHandler
    Public SearchList As New Dictionary(Of String, String)

    'Loads the List of Websites for the Search Function
    Public Function GetSearchList()

        Dim searchXml As XElement = XElement.Load("Root.xml", LoadOptions.PreserveWhitespace)

        For Each el As XElement In searchXml.Elements
            SearchList.Add(el.Name.LocalName, el.Value)
        Next
    End Function

    ' Saves the Search List to an xml File
    Private Function SaveSearchList()
        Dim root As XElement =
                <Root>
                    <%= From keyValue In SearchList
                        Select New XElement(keyValue.Key, keyValue.Value) %>
                </Root>

        root.Save("Root.xml")
    End Function

    ' Adds a key to the Search List
    Public Function AddKeyValuePairToSearchList(key As String, value As String)
        Try
            If value.Contains("https://www.") Then
                SearchList.Add(key, value)
                SaveSearchList()
                HideForm()
            Else
                MessageBox.Show("The Link must contain https://www.")
            End If
        Catch ex As ArgumentException
            MessageBox.Show(key + " already exists!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    ' Removes a specific key from the Search List 
    Public Function RemoveKeyFromSearchList(key As String)
        If SearchList.ContainsKey(key) Then
            SearchList.Remove(key)
            SaveSearchList()
            HideForm()
            ShowForm()
        Else
            MessageBox.Show("This Key doesn't exist!")
        End If
    End Function

    ' Uses the SelectedItem in the Listbox as Key to get the Link of the Website
    Public Function GetSearchLink(selectedItem As String)
        Dim searchLink As String = SearchList.Item(selectedItem)
        RunSearch(searchLink, selectedItem)
    End Function

    ' Gets the search parameters, removes the command and then opens the link in the webbrowser
    Public Function RunSearch(link As String, item As String)
        Dim txtFilter = Form1.txtFilter.Text
        Dim itemLength As Integer = item.Length()
        Dim searchQuery As String = txtFilter.Remove(0, itemLength + 1)
        Process.Start(link + searchQuery)
        HideForm()
    End Function
End Module
