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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEliminarContrata))
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
        Me.LblBajaContrata = New System.Windows.Forms.Label()
        CType(Me.PcbBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.BackColor = System.Drawing.Color.LightBlue
        Me.TxtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreUsuario.Enabled = False
        Me.TxtNombreUsuario.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TxtNombreUsuario.ForeColor = System.Drawing.Color.White
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(227, 209)
        Me.TxtNombreUsuario.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtNombreUsuario.MaxLength = 20
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(256, 19)
        Me.TxtNombreUsuario.TabIndex = 119
        Me.TxtNombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(141, 231)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(343, 1)
        Me.Label3.TabIndex = 115
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(141, 291)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(343, 1)
        Me.Label5.TabIndex = 118
        '
        'LblNombreServicio
        '
        Me.LblNombreServicio.AutoSize = True
        Me.LblNombreServicio.BackColor = System.Drawing.Color.Transparent
        Me.LblNombreServicio.Enabled = False
        Me.LblNombreServicio.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblNombreServicio.ForeColor = System.Drawing.Color.White
        Me.LblNombreServicio.Location = New System.Drawing.Point(141, 268)
        Me.LblNombreServicio.Name = "LblNombreServicio"
        Me.LblNombreServicio.Size = New System.Drawing.Size(75, 24)
        Me.LblNombreServicio.TabIndex = 117
        Me.LblNombreServicio.Text = "Servicio"
        '
        'LblNombreUsuario
        '
        Me.LblNombreUsuario.AutoSize = True
        Me.LblNombreUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblNombreUsuario.Enabled = False
        Me.LblNombreUsuario.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblNombreUsuario.ForeColor = System.Drawing.Color.White
        Me.LblNombreUsuario.Location = New System.Drawing.Point(141, 209)
        Me.LblNombreUsuario.Name = "LblNombreUsuario"
        Me.LblNombreUsuario.Size = New System.Drawing.Size(72, 24)
        Me.LblNombreUsuario.TabIndex = 116
        Me.LblNombreUsuario.Text = "Usuario"
        '
        'TxtNombreServicio
        '
        Me.TxtNombreServicio.BackColor = System.Drawing.Color.LightBlue
        Me.TxtNombreServicio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombreServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombreServicio.Enabled = False
        Me.TxtNombreServicio.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TxtNombreServicio.ForeColor = System.Drawing.Color.White
        Me.TxtNombreServicio.Location = New System.Drawing.Point(227, 270)
        Me.TxtNombreServicio.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtNombreServicio.MaxLength = 20
        Me.TxtNombreServicio.Name = "TxtNombreServicio"
        Me.TxtNombreServicio.Size = New System.Drawing.Size(256, 19)
        Me.TxtNombreServicio.TabIndex = 114
        Me.TxtNombreServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DtpFechaCreacion
        '
        Me.DtpFechaCreacion.Enabled = False
        Me.DtpFechaCreacion.Location = New System.Drawing.Point(399, 145)
        Me.DtpFechaCreacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DtpFechaCreacion.Name = "DtpFechaCreacion"
        Me.DtpFechaCreacion.Size = New System.Drawing.Size(137, 22)
        Me.DtpFechaCreacion.TabIndex = 113
        '
        'LblCreacion
        '
        Me.LblCreacion.AutoSize = True
        Me.LblCreacion.BackColor = System.Drawing.Color.Transparent
        Me.LblCreacion.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblCreacion.ForeColor = System.Drawing.Color.White
        Me.LblCreacion.Location = New System.Drawing.Point(366, 103)
        Me.LblCreacion.Name = "LblCreacion"
        Me.LblCreacion.Size = New System.Drawing.Size(200, 24)
        Me.LblCreacion.TabIndex = 112
        Me.LblCreacion.Text = "Fecha de Contratacion"
        '
        'LblIdUsuario
        '
        Me.LblIdUsuario.AutoSize = True
        Me.LblIdUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblIdUsuario.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblIdUsuario.ForeColor = System.Drawing.Color.White
        Me.LblIdUsuario.Location = New System.Drawing.Point(46, 103)
        Me.LblIdUsuario.Name = "LblIdUsuario"
        Me.LblIdUsuario.Size = New System.Drawing.Size(128, 24)
        Me.LblIdUsuario.TabIndex = 111
        Me.LblIdUsuario.Text = "ID del Usuario"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Transparent
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLimpiar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Location = New System.Drawing.Point(743, 261)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(234, 60)
        Me.BtnLimpiar.TabIndex = 101
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'PcbBusqueda
        '
        Me.PcbBusqueda.BackColor = System.Drawing.Color.LightBlue
        Me.PcbBusqueda.Image = Global.Presentacion.My.Resources.Resources.Busqueda
        Me.PcbBusqueda.Location = New System.Drawing.Point(587, 136)
        Me.PcbBusqueda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PcbBusqueda.Name = "PcbBusqueda"
        Me.PcbBusqueda.Size = New System.Drawing.Size(40, 31)
        Me.PcbBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbBusqueda.TabIndex = 109
        Me.PcbBusqueda.TabStop = False
        '
        'TxtFechaEmpieza
        '
        Me.TxtFechaEmpieza.BackColor = System.Drawing.Color.LightBlue
        Me.TxtFechaEmpieza.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFechaEmpieza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFechaEmpieza.Enabled = False
        Me.TxtFechaEmpieza.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TxtFechaEmpieza.ForeColor = System.Drawing.Color.White
        Me.TxtFechaEmpieza.Location = New System.Drawing.Point(227, 327)
        Me.TxtFechaEmpieza.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtFechaEmpieza.MaxLength = 20
        Me.TxtFechaEmpieza.Name = "TxtFechaEmpieza"
        Me.TxtFechaEmpieza.Size = New System.Drawing.Size(256, 19)
        Me.TxtFechaEmpieza.TabIndex = 108
        Me.TxtFechaEmpieza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(141, 349)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(343, 1)
        Me.Label2.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(141, 409)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 1)
        Me.Label1.TabIndex = 107
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
        Me.BtnCancelar.Location = New System.Drawing.Point(743, 367)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(234, 60)
        Me.BtnCancelar.TabIndex = 102
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'LblCosto
        '
        Me.LblCosto.AutoSize = True
        Me.LblCosto.BackColor = System.Drawing.Color.Transparent
        Me.LblCosto.Enabled = False
        Me.LblCosto.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblCosto.ForeColor = System.Drawing.Color.White
        Me.LblCosto.Location = New System.Drawing.Point(141, 386)
        Me.LblCosto.Name = "LblCosto"
        Me.LblCosto.Size = New System.Drawing.Size(77, 24)
        Me.LblCosto.TabIndex = 106
        Me.LblCosto.Text = "Termina"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Enabled = False
        Me.LblNombre.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblNombre.ForeColor = System.Drawing.Color.White
        Me.LblNombre.Location = New System.Drawing.Point(141, 327)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(81, 24)
        Me.LblNombre.TabIndex = 105
        Me.LblNombre.Text = "Empieza"
        '
        'TxtFechaTermina
        '
        Me.TxtFechaTermina.BackColor = System.Drawing.Color.LightBlue
        Me.TxtFechaTermina.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFechaTermina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFechaTermina.Enabled = False
        Me.TxtFechaTermina.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TxtFechaTermina.ForeColor = System.Drawing.Color.White
        Me.TxtFechaTermina.Location = New System.Drawing.Point(227, 388)
        Me.TxtFechaTermina.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtFechaTermina.MaxLength = 20
        Me.TxtFechaTermina.Name = "TxtFechaTermina"
        Me.TxtFechaTermina.Size = New System.Drawing.Size(256, 19)
        Me.TxtFechaTermina.TabIndex = 103
        Me.TxtFechaTermina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEliminar.BackgroundImage = CType(resources.GetObject("BtnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEliminar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(743, 143)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(234, 60)
        Me.BtnEliminar.TabIndex = 100
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.BackColor = System.Drawing.Color.Transparent
        Me.LblId.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblId.ForeColor = System.Drawing.Color.White
        Me.LblId.Location = New System.Drawing.Point(207, 103)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(131, 24)
        Me.LblId.TabIndex = 99
        Me.LblId.Text = "ID del Servicio"
        '
        'CmbUsuarios
        '
        Me.CmbUsuarios.BackColor = System.Drawing.SystemColors.Window
        Me.CmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUsuarios.FormattingEnabled = True
        Me.CmbUsuarios.Location = New System.Drawing.Point(63, 143)
        Me.CmbUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbUsuarios.Name = "CmbUsuarios"
        Me.CmbUsuarios.Size = New System.Drawing.Size(111, 24)
        Me.CmbUsuarios.TabIndex = 120
        '
        'CmbServicios
        '
        Me.CmbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbServicios.FormattingEnabled = True
        Me.CmbServicios.Location = New System.Drawing.Point(229, 143)
        Me.CmbServicios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbServicios.Name = "CmbServicios"
        Me.CmbServicios.Size = New System.Drawing.Size(109, 24)
        Me.CmbServicios.TabIndex = 121
        '
        'LblBajaContrata
        '
        Me.LblBajaContrata.AutoSize = True
        Me.LblBajaContrata.BackColor = System.Drawing.Color.Transparent
        Me.LblBajaContrata.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LblBajaContrata.ForeColor = System.Drawing.SystemColors.Window
        Me.LblBajaContrata.Location = New System.Drawing.Point(224, 28)
        Me.LblBajaContrata.Name = "LblBajaContrata"
        Me.LblBajaContrata.Size = New System.Drawing.Size(485, 29)
        Me.LblBajaContrata.TabIndex = 122
        Me.LblBajaContrata.Text = "Seleccione el contrato que desea eliminar"
        '
        'FrmEliminarContrata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1050, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblBajaContrata)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmEliminarContrata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents LblBajaContrata As Label
End Class
