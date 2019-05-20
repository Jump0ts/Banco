<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Datos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnPin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCuenta
        '
        Me.lblCuenta.Location = New System.Drawing.Point(12, 9)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(260, 23)
        Me.lblCuenta.TabIndex = 0
        Me.lblCuenta.Text = "Nº Cuenta: "
        '
        'lblCorreo
        '
        Me.lblCorreo.Location = New System.Drawing.Point(12, 55)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(260, 23)
        Me.lblCorreo.TabIndex = 2
        Me.lblCorreo.Text = "Correo electrónico: "
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(12, 32)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(260, 23)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre: "
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(177, 98)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnPin
        '
        Me.btnPin.Location = New System.Drawing.Point(15, 98)
        Me.btnPin.Name = "btnPin"
        Me.btnPin.Size = New System.Drawing.Size(75, 23)
        Me.btnPin.TabIndex = 5
        Me.btnPin.Text = "Cambiar Pin"
        Me.btnPin.UseVisualStyleBackColor = True
        '
        'Datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 143)
        Me.Controls.Add(Me.btnPin)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblCuenta)
        Me.Name = "Datos"
        Me.Text = "Datos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnPin As System.Windows.Forms.Button
End Class
