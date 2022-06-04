'Name:          Ahmed Butt
'Last Modified: April 9, 2020
'Description:   This is a multi-text editor. It allows the user to edit text in various new windows. It can also maintain a 
'               list of cars.
Option Strict On
Imports System.IO
Public Class frmMain
#Region "Variables"
    Dim filePath As String = String.Empty 'stores the path of the file
    Dim totalEditors As Integer = 0
#End Region
#Region "mnuFile Event Handlers"
    ''' <summary>
    ''' Creates a new text editor form and opens it.
    ''' </summary>
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuStripFileNew.Click, btnNew.Click
        Dim newTextEditor As New frmTextEditor
        newTextEditor.MdiParent = Me
        newTextEditor.Show()
        totalEditors += 1
        newTextEditor.Text = "Text Editor " + totalEditors.ToString() + " - New"
        mnuStripEdit.PerformClick()
    End Sub
    ''' <summary>
    ''' Allows a user to select a text file to open. The contents of the text file is opened in a new text editor.
    ''' </summary>
    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuStripFileOpen.Click, btnOpen.Click
        Dim newTextEditor As New frmTextEditor
        Dim openFile As FileStream
        Dim fileReader As StreamReader
        opdOpen.Title = "Open"
        opdOpen.InitialDirectory = "C:temp"
        If opdOpen.ShowDialog() = DialogResult.OK Then
            newTextEditor.MdiParent = Me
            newTextEditor.Show()
            totalEditors += 1
            openFile = New FileStream(opdOpen.FileName, FileMode.Open, FileAccess.Read)
            fileReader = New StreamReader(openFile)
            newTextEditor.txtEditor.Text = fileReader.ReadToEnd()
            newTextEditor.OldFileValue() 'this is to help ConfirmClose()
            openFile.Close()
            fileReader.Close()
            filePath = Path.GetFullPath(opdOpen.FileName)
            newTextEditor.Text = "Text Editor " + totalEditors.ToString() + " - " + filePath
        End If
    End Sub
    ''' <summary>
    ''' Saves the file by calling SaveFile() method in frmTextEditor.
    ''' </summary>
    Private Sub mnuStripFileSave_Click(sender As Object, e As EventArgs) Handles mnuStripFileSave.Click, btnSave.Click
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).SaveFile()
        Else
            MessageBox.Show("Cannot save currently active window.")
        End If
    End Sub
    ''' <summary>
    ''' Always saves the file in a chosen location with a chosen name by calling SaveFileAs() method in frmTextEditor.
    ''' </summary>
    Private Sub mnuStripFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuStripFileSaveAs.Click
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).SaveFileAs()
        Else
            MessageBox.Show("Cannot save currently active window.")
        End If
    End Sub
    ''' <summary>
    ''' Closes currently active (focused) MDI child. If no MDI child is open, prompt to close application.
    ''' </summary>
    Private Sub mnuStripFileClose_Click(sender As Object, e As EventArgs) Handles mnuStripFileClose.Click
        If MdiChildren.Count > 0 Then
            If TypeOf (ActiveMdiChild) Is frmTextEditor Then
                CType(ActiveMdiChild, frmTextEditor).ConfirmClose()
            End If
            ActiveMdiChild.Close()
        Else
            If MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    ''' <summary>
    ''' If there are no MDI children open, just closes the main form. If there are, ConfirmClose()'s all MDI children that
    ''' are text editors.
    ''' </summary>
    Private Sub mnuStripFileExit_Click(sender As Object, e As EventArgs) Handles mnuStripFileExit.Click
        For start As Integer = 0 To MdiChildren.Count
            If MdiChildren.Count > 0 Then
                If TypeOf (ActiveMdiChild) Is frmTextEditor Then
                    CType(ActiveMdiChild, frmTextEditor).ConfirmClose()
                End If
                ActiveMdiChild.Close()
            End If
        Next
        Me.Close()
    End Sub
#End Region
#Region "mnuEdit Event Handlers"
    ''' <summary>
    ''' Cuts text by calling CutText() method in frmTextEditor.
    ''' </summary>
    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuStripEditCut.Click
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).CutText()
        Else
            MessageBox.Show("Cannot use this feature in currently active window.")
        End If
    End Sub
    ''' <summary>
    ''' Copies text by calling CopyText() method in frmTextEditor.
    ''' </summary>
    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuStripEditCopy.Click
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).CopyText()
        Else
            MessageBox.Show("Cannot use this feature in currently active window.")
        End If
    End Sub
    ''' <summary>
    ''' Pastes text by calling PasteText() method in frmTextEditor.
    ''' </summary>
    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuStripEditPaste.Click
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            CType(ActiveMdiChild, frmTextEditor).PasteText()
        Else
            MessageBox.Show("Cannot use this feature in currently active window.")
        End If
    End Sub
#End Region
#Region "mnuWindows Event Handlers"
    ''' <summary>
    ''' Change to cascade view.
    ''' </summary>
    Private Sub mnuWindowsCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowsCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
    ''' <summary>
    ''' Change to vertical view.
    ''' </summary>
    Private Sub mnuWindowsTileVertical_Click(sender As Object, e As EventArgs) Handles mnuWindowsTileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    ''' <summary>
    ''' Change to horizontal view.
    ''' </summary>
    Private Sub mnuWindowsTileHorizontal_Click(sender As Object, e As EventArgs) Handles mnuWindowsTileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    ''' <summary>
    ''' Opens car list form. If one is already open, just sets focus to the opened one.
    ''' </summary>
    Private Sub mnuWindowsOpenCarList_Click(sender As Object, e As EventArgs) Handles mnuWindowsOpenCarList.Click, btnCarList.Click
        Dim myCarList As frmCarInventory = frmCarInventory.Instance
        myCarList.MdiParent = Me
        myCarList.Show()
        myCarList.Focus()
    End Sub
    ''' <summary>
    ''' Opens average units form. If one is already open, just sets focus to the opened one.
    ''' </summary>
    Private Sub mnuWindowsOpenAverageUnits_Click(sender As Object, e As EventArgs) Handles mnuWindowsOpenAverageUnits.Click, btnUnitsShipped.Click
        Dim myUnitsShipped As frmUnitsShipped = frmUnitsShipped.Instance
        myUnitsShipped.MdiParent = Me
        myUnitsShipped.Show()
        myUnitsShipped.Focus()
    End Sub
#End Region
#Region "mnuHelp Event Hanlder"
    ''' <summary>
    ''' MessageBox pops up when user clicks About button. The MessageBox shows lab information.
    ''' </summary>
    Private Sub mnuStripHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuStripHelpAbout.Click
        MessageBox.Show("NETD-2202" & vbCrLf & "Lab#6 - Multi-Text Editor" & vbCrLf & "Ahmed Butt", "About")
    End Sub
#End Region
End Class
