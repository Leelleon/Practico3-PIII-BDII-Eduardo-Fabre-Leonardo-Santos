<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarPersona
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
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblPersonaNombre = New System.Windows.Forms.Label()
        Me.LblPersonaId = New System.Windows.Forms.Label()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.LstTelefono = New System.Windows.Forms.ListBox()
        Me.CmbIdPersona = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(245, 380)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(96, 38)
        Me.BtnCancelar.TabIndex = 67
        Me.BtnCancelar.Text = "Volver"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(54, 198)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(64, 17)
        Me.LblTelefono.TabIndex = 66
        Me.LblTelefono.Text = "Telefono"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(54, 159)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(33, 17)
        Me.LblMail.TabIndex = 65
        Me.LblMail.Text = "Mail"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(54, 125)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(58, 17)
        Me.LblApellido.TabIndex = 64
        Me.LblApellido.Text = "Apellido"
        '
        'LblPersonaNombre
        '
        Me.LblPersonaNombre.AutoSize = True
        Me.LblPersonaNombre.Location = New System.Drawing.Point(54, 83)
        Me.LblPersonaNombre.Name = "LblPersonaNombre"
        Me.LblPersonaNombre.Size = New System.Drawing.Size(58, 17)
        Me.LblPersonaNombre.TabIndex = 63
        Me.LblPersonaNombre.Text = "Nombre"
        '
        'LblPersonaId
        '
        Me.LblPersonaId.AutoSize = True
        Me.LblPersonaId.Location = New System.Drawing.Point(54, 51)
        Me.LblPersonaId.Name = "LblPersonaId"
        Me.LblPersonaId.Size = New System.Drawing.Size(213, 17)
        Me.LblPersonaId.TabIndex = 62
        Me.LblPersonaId.Text = "Seleccione la persona a eliminar"
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(158, 159)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtMail.MaxLength = 50
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(183, 22)
        Me.TxtMail.TabIndex = 60
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(158, 83)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombre.MaxLength = 20
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(183, 22)
        Me.TxtNombre.TabIndex = 59
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(158, 122)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtApellido.MaxLength = 20
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(183, 22)
        Me.TxtApellido.TabIndex = 58
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(57, 380)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(101, 38)
        Me.BtnEliminar.TabIndex = 56
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'LstTelefono
        '
        Me.LstTelefono.FormattingEnabled = True
        Me.LstTelefono.ItemHeight = 16
        Me.LstTelefono.Location = New System.Drawing.Point(158, 198)
        Me.LstTelefono.Name = "LstTelefono"
        Me.LstTelefono.Size = New System.Drawing.Size(183, 148)
        Me.LstTelefono.TabIndex = 68
        '
        'CmbIdPersona
        '
        Me.CmbIdPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIdPersona.FormattingEnabled = True
        Me.CmbIdPersona.Location = New System.Drawing.Point(273, 51)
        Me.CmbIdPersona.Name = "CmbIdPersona"
        Me.CmbIdPersona.Size = New System.Drawing.Size(68, 24)
        Me.CmbIdPersona.TabIndex = 69
        '
        'FrmEliminarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 450)
        Me.Controls.Add(Me.CmbIdPersona)
        Me.Controls.Add(Me.LstTelefono)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblPersonaNombre)
        Me.Controls.Add(Me.LblPersonaId)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Name = "FrmEliminarPersona"
        Me.Text = "FrmEliminarPersona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblPersonaNombre As Label
    Friend WithEvents LblPersonaId As Label
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents LstTelefono As ListBox
    Friend WithEvents CmbIdPersona As ComboBox
End Class
