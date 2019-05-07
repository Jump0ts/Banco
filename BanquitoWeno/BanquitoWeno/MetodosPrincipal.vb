Public Class MetodosPrincipal
    Private Shared cuenta As Cuenta

    Public Sub New(nCuenta As String)
        cuenta = Controlador.obtenerCuenta(nCuenta)
        'lanzarPantalla()
    End Sub

    Public Shared Sub lanzarPantalla(nCuenta As String)
        cuenta = Controlador.obtenerCuenta(nCuenta)
        Principal.Visible = True
        Login.Visible = False
    End Sub
    Public Property _cuenta As Cuenta
        Get
            Return cuenta
        End Get
        Set(value As Cuenta)
            cuenta = value
        End Set
    End Property

End Class
