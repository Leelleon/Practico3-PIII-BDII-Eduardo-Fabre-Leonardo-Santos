<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaPersona
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
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblPersonaNombre = New System.Windows.Forms.Label()
        Me.LblPersonaId = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtPersonaId = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(77, 211)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(64, 17)
        Me.LblTelefono.TabIndex = 42
        Me.LblTelefono.Text = "Telefono"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(77, 169)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(33, 17)
        Me.LblMail.TabIndex = 41
        Me.LblMail.Text = "Mail"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(77, 135)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(58, 17)
        Me.LblApellido.TabIndex = 40
        Me.LblApellido.Text = "Apellido"
        '
        'LblPersonaNombre
        '
        Me.LblPersonaNombre.AutoSize = True
        Me.LblPersonaNombre.Location = New System.Drawing.Point(77, 93)
        Me.LblPersonaNombre.Name = "LblPersonaNombre"
        Me.LblPersonaNombre.Size = New System.Drawing.Size(58, 17)
        Me.LblPersonaNombre.TabIndex = 39
        Me.LblPersonaNombre.Text = "Nombre"
        '
        'LblPersonaId
        '
        Me.LblPersonaId.AutoSize = True
        Me.LblPersonaId.Location = New System.Drawing.Point(77, 61)
        Me.LblPersonaId.Name = "LblPersonaId"
        Me.LblPersonaId.Size = New System.Drawing.Size(19, 17)
        Me.LblPersonaId.TabIndex = 38
        Me.LblPersonaId.Text = "Id"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(181, 211)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(183, 22)
        Me.TxtTelefono.TabIndex = 37
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(181, 169)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtMail.MaxLength = 50
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(183, 22)
        Me.TxtMail.TabIndex = 36
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(181, 93)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombre.MaxLength = 20
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(183, 22)
        Me.TxtNombre.TabIndex = 35
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(181, 132)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtApellido.MaxLength = 20
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(183, 22)
        Me.TxtApellido.TabIndex = 34
        '
        'TxtPersonaId
        '
        Me.TxtPersonaId.Enabled = False
        Me.TxtPersonaId.Location = New System.Drawing.Point(181, 61)
        Me.TxtPersonaId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPersonaId.Name = "TxtPersonaId"
        Me.TxtPersonaId.Size = New System.Drawing.Size(61, 22)
        Me.TxtPersonaId.TabIndex = 33
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.Location = New System.Drawing.Point(69, 282)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(101, 38)
        Me.BtnAceptar.TabIndex = 32
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.Location = New System.Drawing.Point(244, 282)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(96, 38)
        Me.BtnCancelar.TabIndex = 43
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmAltaPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancelar
        Me.ClientSize = New System.Drawing.Size(445, 450)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblPersonaNombre)
        Me.Controls.Add(Me.LblPersonaId)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtPersonaId)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Name = "FrmAltaPersona"
        Me.Text = "FrmAltaPersona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblPersonaNombre As Label
    Friend WithEvents LblPersonaId As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtPersonaId As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
End Class
