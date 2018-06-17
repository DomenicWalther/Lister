Imports System.IO

Module searchHandler
    Public searchList As New Dictionary(Of String, String)

    'Loads the List of Websites for the Search Function
    Public Function getSearchList()

        Dim searchXML As XElement = XElement.Load("Root.xml", LoadOptions.PreserveWhitespace)

        For Each el As XElement In searchXML.Elements
            searchList.Add(el.Name.LocalName, el.Value)
        Next
    End Function

    ' Saves the Search List to an xml File
    Private Function saveSearchList()
        Dim root As XElement =
            <Root>
                <%= From keyValue In searchList
                    Select New XElement(keyValue.Key, keyValue.Value) %>
            </Root>

        root.Save("Root.xml")
    End Function

    ' Adds a key to the Search List
    Public Function addSearchList(key As String, value As String)
        Try
            If value.Contains("https://www.") Then
                searchList.Add(key, value)
                saveSearchList()
                listerFormHandler.HideForm()
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
    Public Function removeSearchList(key As String)
        If searchList.ContainsKey(key) Then
            searchList.Remove(key)
            saveSearchList()
            listerFormHandler.HideForm()
            listerFormHandler.ShowForm()
        Else
            MessageBox.Show("This Key doesn't exist!")
        End If

    End Function

    ' Uses the SelectedItem in the Listbox as Key to get the Link of the Website
    Public Function getSearchLink(selectedItem As String)
        Dim searchLink As String = searchList.Item(selectedItem)
        doSearch(searchLink, selectedItem)
    End Function

    ' Gets the search parameters, removes the command and then opens the link in the webbrowser
    Public Function doSearch(link As String, item As String)
        Dim txtFilter = Form1.txtFilter.Text
        Dim itemLength As Integer = item.Length()
        Dim searchQuery As String = txtFilter.Remove(0, itemLength + 1)
        Process.Start(link + searchQuery)
        listerFormHandler.HideForm()
    End Function
End Module
