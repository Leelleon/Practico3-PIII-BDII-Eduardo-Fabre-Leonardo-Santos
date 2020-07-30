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
        Me.SuspendLayout()
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(12, 156)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(0, 20)
        Me.LblDescripcion.TabIndex = 0
        '
        'CmbUsuario
        '
        Me.CmbUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUsuario.FormattingEnabled = True
        Me.CmbUsuario.Location = New System.Drawing.Point(56, 88)
        Me.CmbUsuario.Name = "CmbUsuario"
        Me.CmbUsuario.Size = New System.Drawing.Size(140, 26)
        Me.CmbUsuario.TabIndex = 0
        '
        'CmbServicio
        '
        Me.CmbServicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbServicio.FormattingEnabled = True
        Me.CmbServicio.Location = New System.Drawing.Point(235, 88)
        Me.CmbServicio.Name = "CmbServicio"
        Me.CmbServicio.Size = New System.Drawing.Size(140, 26)
        Me.CmbServicio.TabIndex = 1
        '
        'LblPersona
        '
        Me.LblPersona.AutoSize = True
        Me.LblPersona.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPersona.ForeColor = System.Drawing.Color.White
        Me.LblPersona.Location = New System.Drawing.Point(100, 42)
        Me.LblPersona.Name = "LblPersona"
        Me.LblPersona.Size = New System.Drawing.Size(52, 18)
        Me.LblPersona.TabIndex = 3
        Me.LblPersona.Text = "Usuario"
        '
        'LblServicio
        '
        Me.LblServicio.AutoSize = True
        Me.LblServicio.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblServicio.ForeColor = System.Drawing.Color.White
        Me.LblServicio.Location = New System.Drawing.Point(273, 42)
        Me.LblServicio.Name = "LblServicio"
        Me.LblServicio.Size = New System.Drawing.Size(55, 18)
        Me.LblServicio.TabIndex = 4
        Me.LblServicio.Text = "Servicio"
        '
        'LblDesde
        '
        Me.LblDesde.AutoSize = True
        Me.LblDesde.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDesde.ForeColor = System.Drawing.Color.White
        Me.LblDesde.Location = New System.Drawing.Point(469, 43)
        Me.LblDesde.Name = "LblDesde"
        Me.LblDesde.Size = New System.Drawing.Size(43, 18)
        Me.LblDesde.TabIndex = 5
        Me.LblDesde.Text = "Desde"
        '
        'LblHasta
        '
        Me.LblHasta.AutoSize = True
        Me.LblHasta.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHasta.ForeColor = System.Drawing.Color.White
        Me.LblHasta.Location = New System.Drawing.Point(638, 44)
        Me.LblHasta.Name = "LblHasta"
        Me.LblHasta.Size = New System.Drawing.Size(42, 18)
        Me.LblHasta.TabIndex = 6
        Me.LblHasta.Text = "Hasta"
        '
        'DtpDesde
        '
        Me.DtpDesde.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DtpDesde.CustomFormat = ""
        Me.DtpDesde.Location = New System.Drawing.Point(419, 89)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(134, 23)
        Me.DtpDesde.TabIndex = 2
        '
        'DtpHasta
        '
        Me.DtpHasta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DtpHasta.CustomFormat = ""
        Me.DtpHasta.Location = New System.Drawing.Point(586, 89)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(138, 23)
        Me.DtpHasta.TabIndex = 3
        '
        'ChbConfirmar
        '
        Me.ChbConfirmar.AutoSize = True
        Me.ChbConfirmar.Enabled = False
        Me.ChbConfirmar.Location = New System.Drawing.Point(84, 296)
        Me.ChbConfirmar.Name = "ChbConfirmar"
        Me.ChbConfirmar.Size = New System.Drawing.Size(112, 22)
        Me.ChbConfirmar.TabIndex = 4
        Me.ChbConfirmar.Text = "Confirmar Alta"
        Me.ChbConfirmar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Location = New System.Drawing.Point(387, 345)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(145, 30)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Gray
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Location = New System.Drawing.Point(244, 343)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(125, 35)
        Me.BtnLimpiar.TabIndex = 6
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnAceptar.Location = New System.Drawing.Point(244, 283)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(288, 44)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'FrmAltaContrata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(765, 422)
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
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmAltaContrata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAltaContrata"
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
End Class
