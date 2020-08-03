<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAltaContrata
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAltaContrata))
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.CmbUsuario = New System.Windows.Forms.ComboBox()
        Me.CmbServicio = New System.Windows.Forms.ComboBox()
        Me.LblPersona = New System.Windows.Forms.Label()
        Me.LblServicio = New System.Windows.Forms.Label()
        Me.LblDesde = New System.Windows.Forms.Label()
        Me.LblHasta = New System.Windows.Forms.Label()
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.ChbConfirmar = New System.Windows.Forms.CheckBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.LblDatosContrata = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(37, 256)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(0, 29)
        Me.LblDescripcion.TabIndex = 0
        '
        'CmbUsuario
        '
        Me.CmbUsuario.BackColor = System.Drawing.Color.LightBlue
        Me.CmbUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUsuario.FormattingEnabled = True
        Me.CmbUsuario.Location = New System.Drawing.Point(31, 148)
        Me.CmbUsuario.Name = "CmbUsuario"
        Me.CmbUsuario.Size = New System.Drawing.Size(140, 30)
        Me.CmbUsuario.TabIndex = 0
        '
        'CmbServicio
        '
        Me.CmbServicio.BackColor = System.Drawing.Color.LightBlue
        Me.CmbServicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbServicio.FormattingEnabled = True
        Me.CmbServicio.Location = New System.Drawing.Point(216, 148)
        Me.CmbServicio.Name = "CmbServicio"
        Me.CmbServicio.Size = New System.Drawing.Size(140, 30)
        Me.CmbServicio.TabIndex = 1
        '
        'LblPersona
        '
        Me.LblPersona.AutoSize = True
        Me.LblPersona.BackColor = System.Drawing.Color.Transparent
        Me.LblPersona.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblPersona.ForeColor = System.Drawing.Color.White
        Me.LblPersona.Location = New System.Drawing.Point(66, 106)
        Me.LblPersona.Name = "LblPersona"
        Me.LblPersona.Size = New System.Drawing.Size(72, 24)
        Me.LblPersona.TabIndex = 3
        Me.LblPersona.Text = "Usuario"
        '
        'LblServicio
        '
        Me.LblServicio.AutoSize = True
        Me.LblServicio.BackColor = System.Drawing.Color.Transparent
        Me.LblServicio.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblServicio.ForeColor = System.Drawing.Color.White
        Me.LblServicio.Location = New System.Drawing.Point(246, 107)
        Me.LblServicio.Name = "LblServicio"
        Me.LblServicio.Size = New System.Drawing.Size(75, 24)
        Me.LblServicio.TabIndex = 4
        Me.LblServicio.Text = "Servicio"
        '
        'LblDesde
        '
        Me.LblDesde.AutoSize = True
        Me.LblDesde.BackColor = System.Drawing.Color.Transparent
        Me.LblDesde.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblDesde.ForeColor = System.Drawing.Color.White
        Me.LblDesde.Location = New System.Drawing.Point(470, 107)
        Me.LblDesde.Name = "LblDesde"
        Me.LblDesde.Size = New System.Drawing.Size(61, 24)
        Me.LblDesde.TabIndex = 5
        Me.LblDesde.Text = "Desde"
        '
        'LblHasta
        '
        Me.LblHasta.AutoSize = True
        Me.LblHasta.BackColor = System.Drawing.Color.Transparent
        Me.LblHasta.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblHasta.ForeColor = System.Drawing.Color.White
        Me.LblHasta.Location = New System.Drawing.Point(709, 107)
        Me.LblHasta.Name = "LblHasta"
        Me.LblHasta.Size = New System.Drawing.Size(58, 24)
        Me.LblHasta.TabIndex = 6
        Me.LblHasta.Text = "Hasta"
        '
        'DtpDesde
        '
        Me.DtpDesde.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DtpDesde.CustomFormat = ""
        Me.DtpDesde.Location = New System.Drawing.Point(410, 148)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(176, 26)
        Me.DtpDesde.TabIndex = 2
        '
        'DtpHasta
        '
        Me.DtpHasta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DtpHasta.CustomFormat = ""
        Me.DtpHasta.Location = New System.Drawing.Point(648, 147)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(176, 26)
        Me.DtpHasta.TabIndex = 3
        '
        'ChbConfirmar
        '
        Me.ChbConfirmar.AutoSize = True
        Me.ChbConfirmar.BackColor = System.Drawing.Color.Transparent
        Me.ChbConfirmar.Enabled = False
        Me.ChbConfirmar.Location = New System.Drawing.Point(879, 147)
        Me.ChbConfirmar.Name = "ChbConfirmar"
        Me.ChbConfirmar.Size = New System.Drawing.Size(144, 27)
        Me.ChbConfirmar.TabIndex = 4
        Me.ChbConfirmar.Text = "Confirmar Alta"
        Me.ChbConfirmar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCancelar.Location = New System.Drawing.Point(702, 438)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(235, 51)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Transparent
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLimpiar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLimpiar.Location = New System.Drawing.Point(401, 438)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(235, 51)
        Me.BtnLimpiar.TabIndex = 6
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAceptar.BackgroundImage = CType(resources.GetObject("BtnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAceptar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnAceptar.Location = New System.Drawing.Point(94, 438)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(235, 51)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'LblDatosContrata
        '
        Me.LblDatosContrata.AutoSize = True
        Me.LblDatosContrata.BackColor = System.Drawing.Color.Transparent
        Me.LblDatosContrata.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LblDatosContrata.ForeColor = System.Drawing.SystemColors.Window
        Me.LblDatosContrata.Location = New System.Drawing.Point(232, 32)
        Me.LblDatosContrata.Name = "LblDatosContrata"
        Me.LblDatosContrata.Size = New System.Drawing.Size(556, 29)
        Me.LblDatosContrata.TabIndex = 8
        Me.LblDatosContrata.Text = "Complete los datos para registar nuevo contrato"
        '
        'FrmAltaContrata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1050, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblDatosContrata)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.ChbConfirmar)
        Me.Controls.Add(Me.DtpHasta)
        Me.Controls.Add(Me.DtpDesde)
        Me.Controls.Add(Me.LblHasta)
        Me.Controls.Add(Me.LblDesde)
        Me.Controls.Add(Me.LblServicio)
        Me.Controls.Add(Me.LblPersona)
        Me.Controls.Add(Me.CmbServicio)
        Me.Controls.Add(Me.CmbUsuario)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Window
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmAltaContrata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Contrato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDescripcion As Label
    Friend WithEvents CmbUsuario As ComboBox
    Friend WithEvents CmbServicio As ComboBox
    Friend WithEvents LblPersona As Label
    Friend WithEvents LblServicio As Label
    Friend WithEvents LblDesde As Label
    Friend WithEvents LblHasta As Label
    Friend WithEvents DtpDesde As DateTimePicker
    Friend WithEvents DtpHasta As DateTimePicker
    Friend WithEvents ChbConfirmar As CheckBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents LblDatosContrata As Label
End Class
