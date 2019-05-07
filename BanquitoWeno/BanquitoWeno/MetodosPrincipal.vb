Public Class MetodosPrincipal
    Private Shared cuenta As Cuenta

    Public Sub New(nCuenta As String)
        cuenta = Controlador.obtenerCuenta(nCuenta)
        'lanzarPantalla()
    End Sub

    Public Shared Sub lanzarPantalla(nCuenta As String)
        cuenta = Controlador.obtenerCuenta(nCuenta)
        Principal.Show()
        Login.Close()
    End Sub
    Public Shared Property _cuenta As Cuenta
        Get
            Return cuenta
        End Get
        Set(value As Cuenta)
            cuenta = value
        End Set
    End Property

End Class
