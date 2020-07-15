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
        Me.LblId.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblId.ForeColor = System.Drawing.Color.White
        Me.LblId.Location = New System.Drawing.Point(24, 34)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(229, 18)
        Me.LblId.TabIndex = 0
        Me.LblId.Text = "Seleccione el ID del servicio a modificar"
        '
        'CmbId
        '
        Me.CmbId.FormattingEnabled = True
        Me.CmbId.Location = New System.Drawing.Point(259, 31)
        Me.CmbId.Name = "CmbId"
        Me.CmbId.Size = New System.Drawing.Size(70, 21)
        Me.CmbId.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Location = New System.Drawing.Point(161, 370)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(145, 21)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Gray
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Location = New System.Drawing.Point(52, 370)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(103, 21)
        Me.BtnLimpiar.TabIndex = 5
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnAceptar.Location = New System.Drawing.Point(49, 310)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(257, 44)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "Modificar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 1)
        Me.Label1.TabIndex = 66
        '
        'LblLinea2
        '
        Me.LblLinea2.BackColor = System.Drawing.Color.White
        Me.LblLinea2.Location = New System.Drawing.Point(49, 198)
        Me.LblLinea2.Name = "LblLinea2"
        Me.LblLinea2.Size = New System.Drawing.Size(257, 1)
        Me.LblLinea2.TabIndex = 65
        '
        'CmbTipo
        '
        Me.CmbTipo.BackColor = System.Drawing.Color.White
        Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbTipo.ForeColor = System.Drawing.Color.Black
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Items.AddRange(New Object() {"Limpieza", "Mantenimiento", "Electricidad", "Telecomunicaciones", "Informática"})
        Me.CmbTipo.Location = New System.Drawing.Point(49, 252)
        Me.CmbTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(257, 21)
        Me.CmbTipo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(46, 232)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 18)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(46, 164)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 18)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Costo"
        '
        'LblPersonaNombre
        '
        Me.LblPersonaNombre.AutoSize = True
        Me.LblPersonaNombre.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPersonaNombre.ForeColor = System.Drawing.Color.White
        Me.LblPersonaNombre.Location = New System.Drawing.Point(46, 81)
        Me.LblPersonaNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPersonaNombre.Name = "LblPersonaNombre"
        Me.LblPersonaNombre.Size = New System.Drawing.Size(53, 18)
        Me.LblPersonaNombre.TabIndex = 62
        Me.LblPersonaNombre.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TxtNombre.ForeColor = System.Drawing.Color.White
        Me.TxtNombre.Location = New System.Drawing.Point(49, 106)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtNombre.MaxLength = 20
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(257, 16)
        Me.TxtNombre.TabIndex = 1
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCosto
        '
        Me.TxtCosto.AcceptsTab = True
        Me.TxtCosto.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TxtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCosto.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCosto.ForeColor = System.Drawing.Color.White
        Me.TxtCosto.Location = New System.Drawing.Point(49, 183)
        Me.TxtCosto.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtCosto.MaxLength = 20
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(257, 16)
        Me.TxtCosto.TabIndex = 2
        Me.TxtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmModificarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(360, 430)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
