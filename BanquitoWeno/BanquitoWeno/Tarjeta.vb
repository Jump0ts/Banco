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
End Class
