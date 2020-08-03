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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarPersona))
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
        Me.BtnVolver.BackColor = System.Drawing.Color.Transparent
        Me.BtnVolver.BackgroundImage = CType(resources.GetObject("BtnVolver.BackgroundImage"), System.Drawing.Image)
        Me.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVolver.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.Location = New System.Drawing.Point(810, 247)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(178, 45)
        Me.BtnVolver.TabIndex = 11
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.Color.LightBlue
        Me.TxtTelefono.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.TxtTelefono.Location = New System.Drawing.Point(301, 259)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(167, 29)
        Me.TxtTelefono.TabIndex = 4
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEliminar.BackgroundImage = CType(resources.GetObject("BtnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEliminar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(502, 368)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(176, 36)
        Me.BtnEliminar.TabIndex = 7
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.BackgroundImage = CType(resources.GetObject("BtnModificar.BackgroundImage"), System.Drawing.Image)
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnModificar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnModificar.ForeColor = System.Drawing.Color.White
        Me.BtnModificar.Location = New System.Drawing.Point(502, 317)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(176, 36)
        Me.BtnModificar.TabIndex = 6
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAgregar.BackgroundImage = CType(resources.GetObject("BtnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAgregar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Location = New System.Drawing.Point(502, 266)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(176, 36)
        Me.BtnAgregar.TabIndex = 5
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'LstTelefono
        '
        Me.LstTelefono.BackColor = System.Drawing.Color.LightBlue
        Me.LstTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstTelefono.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.LstTelefono.FormattingEnabled = True
        Me.LstTelefono.ItemHeight = 23
        Me.LstTelefono.Location = New System.Drawing.Point(301, 293)
        Me.LstTelefono.Name = "LstTelefono"
        Me.LstTelefono.Size = New System.Drawing.Size(167, 186)
        Me.LstTelefono.TabIndex = 8
        '
        'CmbIdPersona
        '
        Me.CmbIdPersona.BackColor = System.Drawing.Color.LightBlue
        Me.CmbIdPersona.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmbIdPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIdPersona.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.CmbIdPersona.FormattingEnabled = True
        Me.CmbIdPersona.Location = New System.Drawing.Point(607, 35)
        Me.CmbIdPersona.Name = "CmbIdPersona"
        Me.CmbIdPersona.Size = New System.Drawing.Size(103, 31)
        Me.CmbIdPersona.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(810, 163)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(178, 43)
        Me.BtnCancelar.TabIndex = 10
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.LblTelefono.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTelefono.ForeColor = System.Drawing.Color.White
        Me.LblTelefono.Location = New System.Drawing.Point(150, 264)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(82, 24)
        Me.LblTelefono.TabIndex = 71
        Me.LblTelefono.Text = "Telefono"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.BackColor = System.Drawing.Color.Transparent
        Me.LblMail.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMail.ForeColor = System.Drawing.Color.White
        Me.LblMail.Location = New System.Drawing.Point(150, 197)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(45, 24)
        Me.LblMail.TabIndex = 70
        Me.LblMail.Text = "Mail"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.BackColor = System.Drawing.Color.Transparent
        Me.LblApellido.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApellido.ForeColor = System.Drawing.Color.White
        Me.LblApellido.Location = New System.Drawing.Point(150, 148)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(80, 24)
        Me.LblApellido.TabIndex = 69
        Me.LblApellido.Text = "Apellido"
        '
        'LblPersonaNombre
        '
        Me.LblPersonaNombre.AutoSize = True
        Me.LblPersonaNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblPersonaNombre.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPersonaNombre.ForeColor = System.Drawing.Color.White
        Me.LblPersonaNombre.Location = New System.Drawing.Point(150, 104)
        Me.LblPersonaNombre.Name = "LblPersonaNombre"
        Me.LblPersonaNombre.Size = New System.Drawing.Size(76, 24)
        Me.LblPersonaNombre.TabIndex = 68
        Me.LblPersonaNombre.Text = "Nombre"
        '
        'LblPersonaId
        '
        Me.LblPersonaId.AutoSize = True
        Me.LblPersonaId.BackColor = System.Drawing.Color.Transparent
        Me.LblPersonaId.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPersonaId.ForeColor = System.Drawing.SystemColors.Window
        Me.LblPersonaId.Location = New System.Drawing.Point(83, 35)
        Me.LblPersonaId.Name = "LblPersonaId"
        Me.LblPersonaId.Size = New System.Drawing.Size(494, 29)
        Me.LblPersonaId.TabIndex = 67
        Me.LblPersonaId.Text = "Seleccione el ID de la Persona a Modificar :"
        '
        'TxtMail
        '
        Me.TxtMail.BackColor = System.Drawing.Color.LightBlue
        Me.TxtMail.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.TxtMail.Location = New System.Drawing.Point(221, 197)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtMail.MaxLength = 50
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(489, 29)
        Me.TxtMail.TabIndex = 3
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.LightBlue
        Me.TxtNombre.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.TxtNombre.Location = New System.Drawing.Point(289, 106)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombre.MaxLength = 20
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(242, 29)
        Me.TxtNombre.TabIndex = 1
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.LightBlue
        Me.TxtApellido.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.TxtApellido.Location = New System.Drawing.Point(289, 150)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtApellido.MaxLength = 20
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(242, 29)
        Me.TxtApellido.TabIndex = 2
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAceptar.BackgroundImage = CType(resources.GetObject("BtnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAceptar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.Location = New System.Drawing.Point(810, 78)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(178, 43)
        Me.BtnAceptar.TabIndex = 9
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'FrmModificarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1050, 532)
        Me.ControlBox = False
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
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FrmModificarPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Modificar Persona"
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
