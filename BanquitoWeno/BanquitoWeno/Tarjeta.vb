Public Class Tarjeta
    Private pin As Integer
    Private nombre As String
    Private nCuenta As String

    Public Property _nombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property _nCuenta As String
        Get
            Return nCuenta
        End Get
        Set(value As String)
            nCuenta = value
        End Set
    End Property
    Public Property _pin As Integer
        Get
            Return pin
        End Get
        Set(value As Integer)
            pin = value
        End Set
    End Property
    Public Sub New(pin As Integer, nombre As String, nCuenta As String)
        Me.pin = pin
        Me.nombre = nombre
        Me.nCuenta = nCuenta
    End Sub
    Public Sub New()
        Me.nombre = ""
    End Sub

    Public Function cambiarPin(pinA As Integer, pinN As Integer, pinN2 As Integer) As String
        If (pinA <> Me.pin) Then
            Return "Has introducido mal el pin actual."
        ElseIf (pinN <> pinN2) Then
            Return "Los pines nuevos no se corresponden."
        Else
            Me.pin = pinN
            Return "Pin cambiado correctamente."
        End If
    End Function
End Class
