Public Class Cambiar_Pin

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If (lblMensaje.Text <> "Pin cambiado correctamente.") Then
            lblMensaje.Text = MetodosPrincipal._tarjeta.cambiarPin(txtPinA.Text, txtPinN.Text, txtPinN2.Text)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Cambiar_Pin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class