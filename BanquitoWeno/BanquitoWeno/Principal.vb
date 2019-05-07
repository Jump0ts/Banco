Public Class Principal


    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSaludo.Text = "Bienvenido a su cuenta " + MetodosPrincipal._cuenta._nombre + "."
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub btnSaldo_Click(sender As Object, e As EventArgs) Handles btnSaldo.Click
        Saldo.Show()
    End Sub

    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        Datos.Show()
    End Sub
End Class