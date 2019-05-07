Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim nCuenta As String
        nCuenta = Controlador.iniciaSesion(txtNombre.Text, txtPin.Text)
        If nCuenta <> "" Then
            'Dim ventana As MetodosPrincipal = New MetodosPrincipal(nCuenta)
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
    Private Sub txtPin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPin.KeyPress
        Controlador.compTecla(e)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        If txtPin.Text.Length < 4 Then
            txtPin.Text = txtPin.Text + sender.tag
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtPin.Text = ""
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim cadena As String = txtPin.Text
        txtPin.Text = ""
        If cadena.Length > 1 Then
            For ind As Integer = 0 To cadena.Length - 2 Step 1
                txtPin.Text = txtPin.Text & cadena(ind)
            Next
        End If

    End Sub
End Class
