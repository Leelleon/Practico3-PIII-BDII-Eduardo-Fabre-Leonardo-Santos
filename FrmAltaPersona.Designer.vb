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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAltaPersona))
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblPersonaNombre = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.LstTelefono = New System.Windows.Forms.ListBox()
        Me.LblIngresarDatos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.LblTelefono.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblTelefono.ForeColor = System.Drawing.Color.White
        Me.LblTelefono.Location = New System.Drawing.Point(135, 257)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(82, 24)
        Me.LblTelefono.TabIndex = 42
        Me.LblTelefono.Text = "Telefono"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.BackColor = System.Drawing.Color.Transparent
        Me.LblMail.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblMail.ForeColor = System.Drawing.Color.White
        Me.LblMail.Location = New System.Drawing.Point(137, 206)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(45, 24)
        Me.LblMail.TabIndex = 41
        Me.LblMail.Text = "Mail"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.BackColor = System.Drawing.Color.Transparent
        Me.LblApellido.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblApellido.ForeColor = System.Drawing.Color.White
        Me.LblApellido.Location = New System.Drawing.Point(137, 164)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(80, 24)
        Me.LblApellido.TabIndex = 40
        Me.LblApellido.Text = "Apellido"
        '
        'LblPersonaNombre
        '
        Me.LblPersonaNombre.AutoSize = True
        Me.LblPersonaNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblPersonaNombre.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblPersonaNombre.ForeColor = System.Drawing.Color.White
        Me.LblPersonaNombre.Location = New System.Drawing.Point(137, 115)
        Me.LblPersonaNombre.Name = "LblPersonaNombre"
        Me.LblPersonaNombre.Size = New System.Drawing.Size(76, 24)
        Me.LblPersonaNombre.TabIndex = 39
        Me.LblPersonaNombre.Text = "Nombre"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.BackColor = System.Drawing.Color.LightBlue
        Me.TxtTelefono.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.TxtTelefono.Location = New System.Drawing.Point(286, 257)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(223, 29)
        Me.TxtTelefono.TabIndex = 3
        '
        'TxtMail
        '
        Me.TxtMail.BackColor = System.Drawing.Color.LightBlue
        Me.TxtMail.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.TxtMail.Location = New System.Drawing.Point(286, 206)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtMail.MaxLength = 50
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(337, 29)
        Me.TxtMail.TabIndex = 2
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.LightBlue
        Me.TxtNombre.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(287, 115)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombre.MaxLength = 20
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(242, 28)
        Me.TxtNombre.TabIndex = 0
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.LightBlue
        Me.TxtApellido.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.TxtApellido.Location = New System.Drawing.Point(287, 161)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtApellido.MaxLength = 20
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(242, 29)
        Me.TxtApellido.TabIndex = 1
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAceptar.BackgroundImage = CType(resources.GetObject("BtnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAceptar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnAceptar.Location = New System.Drawing.Point(762, 154)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(178, 43)
        Me.BtnAceptar.TabIndex = 6
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.Transparent
        Me.BtnVolver.BackgroundImage = CType(resources.GetObject("BtnVolver.BackgroundImage"), System.Drawing.Image)
        Me.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVolver.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.Location = New System.Drawing.Point(762, 268)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(178, 43)
        Me.BtnVolver.TabIndex = 7
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackgroundImage = CType(resources.GetObject("BtnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAgregar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnAgregar.Location = New System.Drawing.Point(515, 257)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(116, 43)
        Me.BtnAgregar.TabIndex = 4
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'LstTelefono
        '
        Me.LstTelefono.BackColor = System.Drawing.Color.LightBlue
        Me.LstTelefono.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.LstTelefono.FormattingEnabled = True
        Me.LstTelefono.ItemHeight = 23
        Me.LstTelefono.Location = New System.Drawing.Point(286, 293)
        Me.LstTelefono.Name = "LstTelefono"
        Me.LstTelefono.Size = New System.Drawing.Size(222, 188)
        Me.LstTelefono.TabIndex = 5
        '
        'LblIngresarDatos
        '
        Me.LblIngresarDatos.AutoSize = True
        Me.LblIngresarDatos.BackColor = System.Drawing.Color.Transparent
        Me.LblIngresarDatos.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LblIngresarDatos.ForeColor = System.Drawing.SystemColors.Window
        Me.LblIngresarDatos.Location = New System.Drawing.Point(213, 45)
        Me.LblIngresarDatos.Name = "LblIngresarDatos"
        Me.LblIngresarDatos.Size = New System.Drawing.Size(433, 29)
        Me.LblIngresarDatos.TabIndex = 43
        Me.LblIngresarDatos.Text = "Ingrese los datos de la nueva persona"
        '
        'FrmAltaPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnVolver
        Me.ClientSize = New System.Drawing.Size(1050, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblIngresarDatos)
        Me.Controls.Add(Me.LstTelefono)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblPersonaNombre)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.BtnAceptar)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAltaPersona"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar Persona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblPersonaNombre As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents LstTelefono As ListBox
    Friend WithEvents LblIngresarDatos As Label
End Class
