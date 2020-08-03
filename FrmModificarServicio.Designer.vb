<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarServicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarServicio))
        Me.LblId = New System.Windows.Forms.Label()
        Me.CmbId = New System.Windows.Forms.ComboBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblLinea2 = New System.Windows.Forms.Label()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblPersonaNombre = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.BackColor = System.Drawing.Color.Transparent
        Me.LblId.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LblId.ForeColor = System.Drawing.SystemColors.Window
        Me.LblId.Location = New System.Drawing.Point(32, 42)
        Me.LblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(461, 29)
        Me.LblId.TabIndex = 0
        Me.LblId.Text = "Seleccione el ID del servicio a modificar"
        '
        'CmbId
        '
        Me.CmbId.BackColor = System.Drawing.Color.LightBlue
        Me.CmbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbId.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.CmbId.FormattingEnabled = True
        Me.CmbId.Location = New System.Drawing.Point(527, 42)
        Me.CmbId.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbId.Name = "CmbId"
        Me.CmbId.Size = New System.Drawing.Size(92, 31)
        Me.CmbId.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(759, 328)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(213, 40)
        Me.BtnCancelar.TabIndex = 6
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
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Location = New System.Drawing.Point(759, 219)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(213, 40)
        Me.BtnLimpiar.TabIndex = 5
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAceptar.BackgroundImage = CType(resources.GetObject("BtnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAceptar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.Location = New System.Drawing.Point(734, 85)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(258, 54)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "Modificar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightBlue
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(68, 164)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 1)
        Me.Label1.TabIndex = 66
        '
        'LblLinea2
        '
        Me.LblLinea2.BackColor = System.Drawing.Color.LightBlue
        Me.LblLinea2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblLinea2.Location = New System.Drawing.Point(68, 243)
        Me.LblLinea2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLinea2.Name = "LblLinea2"
        Me.LblLinea2.Size = New System.Drawing.Size(343, 1)
        Me.LblLinea2.TabIndex = 65
        '
        'CmbTipo
        '
        Me.CmbTipo.BackColor = System.Drawing.Color.LightBlue
        Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbTipo.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.CmbTipo.ForeColor = System.Drawing.Color.Black
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Items.AddRange(New Object() {"Limpieza", "Mantenimiento", "Electricidad", "Telecomunicaciones", "Informática"})
        Me.CmbTipo.Location = New System.Drawing.Point(150, 314)
        Me.CmbTipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(341, 31)
        Me.CmbTipo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(67, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 24)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(66, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 24)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Costo"
        '
        'LblPersonaNombre
        '
        Me.LblPersonaNombre.AutoSize = True
        Me.LblPersonaNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblPersonaNombre.Font = New System.Drawing.Font("Trebuchet MS", 10.8!)
        Me.LblPersonaNombre.ForeColor = System.Drawing.Color.White
        Me.LblPersonaNombre.Location = New System.Drawing.Point(67, 140)
        Me.LblPersonaNombre.Name = "LblPersonaNombre"
        Me.LblPersonaNombre.Size = New System.Drawing.Size(76, 24)
        Me.LblPersonaNombre.TabIndex = 62
        Me.LblPersonaNombre.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.LightBlue
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.TxtNombre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNombre.Location = New System.Drawing.Point(150, 143)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtNombre.MaxLength = 20
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(343, 22)
        Me.TxtNombre.TabIndex = 1
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCosto
        '
        Me.TxtCosto.AcceptsTab = True
        Me.TxtCosto.BackColor = System.Drawing.Color.LightBlue
        Me.TxtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCosto.Font = New System.Drawing.Font("Trebuchet MS", 11.0!, System.Drawing.FontStyle.Italic)
        Me.TxtCosto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtCosto.Location = New System.Drawing.Point(150, 224)
        Me.TxtCosto.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.TxtCosto.MaxLength = 20
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(343, 22)
        Me.TxtCosto.TabIndex = 2
        Me.TxtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmModificarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1050, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblLinea2)
        Me.Controls.Add(Me.CmbTipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblPersonaNombre)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtCosto)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.CmbId)
        Me.Controls.Add(Me.LblId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmModificarServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificacion del Servicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblId As Label
    Friend WithEvents CmbId As ComboBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LblLinea2 As Label
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblPersonaNombre As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCosto As TextBox
End Class
