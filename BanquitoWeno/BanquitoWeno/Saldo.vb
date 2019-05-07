Public Class Saldo

    Private Sub Saldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSaldo.Text = lblSaldo.Text & MetodosPrincipal._cuenta._saldo & "€"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class