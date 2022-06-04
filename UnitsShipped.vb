'Name:          Ahmed Butt
'Last Modified: April 9, 2020
'Description:   Displays the shipping average of 3 employees in a week. Also displays total average shipped.
Option Strict On
Public Class frmUnitsShipped
#Region "Variables"
    'Current day/employee
    Dim day As Integer = 0
    Dim employee As Integer = 0
    'Totals
    Dim employeeTotalShipped As Integer
    Dim overallTotalShipped As Integer
    'Array of textboxes/labels
    Dim textboxArray As TextBox()
    Dim labelBoxArray As Label()
    'Array that stores unit input
    Dim unitsArray(2, 6) As Integer
    'Averages
    Dim employeeAverage As Double
    Dim overallAverage As Double
    'Instance
    Private Shared unitsShippedInstance As frmUnitsShipped
#End Region
#Region "Event Handlers"
    ''' <summary>
    ''' Create an array of textboxes and an array of labels when form loads.
    ''' </summary>
    Private Sub frmUnitsShipped_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textboxArray = {txtEmployee1List, txtEmployee2List, txtEmployee3List}
        labelBoxArray = {lblAverageDisplay1, lblAverageDisplay2, lblAverageDisplay3}
    End Sub
    ''' <summary>
    ''' It's literally just exit.
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' Reset to defaults by calling SetDefaults()
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefaults()
    End Sub
    ''' <summary>
    ''' Save entry in a multiline textbox. If max days reaches, show average. If max employees reached, show total average.
    ''' </summary>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Const minUnits As Integer = 0
        Const maxUnits As Integer = 5000
        Const maxDays As Integer = 7
        Const maxEmployees As Integer = 3

        txtUnitInput.Focus()
        'Checks if user input is valid
        If Integer.TryParse(txtUnitInput.Text, unitsArray(employee, day)) And unitsArray(employee, day) >= minUnits And unitsArray(employee, day) <= maxUnits Then
            'If input valid, display entry in a multiline textbox
            textboxArray(employee).Text &= unitsArray(employee, day) & vbCrLf
            day += 1
            lblDay.Text = "Day " & (day + 1)
            txtUnitInput.Clear()
            'If day increment reaches 7, calculate and display average for the current employee
            If day = maxDays Then
                employeeTotalShipped = 0
                For dayCounter As Integer = 0 To maxDays - 1
                    employeeTotalShipped += unitsArray(employee, dayCounter)
                Next
                employeeAverage = employeeTotalShipped / maxDays
                labelBoxArray(employee).Text = "Average: " & Math.Round(employeeAverage, 2)
                'Move on to next employee and reset day to 1
                employee += 1
                day = 0
                lblDay.Text = "Day " & (day + 1)
                'If max number of employees reached, calculate and display the total average
                If employee = maxEmployees Then
                    For Each day In unitsArray
                        overallTotalShipped += day
                    Next
                    overallAverage = overallTotalShipped / unitsArray.Length
                    lblOverallAverage.Text = "Average per day: " & Math.Round(overallAverage, 2)
                    txtUnitInput.Enabled = False
                    btnEnter.Enabled = False
                    btnReset.Focus()
                    lblDay.Text = "Done"
                End If
            End If
        Else
            'If input invalid, error message
            MessageBox.Show("Units must be entered as a whole number between 0 and 5000.")
            txtUnitInput.SelectAll()
            txtUnitInput.Focus()
        End If
    End Sub
    ''' <summary>
    ''' Restores the default properties of the form.
    ''' </summary>
    Sub SetDefaults()
        day = 0
        employee = 0
        employeeTotalShipped = 0
        overallTotalShipped = 0
        lblDay.Text = "Day " & (day + 1)

        txtUnitInput.Clear()
        txtEmployee1List.Clear()
        txtEmployee2List.Clear()
        txtEmployee3List.Clear()

        lblOverallAverage.Text = String.Empty
        lblAverageDisplay1.Text = String.Empty
        lblAverageDisplay2.Text = String.Empty
        lblAverageDisplay3.Text = String.Empty

        txtUnitInput.Enabled = True
        btnEnter.Enabled = True

        txtUnitInput.Focus()
    End Sub
    ''' <summary>
    ''' Setting a hotkey for the textbox like this because I don't know if there's a better way to do it.
    ''' </summary>
    Private Sub UnitsShipped_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If Control.ModifierKeys = Keys.Alt Then
            If e.KeyCode = Keys.A Then
                txtUnitInput.Focus()
            End If
        End If
    End Sub
#End Region
#Region "Form Properties"
    ''' <summary>
    ''' Returns an instance of the Units Shipped form, only allows one form to exist.
    ''' </summary>
    ''' <returns>An instance of the Car List form</returns>
    Friend Shared ReadOnly Property Instance() As frmUnitsShipped
        Get
            If unitsShippedInstance Is Nothing Then
                unitsShippedInstance = New frmUnitsShipped
            End If
            Return unitsShippedInstance
        End Get
    End Property
#End Region
End Class