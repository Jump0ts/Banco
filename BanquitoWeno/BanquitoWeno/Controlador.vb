Public Class Controlador
    Private Shared cuentas As Cuenta() = {New Cuenta("Pepe", "A165", "sdzg", 1523), New Cuenta("Antonio", "A984", "fj", 753),
                                   New Cuenta("Comeme", "A465", "sdth", 645654632), New Cuenta("LosWevo", "A654", "dfgb", 654)}
    Private Shared tarjetas As Tarjeta() = {New Tarjeta(1234, "Pepe", "A165"), New Tarjeta(1234, "Antonio", "A984"),
                                    New Tarjeta(9645, "Comeme", "A465"), New Tarjeta(9645, "LosWevo", "A654")}
    Public Shared Function iniciaSesion(nombre As String, pin As Integer) As String
        For cont As Integer = 0 To tarjetas.Length - 1 Step 1
            If nombre = tarjetas(cont)._nombre And pin = tarjetas(cont)._pin Then
                Return tarjetas(cont)._nCuenta
            End If
        Next
        Return ""
    End Function

    Public Shared Function obtenerCuenta(cuenta As String) As Cuenta
        For cont As Integer = 0 To cuentas.Length Step 1
            If cuenta = cuentas(cont)._nCuenta Then
                Return cuentas(cont)
            End If
        Next
    End Function
    

End Class
