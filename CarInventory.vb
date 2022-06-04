'Name:          Ahmed Butt
'Last Modified: April 9, 2020
'Description:   Allows user to enter data of a car, when user clicks enter with valid data, the data is displayed on a list
'               view. If data is invalid, the result label will let the user know that the data is invalid.
Option Strict On
Public Class frmCarInventory
#Region "Variables"
    Dim selectedCar As Car
    Dim carList As New List(Of Car)
    Dim addingToListView As Boolean = False
    Dim isCarSelected As Boolean = False
    Private Shared carListInstance As frmCarInventory
    Const minComboValue As Integer = -1
    Const minValue As Integer = 0
#End Region
#Region "Event Handlers"
    ''' <summary>
    ''' Year combobox data selections created when form loads.
    ''' </summary>
    Private Sub frmCarInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Const minYear As Integer = 1920
        Const maxYear As Integer = 2020
        For i = minYear To maxYear
            cboSelectYear.Items.Add(i)
        Next
    End Sub
    ''' <summary>
    ''' Closes form.
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Clears all input controls.
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefaults()
    End Sub
    ''' <summary>
    ''' Checks if input data is valid, if not, displays error message. If data is valid, a new car entry is displayed on 
    ''' the list view.
    ''' </summary>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If isValid() = True Then
            If Not isCarSelected Then
                selectedCar = New Car(txtInputModel.Text, cboSelectMake.Text, Convert.ToInt32(cboSelectYear.Text),
                Convert.ToDecimal(txtInputPrice.Text), chkNew.Checked)
                carList.Add(selectedCar)
                SetDefaults()
            ElseIf selectedCar.IdentificationNumber.Trim.Length > minValue Then
                selectedCar.Model = txtInputModel.Text
                selectedCar.Make = cboSelectMake.Text
                selectedCar.Year = Convert.ToInt32(cboSelectYear.Text)
                selectedCar.Price = Convert.ToDecimal(txtInputPrice.Text)
                selectedCar.IsNew = chkNew.Checked
            End If
        End If
        PopulateList()
    End Sub
    ''' <summary>
    ''' Prevents user from checking a box.
    ''' </summary>
    Private Sub lvwCars_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCars.ItemCheck
        If Not addingToListView Then
            e.NewValue = e.CurrentValue
        End If
    End Sub
    ''' <summary>
    ''' Populate controls if a car is selected in the list view.
    ''' </summary>
    Private Sub lvwCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCars.SelectedIndexChanged
        If lvwCars.SelectedIndices.Count = 1 Then
            selectedCar = carList(lvwCars.SelectedIndices(0))
            isCarSelected = True
            txtInputModel.Text = selectedCar.Model
            cboSelectMake.Text = selectedCar.Make
            cboSelectYear.Text = selectedCar.Year.ToString()
            txtInputPrice.Text = selectedCar.Price.ToString()
            chkNew.Checked = selectedCar.IsNew
            lblResult.Text = selectedCar.GetCarData() 'Not sure how I'm supposed to use this, so just gonna use it like this...
        Else
            isCarSelected = False
        End If
    End Sub
#End Region
#Region "Procedures"
    ''' <summary>
    ''' Restores input controls to default.
    ''' </summary>
    Sub SetDefaults()
        txtInputModel.Clear()
        txtInputPrice.Clear()
        lblResult.Text = String.Empty
        cboSelectMake.SelectedIndex = minComboValue
        cboSelectYear.SelectedIndex = minComboValue
        chkNew.Checked = False
        txtInputModel.Focus()
    End Sub
    ''' <summary>
    ''' Clears and repopulates the car list view.
    ''' </summary>
    Sub PopulateList()
        lvwCars.Items.Clear()
        For index As Integer = 0 To carList.Count - 1
            Dim carItem As New ListViewItem()
            carItem.SubItems.Add(carList(index).IdentificationNumber.ToString())
            carItem.SubItems.Add(carList(index).Make)
            carItem.SubItems.Add(carList(index).Model)
            carItem.SubItems.Add(carList(index).Year.ToString)
            carItem.SubItems.Add(carList(index).Price.ToString("c"))
            carItem.Checked = carList(index).IsNew

            addingToListView = True
            lvwCars.Items.Add(carItem)
            addingToListView = False
        Next
    End Sub
    ''' <summary>
    ''' Validates data in each control, if data invalid displays error message, if valid, add data into list view.
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function isValid() As Boolean
        'VARIABLES
        Dim priceValue As Decimal
        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty
        'VALIDATION
        'for Model textbox
        'error message if model textbox is empty
        If txtInputModel.Text.Trim.Length = minValue Then
            outputMessage += "Please enter a model name." & vbCrLf
            returnValue = False
        End If

        'for Make combobox
        'error message if make is not selected
        If cboSelectMake.SelectedIndex = minComboValue Then
            outputMessage += "Please select a manufacturer (make)." & vbCrLf
            returnValue = False
        End If

        'for Year combobox
        'error message if year is not selected
        If cboSelectYear.SelectedIndex = minComboValue Then
            outputMessage += "Please select a year." & vbCrLf
            returnValue = False
        End If

        'for Price textbox
        If Decimal.TryParse(txtInputPrice.Text, priceValue) Then
            'error message if price is negative
            If priceValue < minValue Then
                outputMessage += "Price cannot be negative." & vbCrLf
                returnValue = False
            End If
            'error message if price textbox is empty
        ElseIf txtInputPrice.Text.Trim.Length = minValue Then
            outputMessage += "Please enter a price." & vbCrLf
            returnValue = False
            'error message if entered price not numeric
        Else
            outputMessage += "Input for price must be numeric." & vbCrLf
            returnValue = False
        End If

        'error message displays only if returnValue is false
        If returnValue = False Then
            lblResult.Text = "ERROR(S):" & vbCrLf & outputMessage
        End If
        Return returnValue
    End Function
#End Region
#Region "Form Properties"
    ''' <summary>
    ''' Returns an instance of the Car List form, only allows one form to exist.
    ''' </summary>
    ''' <returns>An instance of the Car List form</returns>
    Friend Shared ReadOnly Property Instance() As frmCarInventory
        Get
            If carListInstance Is Nothing Then
                carListInstance = New frmCarInventory
            End If
            Return carListInstance
        End Get
    End Property
#End Region
End Class