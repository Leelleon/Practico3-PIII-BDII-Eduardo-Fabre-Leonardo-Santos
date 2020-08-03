<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEliminarServicio))
        Me.LblId = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblLinea2 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.LblCosto = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblPersonaId = New System.Windows.Forms.Label()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.PcbBusqueda = New System.Windows.Forms.PictureBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        CType(Me.PcbBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.BackColor = System.Drawing.Color.Transparent
        Me.LblId.Font = New System.Drawing.Font("Trebuchet MS", 13.2!, System.Drawing.FontStyle.Bold)
        Me.LblId.ForeColor = System.Drawing.Color.White
        Me.LblId.Location = New System.Drawing.Point(114, 63)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(271, 27)
        Me.LblId.TabIndex = 0
        Me.LblId.Text = "ID del servicio a eliminar"
        '
        'TxtId
        '
        Me.TxtId.BackColor = System.Drawing.Color.LightBlue
        Me.TxtId.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.TxtId.Location = New System.Drawing.Point(428, 62)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(89, 29)
        Me.TxtId.TabIndex = 0
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Gray
        Me.BtnEliminar.BackgroundImage = CType(resources.GetObject("BtnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEliminar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(711, 160)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(282, 64)
        Me.BtnEliminar.TabIndex = 1
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(175, 213)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(343, 1)
        Me.Label2.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(174, 307)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 1)
        Me.Label1.TabIndex = 68
        '
        'LblLinea2
        '
        Me.LblLinea2.BackColor = System.Drawing.Color.White
        Me.LblLinea2.Location = New System.Drawing.Point(182, 405)
        Me.LblLinea2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLinea2.Name = "LblLinea2"
        Me.LblLinea2.Size = New System.Drawing.Size(343, 1)
        Me.LblLinea2.TabIndex = 67
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(748, 405)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(211, 52)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.BackColor = System.Drawing.Color.Transparent
        Me.LblTipo.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblTipo.ForeColor = System.Drawing.Color.White
        Me.LblTipo.Location = New System.Drawing.Point(175, 382)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(46, 24)
        Me.LblTipo.TabIndex = 66
        Me.LblTipo.Text = "Tipo"
        '
        'LblCosto
        '
        Me.LblCosto.AutoSize = True
        Me.LblCosto.BackColor = System.Drawing.Color.Transparent
        Me.LblCosto.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblCosto.ForeColor = System.Drawing.Color.White
        Me.LblCosto.Location = New System.Drawing.Point(174, 283)
        Me.LblCosto.Name = "LblCosto"
        Me.LblCosto.Size = New System.Drawing.Size(57, 24)
        Me.LblCosto.TabIndex = 65
        Me.LblCosto.Text = "Costo"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblNombre.ForeColor = System.Drawing.Color.White
        Me.LblNombre.Location = New System.Drawing.Point(175, 191)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(76, 24)
        Me.LblNombre.TabIndex = 64
        Me.LblNombre.Text = "Nombre"
        '
        'LblPersonaId
        '
        Me.LblPersonaId.AutoSize = True
        Me.LblPersonaId.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPersonaId.ForeColor = System.Drawing.Color.White
        Me.LblPersonaId.Location = New System.Drawing.Point(115, -21)
        Me.LblPersonaId.Name = "LblPersonaId"
        Me.LblPersonaId.Size = New System.Drawing.Size(24, 23)
        Me.LblPersonaId.TabIndex = 63
        Me.LblPersonaId.Text = "Id"
        '
        'TxtCosto
        '
        Me.TxtCosto.BackColor = System.Drawing.Color.LightBlue
        Me.TxtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCosto.Enabled = False
        Me.TxtCosto.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.TxtCosto.ForeColor = System.Drawing.Color.White
        Me.TxtCosto.Location = New System.Drawing.Point(260, 286)
        Me.TxtCosto.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtCosto.MaxLength = 20
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(256, 22)
        Me.TxtCosto.TabIndex = 56
        Me.TxtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTipo
        '
        Me.TxtTipo.AcceptsTab = True
        Me.TxtTipo.BackColor = System.Drawing.Color.LightBlue
        Me.TxtTipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTipo.Enabled = False
        Me.TxtTipo.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.TxtTipo.ForeColor = System.Drawing.Color.White
        Me.TxtTipo.Location = New System.Drawing.Point(268, 384)
        Me.TxtTipo.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtTipo.MaxLength = 20
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(256, 22)
        Me.TxtTipo.TabIndex = 69
        Me.TxtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.LightBlue
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.TxtNombre.ForeColor = System.Drawing.Color.White
        Me.TxtNombre.Location = New System.Drawing.Point(262, 202)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtNombre.MaxLength = 20
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(256, 22)
        Me.TxtNombre.TabIndex = 70
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PcbBusqueda
        '
        Me.PcbBusqueda.BackColor = System.Drawing.Color.LightBlue
        Me.PcbBusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PcbBusqueda.Image = Global.Presentacion.My.Resources.Resources.Busqueda
        Me.PcbBusqueda.Location = New System.Drawing.Point(524, 53)
        Me.PcbBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.PcbBusqueda.Name = "PcbBusqueda"
        Me.PcbBusqueda.Size = New System.Drawing.Size(42, 37)
        Me.PcbBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PcbBusqueda.TabIndex = 71
        Me.PcbBusqueda.TabStop = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Gray
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLimpiar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Location = New System.Drawing.Point(748, 287)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(211, 52)
        Me.BtnLimpiar.TabIndex = 2
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'FrmEliminarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1050, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.PcbBusqueda)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblLinea2)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.LblTipo)
        Me.Controls.Add(Me.LblCosto)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblPersonaId)
        Me.Controls.Add(Me.TxtCosto)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.LblId)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmEliminarServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Eliminar Servicio"
        CType(Me.PcbBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblId As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblLinea2 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblTipo As Label
    Friend WithEvents LblCosto As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblPersonaId As Label
    Friend WithEvents TxtCosto As TextBox
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents PcbBusqueda As PictureBox
    Friend WithEvents BtnLimpiar As Button
End Class
