'Name:          Ahmed Butt
'Last Modified: April 9, 2020
'Description:   This is a class that represents a car.
Option Strict On
Public Class Car
    Private Shared carCount As Integer
    Private carIdentificationNumber As String = String.Empty
    Private carModel As String = String.Empty
    Private carMake As String = String.Empty
    Private carYear As Integer
    Private carPrice As Decimal
    Private carNewStatus As Boolean = False
    ''' <summary>
    ''' Default Constructor - Increment car count, set current car's identification number.
    ''' </summary>
    Public Sub New()
        carCount += 1
        carIdentificationNumber = carCount.ToString
    End Sub
    ''' <summary>
    ''' Parameterized Constructor - Calls default contructor, private variables set using values passed into parameters.
    ''' </summary>
    ''' <param name="modelValue"></param>
    ''' <param name="makeValue"></param>
    ''' <param name="yearValue"></param>
    ''' <param name="priceValue"></param>
    ''' <param name="statusValue"></param>
    Public Sub New(modelValue As String, makeValue As String, yearValue As Integer, priceValue As Decimal, statusValue As Boolean)
        Me.New
        carModel = modelValue
        carMake = makeValue
        carYear = yearValue
        carPrice = priceValue
        carNewStatus = statusValue
    End Sub
    ''' <summary>
    ''' Gets the number of cars that have been created.
    ''' </summary>
    ''' <returns>Integer</returns>
    Public Shared ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property
    ''' <summary>
    ''' Gets the specific car identification number.
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property IdentificationNumber() As String
        Get
            Return carIdentificationNumber
        End Get
    End Property
    ''' <summary>
    ''' Gets and sets the model name of a car.
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property
    ''' <summary>
    ''' Gets and sets the manufacturer name of a car.
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property
    ''' <summary>
    ''' Gets and sets the year that the car was manufactured.
    ''' </summary>
    ''' <returns>Integer</returns>
    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property
    ''' <summary>
    ''' Gets and sets the price of a car.
    ''' </summary>
    ''' <returns>Decimal</returns>
    Public Property Price() As Decimal
        Get
            Return carPrice
        End Get
        Set(value As Decimal)
            carPrice = value
        End Set
    End Property
    ''' <summary>
    ''' Gets and sets the used status of a car.
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property IsNew As Boolean
        Get
            Return carNewStatus
        End Get
        Set(ByVal value As Boolean)
            carNewStatus = value
        End Set
    End Property
    ''' <summary>
    ''' Method - A string that represents the car's data.
    ''' </summary>
    ''' <returns></returns>
    Public Function GetCarData() As String
        Return "Model: " & carModel & vbCrLf & "Make: " & carMake & vbCrLf & "Year: " & carYear & vbCrLf & "Price: $" & carPrice & vbCrLf &
               "Used: " & IIf(carNewStatus = True, "Yes", "No").ToString()
    End Function
End Class


