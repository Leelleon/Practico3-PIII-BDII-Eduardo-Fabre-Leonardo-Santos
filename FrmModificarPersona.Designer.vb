<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarPersona
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
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.LstTelefono = New System.Windows.Forms.ListBox()
        Me.CmbIdPersona = New System.Windows.Forms.ComboBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblPersonaNombre = New System.Windows.Forms.Label()
        Me.LblPersonaId = New System.Windows.Forms.Label()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(535, 151)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(96, 40)
        Me.BtnVolver.TabIndex = 79
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(277, 229)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(155, 22)
        Me.TxtTelefono.TabIndex = 78
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(447, 350)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 33)
        Me.BtnEliminar.TabIndex = 77
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(447, 295)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 33)
        Me.BtnModificar.TabIndex = 76
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(447, 234)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 40)
        Me.BtnAgregar.TabIndex = 75
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'LstTelefono
        '
        Me.LstTelefono.FormattingEnabled = True
        Me.LstTelefono.ItemHeight = 16
        Me.LstTelefono.Location = New System.Drawing.Point(277, 269)
        Me.LstTelefono.Name = "LstTelefono"
        Me.LstTelefono.Size = New System.Drawing.Size(155, 148)
        Me.LstTelefono.TabIndex = 74
        '
        'CmbIdPersona
        '
        Me.CmbIdPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIdPersona.FormattingEnabled = True
        Me.CmbIdPersona.Location = New System.Drawing.Point(412, 45)
        Me.CmbIdPersona.Name = "CmbIdPersona"
        Me.CmbIdPersona.Size = New System.Drawing.Size(48, 24)
        Me.CmbIdPersona.TabIndex = 73
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(535, 93)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(96, 38)
        Me.BtnCancelar.TabIndex = 72
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(149, 234)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(64, 17)
        Me.LblTelefono.TabIndex = 71
        Me.LblTelefono.Text = "Telefono"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(149, 174)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(33, 17)
        Me.LblMail.TabIndex = 70
        Me.LblMail.Text = "Mail"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(149, 135)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(58, 17)
        Me.LblApellido.TabIndex = 69
        Me.LblApellido.Text = "Apellido"
        '
        'LblPersonaNombre
        '
        Me.LblPersonaNombre.AutoSize = True
        Me.LblPersonaNombre.Location = New System.Drawing.Point(149, 93)
        Me.LblPersonaNombre.Name = "LblPersonaNombre"
        Me.LblPersonaNombre.Size = New System.Drawing.Size(58, 17)
        Me.LblPersonaNombre.TabIndex = 68
        Me.LblPersonaNombre.Text = "Nombre"
        '
        'LblPersonaId
        '
        Me.LblPersonaId.AutoSize = True
        Me.LblPersonaId.Location = New System.Drawing.Point(115, 45)
        Me.LblPersonaId.Name = "LblPersonaId"
        Me.LblPersonaId.Size = New System.Drawing.Size(274, 17)
        Me.LblPersonaId.TabIndex = 67
        Me.LblPersonaId.Text = "Seleccione el ID de la Persona a Modificar"
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(277, 169)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtMail.MaxLength = 50
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(183, 22)
        Me.TxtMail.TabIndex = 66
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(277, 93)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombre.MaxLength = 20
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(183, 22)
        Me.TxtNombre.TabIndex = 65
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(277, 132)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtApellido.MaxLength = 20
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(183, 22)
        Me.TxtApellido.TabIndex = 64
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(535, 34)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(96, 38)
        Me.BtnAceptar.TabIndex = 63
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'FrmModificarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 450)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.LstTelefono)
        Me.Controls.Add(Me.CmbIdPersona)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblPersonaNombre)
        Me.Controls.Add(Me.LblPersonaId)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Name = "FrmModificarPersona"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnVolver As Button
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents LstTelefono As ListBox
    Friend WithEvents CmbIdPersona As ComboBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblPersonaNombre As Label
    Friend WithEvents LblPersonaId As Label
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents BtnAceptar As Button
End Class
