﻿Public Class Datos

    
    Private Sub Datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCuenta.Text = lblCuenta.Text & MetodosPrincipal._cuenta._nCuenta
        lblCorreo.Text = lblCorreo.Text & MetodosPrincipal._cuenta._correo
        lblNombre.Text = lblNombre.Text & MetodosPrincipal._cuenta._nombre
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()

    End Sub
End Class