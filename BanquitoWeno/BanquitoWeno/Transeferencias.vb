Public Class Transeferencias

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If (lblMensaje.Text <> "Transacción completada.") Then
            lblMensaje.Text = Controlador.transferencia(txtCant.Text, MetodosPrincipal._cuenta._nCuenta, txtCuentaRe.Text)
        Else
            Me.Close()
        End If
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        txtCant.Text = txtCant.Text + sender.tag
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtCant.Text = ""
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim cadena As String = txtCant.Text
        txtCant.Text = ""
        If cadena.Length > 1 Then
            For ind As Integer = 0 To cadena.Length - 2 Step 1
                txtCant.Text = txtCant.Text & cadena(ind)
            Next
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class