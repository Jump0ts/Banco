Public Class MetodosPrincipal
    Private Shared cuenta As Cuenta
    Private Shared tarjeta As Tarjeta

    Public Shared Sub lanzarPantalla(tarjetaa As Tarjeta)
        tarjeta = tarjetaa
        cuenta = Controlador.obtenerCuenta(tarjeta._nCuenta)
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
    Public Shared Property _tarjeta As Tarjeta
        Get
            Return tarjeta
        End Get
        Set(value As Tarjeta)
            tarjeta = value
        End Set
    End Property
End Class
