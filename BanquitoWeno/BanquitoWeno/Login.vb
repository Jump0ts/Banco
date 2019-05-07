Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim nCuenta As String
        nCuenta = Controlador.iniciaSesion(txtNombre.Text, txtPin.Text)
        If nCuenta <> "" Then
            'Dim ventana As MetodosPrincipal = New MetodosPrincipal(nCuenta)
            Label3.Text = "aaaaaaaaa"
            'ShowDialog(New MetodosPrincipal(nCuenta))
            MetodosPrincipal.lanzarPantalla(nCuenta)
            'New MetodosPrincipal(nCuenta)
        Else

        End If
    End Sub

    
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If txtNombre.Text.Length <> 0 And txtPin.Text.Length <> 0 Then
            btnLogin.Enabled = True
        Else
            btnLogin.Enabled = False
        End If
    End Sub

    Private Sub txtPin_TextChanged(sender As Object, e As EventArgs) Handles txtPin.TextChanged
        If txtNombre.Text.Length <> 0 And txtPin.Text.Length <> 0 Then
            btnLogin.Enabled = True
        Else
            btnLogin.Enabled = False
        End If
    End Sub

End Class
