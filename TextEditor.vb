'Name:          Ahmed Butt
'Last Modified: April 9, 2020
'Description:   Allows user to edit text. Text files can be opened and saved.
Option Strict On
Imports System.IO
Public Class frmTextEditor
#Region "Variables"
    Dim selectedText As String = String.Empty 'for editing
    Dim filePath As String = String.Empty 'stores the path of the file
    Dim oldFile As String = String.Empty 'stores unchanged text of textbox/file
    Dim newFile As String = String.Empty 'stores changed text of textbox/file
#End Region
#Region "Event Handlers"
    ''' <summary>
    ''' Stores the text of the textbox into the variable newFile, whenever text is changed.
    ''' </summary>
    Private Sub txtEditor_TextChanged(sender As Object, e As EventArgs) Handles txtEditor.TextChanged
        newFile = txtEditor.Text
    End Sub
#End Region
#Region "Methods"
    ''' <summary>
    ''' Allows user to save file when clicked. Calls SaveTextFile() method, giving it a file path.
    ''' </summary>
    Friend Sub SaveFile()
        sfdSaveAs.Filter = "TXT Files (*.txt*)|*.txt"
        If filePath = String.Empty Then
            If sfdSaveAs.ShowDialog() = DialogResult.OK Then
                filePath = sfdSaveAs.FileName
                SaveTextFile(filePath)
            End If
        Else
            SaveTextFile(filePath)
        End If
    End Sub
    ''' <summary>
    ''' Allows user to create a new file in selected location, or overwrite an existing file. Calls SaveTextFile() method,
    ''' giving it a file path.
    ''' </summary>
    Friend Sub SaveFileAs()
        sfdSaveAs.Filter = "TXT Files (*.txt*)|*.txt"
        If sfdSaveAs.ShowDialog() = DialogResult.OK Then
            filePath = sfdSaveAs.FileName
            SaveTextFile(filePath)
        End If
    End Sub
    ''' <summary>
    ''' Saves the text file using a known file path.
    ''' </summary>
    ''' <param name="path"></param>
    Friend Sub SaveTextFile(path As String)
        Dim saveFile As FileStream
        Dim fileWriter As StreamWriter
        saveFile = New FileStream(path, FileMode.Create, FileAccess.Write)
        fileWriter = New StreamWriter(saveFile)
        fileWriter.Write(txtEditor.Text)
        fileWriter.Close()
        saveFile.Close()
    End Sub
    ''' <summary>
    ''' Stores user selected text into clipboard.
    ''' </summary>
    Friend Sub CopyText()
        selectedText = txtEditor.SelectedText
        If selectedText <> String.Empty Then 'checks if text is selected
            My.Computer.Clipboard.SetText(selectedText)
        End If
    End Sub
    ''' <summary>
    ''' Stores user selected text into clipboard and removes it from the textbox.
    ''' </summary>
    Friend Sub CutText()
        CopyText()
        txtEditor.SelectedText = String.Empty
    End Sub
    ''' <summary>
    ''' Sets copied text into user selected area.
    ''' </summary>
    Friend Sub PasteText()
        txtEditor.SelectedText = My.Computer.Clipboard.GetText()
    End Sub
    ''' <summary>
    ''' Asks user if they want to save the current file that was changed.
    ''' </summary>
    Friend Sub ConfirmClose()
        If oldFile <> newFile Then 'checks if oldFile and newFile match, if they do, it means file wasn't changed
            If MsgBox("Would you like to save " + frmMain.ActiveMdiChild.Text + "?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                If sfdSaveAs.ShowDialog() = DialogResult.OK Then
                    filePath = sfdSaveAs.FileName
                    SaveTextFile(filePath)
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' Gives oldFile a value taken from frmMain when a file is opened.
    ''' </summary>
    Friend Sub OldFileValue()
        oldFile = txtEditor.Text
    End Sub
#End Region
End Class