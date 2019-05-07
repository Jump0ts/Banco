<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.btnSaldo = New System.Windows.Forms.Button()
        Me.lblSaludo = New System.Windows.Forms.Label()
        Me.btnSacar = New System.Windows.Forms.Button()
        Me.btnTrans = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnDatos = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSaldo
        '
        Me.btnSaldo.Location = New System.Drawing.Point(31, 58)
        Me.btnSaldo.Name = "btnSaldo"
        Me.btnSaldo.Size = New System.Drawing.Size(83, 41)
        Me.btnSaldo.TabIndex = 0
        Me.btnSaldo.Text = "Ver Saldo"
        Me.btnSaldo.UseVisualStyleBackColor = True
        '
        'lblSaludo
        '
        Me.lblSaludo.Location = New System.Drawing.Point(31, 9)
        Me.lblSaludo.Name = "lblSaludo"
        Me.lblSaludo.Size = New System.Drawing.Size(202, 46)
        Me.lblSaludo.TabIndex = 1
        Me.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSacar
        '
        Me.btnSacar.Location = New System.Drawing.Point(150, 58)
        Me.btnSacar.Name = "btnSacar"
        Me.btnSacar.Size = New System.Drawing.Size(83, 41)
        Me.btnSacar.TabIndex = 2
        Me.btnSacar.Text = "Sacar Dinero"
        Me.btnSacar.UseVisualStyleBackColor = True
        '
        'btnTrans
        '
        Me.btnTrans.Location = New System.Drawing.Point(31, 105)
        Me.btnTrans.Name = "btnTrans"
        Me.btnTrans.Size = New System.Drawing.Size(83, 36)
        Me.btnTrans.TabIndex = 3
        Me.btnTrans.Text = "Hacer Transferencia"
        Me.btnTrans.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(150, 105)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(83, 36)
        Me.btnIngresar.TabIndex = 4
        Me.btnIngresar.Text = "Ingresar Dinero"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnDatos
        '
        Me.btnDatos.Location = New System.Drawing.Point(31, 147)
        Me.btnDatos.Name = "btnDatos"
        Me.btnDatos.Size = New System.Drawing.Size(83, 36)
        Me.btnDatos.TabIndex = 5
        Me.btnDatos.Text = "Ver Datos"
        Me.btnDatos.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(150, 147)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(83, 36)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 226)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnDatos)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.btnTrans)
        Me.Controls.Add(Me.btnSacar)
        Me.Controls.Add(Me.lblSaludo)
        Me.Controls.Add(Me.btnSaldo)
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSaldo As System.Windows.Forms.Button
    Friend WithEvents lblSaludo As System.Windows.Forms.Label
    Friend WithEvents btnSacar As System.Windows.Forms.Button
    Friend WithEvents btnTrans As System.Windows.Forms.Button
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents btnDatos As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
