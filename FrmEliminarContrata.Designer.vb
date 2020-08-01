<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarContrata
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
        Me.TxtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblNombreServicio = New System.Windows.Forms.Label()
        Me.LblNombreUsuario = New System.Windows.Forms.Label()
        Me.TxtNombreServicio = New System.Windows.Forms.TextBox()
        Me.DtpFechaCreacion = New System.Windows.Forms.DateTimePicker()
        Me.LblCreacion = New System.Windows.Forms.Label()
        Me.LblIdUsuario = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.PcbBusqueda = New System.Windows.Forms.PictureBox()
        Me.TxtFechaEmpieza = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblCosto = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtFechaTermina = New System.Windows.Forms.TextBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.LblId = New System.Windows.Forms.Label()
        Me.CmbUsuarios = New System.Windows.Forms.ComboBox()
        Me.CmbServicios = New System.Windows.Forms.ComboBox()
        CType(Me.PcbBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TxtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreUsuario.Enabled = False
        Me.TxtNombreUsuario.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TxtNombreUsuario.ForeColor = System.Drawing.Color.White
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(172, 128)
        Me.TxtNombreUsuario.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtNombreUsuario.MaxLength = 20
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(192, 16)
        Me.TxtNombreUsuario.TabIndex = 119
        Me.TxtNombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(107, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 1)
        Me.Label3.TabIndex = 115
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(107, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(257, 1)
        Me.Label5.TabIndex = 118
        '
        'LblNombreServicio
        '
        Me.LblNombreServicio.AutoSize = True
        Me.LblNombreServicio.Enabled = False
        Me.LblNombreServicio.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreServicio.ForeColor = System.Drawing.Color.White
        Me.LblNombreServicio.Location = New System.Drawing.Point(107, 176)
        Me.LblNombreServicio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombreServicio.Name = "LblNombreServicio"
        Me.LblNombreServicio.Size = New System.Drawing.Size(55, 18)
        Me.LblNombreServicio.TabIndex = 117
        Me.LblNombreServicio.Text = "Servicio"
        '
        'LblNombreUsuario
        '
        Me.LblNombreUsuario.AutoSize = True
        Me.LblNombreUsuario.Enabled = False
        Me.LblNombreUsuario.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreUsuario.ForeColor = System.Drawing.Color.White
        Me.LblNombreUsuario.Location = New System.Drawing.Point(107, 128)
        Me.LblNombreUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombreUsuario.Name = "LblNombreUsuario"
        Me.LblNombreUsuario.Size = New System.Drawing.Size(52, 18)
        Me.LblNombreUsuario.TabIndex = 116
        Me.LblNombreUsuario.Text = "Usuario"
        '
        'TxtNombreServicio
        '
        Me.TxtNombreServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TxtNombreServicio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombreServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreServicio.Enabled = False
        Me.TxtNombreServicio.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TxtNombreServicio.ForeColor = System.Drawing.Color.White
        Me.TxtNombreServicio.Location = New System.Drawing.Point(172, 178)
        Me.TxtNombreServicio.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtNombreServicio.MaxLength = 20
        Me.TxtNombreServicio.Name = "TxtNombreServicio"
        Me.TxtNombreServicio.Size = New System.Drawing.Size(192, 16)
        Me.TxtNombreServicio.TabIndex = 114
        Me.TxtNombreServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DtpFechaCreacion
        '
        Me.DtpFechaCreacion.Enabled = False
        Me.DtpFechaCreacion.Location = New System.Drawing.Point(293, 76)
        Me.DtpFechaCreacion.Name = "DtpFechaCreacion"
        Me.DtpFechaCreacion.Size = New System.Drawing.Size(104, 20)
        Me.DtpFechaCreacion.TabIndex = 113
        '
        'LblCreacion
        '
        Me.LblCreacion.AutoSize = True
        Me.LblCreacion.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCreacion.ForeColor = System.Drawing.Color.White
        Me.LblCreacion.Location = New System.Drawing.Point(278, 42)
        Me.LblCreacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCreacion.Name = "LblCreacion"
        Me.LblCreacion.Size = New System.Drawing.Size(135, 18)
        Me.LblCreacion.TabIndex = 112
        Me.LblCreacion.Text = "Fecha de Contratacion"
        '
        'LblIdUsuario
        '
        Me.LblIdUsuario.AutoSize = True
        Me.LblIdUsuario.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdUsuario.ForeColor = System.Drawing.Color.White
        Me.LblIdUsuario.Location = New System.Drawing.Point(49, 42)
        Me.LblIdUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblIdUsuario.Name = "LblIdUsuario"
        Me.LblIdUsuario.Size = New System.Drawing.Size(84, 18)
        Me.LblIdUsuario.TabIndex = 111
        Me.LblIdUsuario.Text = "ID del Usuario"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Gray
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Location = New System.Drawing.Point(105, 387)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 101
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'PcbBusqueda
        '
        Me.PcbBusqueda.Image = Global.Presentacion.My.Resources.Resources.Busqueda
        Me.PcbBusqueda.Location = New System.Drawing.Point(431, 61)
        Me.PcbBusqueda.Name = "PcbBusqueda"
        Me.PcbBusqueda.Size = New System.Drawing.Size(24, 20)
        Me.PcbBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbBusqueda.TabIndex = 109
        Me.PcbBusqueda.TabStop = False
        '
        'TxtFechaEmpieza
        '
        Me.TxtFechaEmpieza.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TxtFechaEmpieza.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFechaEmpieza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFechaEmpieza.Enabled = False
        Me.TxtFechaEmpieza.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TxtFechaEmpieza.ForeColor = System.Drawing.Color.White
        Me.TxtFechaEmpieza.Location = New System.Drawing.Point(172, 224)
        Me.TxtFechaEmpieza.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtFechaEmpieza.MaxLength = 20
        Me.TxtFechaEmpieza.Name = "TxtFechaEmpieza"
        Me.TxtFechaEmpieza.Size = New System.Drawing.Size(192, 16)
        Me.TxtFechaEmpieza.TabIndex = 108
        Me.TxtFechaEmpieza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(107, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 1)
        Me.Label2.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(107, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 1)
        Me.Label1.TabIndex = 107
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(213, 387)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(151, 23)
        Me.BtnCancelar.TabIndex = 102
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'LblCosto
        '
        Me.LblCosto.AutoSize = True
        Me.LblCosto.Enabled = False
        Me.LblCosto.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCosto.ForeColor = System.Drawing.Color.White
        Me.LblCosto.Location = New System.Drawing.Point(107, 272)
        Me.LblCosto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCosto.Name = "LblCosto"
        Me.LblCosto.Size = New System.Drawing.Size(55, 18)
        Me.LblCosto.TabIndex = 106
        Me.LblCosto.Text = "Termina"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Enabled = False
        Me.LblNombre.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.White
        Me.LblNombre.Location = New System.Drawing.Point(107, 224)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(57, 18)
        Me.LblNombre.TabIndex = 105
        Me.LblNombre.Text = "Empieza"
        '
        'TxtFechaTermina
        '
        Me.TxtFechaTermina.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TxtFechaTermina.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFechaTermina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFechaTermina.Enabled = False
        Me.TxtFechaTermina.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TxtFechaTermina.ForeColor = System.Drawing.Color.White
        Me.TxtFechaTermina.Location = New System.Drawing.Point(172, 274)
        Me.TxtFechaTermina.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtFechaTermina.MaxLength = 20
        Me.TxtFechaTermina.Name = "TxtFechaTermina"
        Me.TxtFechaTermina.Size = New System.Drawing.Size(192, 16)
        Me.TxtFechaTermina.TabIndex = 103
        Me.TxtFechaTermina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.Black
        Me.BtnEliminar.Location = New System.Drawing.Point(105, 326)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(259, 43)
        Me.BtnEliminar.TabIndex = 100
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblId.ForeColor = System.Drawing.Color.White
        Me.LblId.Location = New System.Drawing.Point(170, 42)
        Me.LblId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(86, 18)
        Me.LblId.TabIndex = 99
        Me.LblId.Text = "ID del Servicio"
        '
        'CmbUsuarios
        '
        Me.CmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUsuarios.FormattingEnabled = True
        Me.CmbUsuarios.Location = New System.Drawing.Point(49, 75)
        Me.CmbUsuarios.Name = "CmbUsuarios"
        Me.CmbUsuarios.Size = New System.Drawing.Size(84, 21)
        Me.CmbUsuarios.TabIndex = 120
        '
        'CmbServicios
        '
        Me.CmbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbServicios.FormattingEnabled = True
        Me.CmbServicios.Location = New System.Drawing.Point(173, 75)
        Me.CmbServicios.Name = "CmbServicios"
        Me.CmbServicios.Size = New System.Drawing.Size(83, 21)
        Me.CmbServicios.TabIndex = 121
        '
        'FrmEliminarContrata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(488, 454)
        Me.ControlBox = False
        Me.Controls.Add(Me.CmbServicios)
        Me.Controls.Add(Me.CmbUsuarios)
        Me.Controls.Add(Me.TxtNombreUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblNombreServicio)
        Me.Controls.Add(Me.LblNombreUsuario)
        Me.Controls.Add(Me.TxtNombreServicio)
        Me.Controls.Add(Me.DtpFechaCreacion)
        Me.Controls.Add(Me.LblCreacion)
        Me.Controls.Add(Me.LblIdUsuario)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.PcbBusqueda)
        Me.Controls.Add(Me.TxtFechaEmpieza)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.LblCosto)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TxtFechaTermina)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.LblId)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmEliminarContrata"
        Me.Text = "FrmBajaContrata"
        CType(Me.PcbBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblNombreServicio As Label
    Friend WithEvents LblNombreUsuario As Label
    Friend WithEvents TxtNombreServicio As TextBox
    Friend WithEvents DtpFechaCreacion As DateTimePicker
    Friend WithEvents LblCreacion As Label
    Friend WithEvents LblIdUsuario As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents PcbBusqueda As PictureBox
    Friend WithEvents TxtFechaEmpieza As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblCosto As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtFechaTermina As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents LblId As Label
    Friend WithEvents CmbUsuarios As ComboBox
    Friend WithEvents CmbServicios As ComboBox
    Friend WithEvents TxtNombreUsuario As TextBox
End Class
