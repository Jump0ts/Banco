Public Class Controlador
    Private Shared cuentas As Cuenta() = {New Cuenta("Pepe", "A165", "sdzg", 1523), New Cuenta("Antonio", "A984", "fj", 753),
                                   New Cuenta("Comeme", "A465", "sdth", 645654632), New Cuenta("LosWevo", "A654", "dfgb", 654)}
    Private Shared tarjetas As Tarjeta() = {New Tarjeta(1234, "Pepe", "A165"), New Tarjeta(1234, "Antonio", "A984"),
                                    New Tarjeta(9645, "Comeme", "A465"), New Tarjeta(9645, "LosWevo", "A654")}
    Public Shared Function iniciaSesion(nombre As String, pin As Integer) As Tarjeta
        For cont As Integer = 0 To tarjetas.Length - 1 Step 1
            If nombre = tarjetas(cont)._nombre And pin = tarjetas(cont)._pin Then
                Return tarjetas(cont)
            End If
        Next
        Return New Tarjeta()
    End Function

    Public Shared Function obtenerCuenta(cuenta As String) As Cuenta
        For cont As Integer = 0 To cuentas.Length - 1 Step 1
            If cuenta = cuentas(cont)._nCuenta Then
                Return cuentas(cont)
            End If
        Next
        Return New Cuenta()
    End Function
    Public Shared Sub compTecla(e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Shared Function sacarDinero(cant As Double, cuenta As String) As String
        If (obtenerCuenta(cuenta)._saldo >= cant) Then
            obtenerCuenta(cuenta)._saldo = obtenerCuenta(cuenta)._saldo - cant
            Return "Transacción completada."
        Else
            Return "Imposible realizar la transacción requerida."
        End If
    End Function
    Public Shared Function ingresarDinero(cant As Double, cuenta As String) As String
            obtenerCuenta(cuenta)._saldo = obtenerCuenta(cuenta)._saldo + cant
            Return "Transacción completada."
    End Function
    Public Shared Function transferencia(cant As Double, cuentaP As String, cuentaRe As String) As String
        If (obtenerCuenta(cuentaRe)._nombre = "") Then
            Return "Número de cuenta errónea."
        ElseIf (obtenerCuenta(cuentaP)._saldo >= cant) Then
            obtenerCuenta(cuentaP)._saldo = obtenerCuenta(cuentaP)._saldo - cant
            obtenerCuenta(cuentaRe)._saldo = obtenerCuenta(cuentaRe)._saldo + cant
            Return "Transacción completada."
        Else
            Return "No dispones de esa cantidad de dinero."
        End If
    End Function
End Class
