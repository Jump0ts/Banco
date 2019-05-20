Public Class Cuenta
    Private nombre As String
    Private nCuenta As String
    Private correo As String
    Private saldo As Double

    Public Property _nombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property _correo As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
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
    Public Property _saldo As Double
        Get
            Return saldo
        End Get
        Set(value As Double)
            saldo = value
        End Set
    End Property
    Public Sub New(nombre As String, nCuenta As String, correo As String, saldo As Double)
        Me.nombre = nombre
        Me.nCuenta = nCuenta
        Me.correo = correo
        Me.saldo = saldo
    End Sub

    Public Sub New()
        Me.nombre = ""
    End Sub

End Class
