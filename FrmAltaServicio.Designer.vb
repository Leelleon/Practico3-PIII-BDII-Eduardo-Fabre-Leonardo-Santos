<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaServicio
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
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.LblCosto = New System.Windows.Forms.Label()
        Me.LblPersonaNombre = New System.Windows.Forms.Label()
        Me.LblPersonaId = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.LblLinea2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(228, 366)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(72, 38)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipo.ForeColor = System.Drawing.Color.White
        Me.LblTipo.Location = New System.Drawing.Point(40, 239)
        Me.LblTipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(33, 18)
        Me.LblTipo.TabIndex = 53
        Me.LblTipo.Text = "Tipo"
        '
        'LblCosto
        '
        Me.LblCosto.AutoSize = True
        Me.LblCosto.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCosto.ForeColor = System.Drawing.Color.White
        Me.LblCosto.Location = New System.Drawing.Point(40, 171)
        Me.LblCosto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCosto.Name = "LblCosto"
        Me.LblCosto.Size = New System.Drawing.Size(41, 18)
        Me.LblCosto.TabIndex = 52
        Me.LblCosto.Text = "Costo"
        '
        'LblPersonaNombre
        '
        Me.LblPersonaNombre.AutoSize = True
        Me.LblPersonaNombre.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPersonaNombre.ForeColor = System.Drawing.Color.White
        Me.LblPersonaNombre.Location = New System.Drawing.Point(40, 104)
        Me.LblPersonaNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPersonaNombre.Name = "LblPersonaNombre"
        Me.LblPersonaNombre.Size = New System.Drawing.Size(53, 18)
        Me.LblPersonaNombre.TabIndex = 51
        Me.LblPersonaNombre.Text = "Nombre"
        '
        'LblPersonaId
        '
        Me.LblPersonaId.AutoSize = True
        Me.LblPersonaId.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPersonaId.ForeColor = System.Drawing.Color.White
        Me.LblPersonaId.Location = New System.Drawing.Point(107, 31)
        Me.LblPersonaId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPersonaId.Name = "LblPersonaId"
        Me.LblPersonaId.Size = New System.Drawing.Size(19, 18)
        Me.LblPersonaId.TabIndex = 50
        Me.LblPersonaId.Text = "Id"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TxtNombre.ForeColor = System.Drawing.Color.White
        Me.TxtNombre.Location = New System.Drawing.Point(43, 129)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtNombre.MaxLength = 20
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(257, 16)
        Me.TxtNombre.TabIndex = 0
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
        Me.TxtCosto.Location = New System.Drawing.Point(43, 190)
        Me.TxtCosto.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtCosto.MaxLength = 20
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(267, 16)
        Me.TxtCosto.TabIndex = 2
        Me.TxtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtId
        '
        Me.TxtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtId.Enabled = False
        Me.TxtId.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtId.ForeColor = System.Drawing.Color.White
        Me.TxtId.Location = New System.Drawing.Point(149, 36)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(47, 25)
        Me.TxtId.TabIndex = 0
        Me.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnAceptar.Location = New System.Drawing.Point(39, 309)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(261, 44)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'CmbTipo
        '
        Me.CmbTipo.BackColor = System.Drawing.Color.White
        Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbTipo.ForeColor = System.Drawing.Color.Black
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Items.AddRange(New Object() {"Limpieza", "Mantenimiento", "Electricidad", "Telecomunicaciones", "Informática"})
        Me.CmbTipo.Location = New System.Drawing.Point(43, 259)
        Me.CmbTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(257, 24)
        Me.CmbTipo.TabIndex = 2
        '
        'LblLinea2
        '
        Me.LblLinea2.BackColor = System.Drawing.Color.White
        Me.LblLinea2.Location = New System.Drawing.Point(43, 205)
        Me.LblLinea2.Name = "LblLinea2"
        Me.LblLinea2.Size = New System.Drawing.Size(257, 1)
        Me.LblLinea2.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 1)
        Me.Label1.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(97, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 1)
        Me.Label2.TabIndex = 1
        '
        'FrmAltaServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(339, 414)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblLinea2)
        Me.Controls.Add(Me.CmbTipo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.LblTipo)
        Me.Controls.Add(Me.LblCosto)
        Me.Controls.Add(Me.LblPersonaNombre)
        Me.Controls.Add(Me.LblPersonaId)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtCosto)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmAltaServicio"
        Me.Text = "Alta de Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblTipo As Label
    Friend WithEvents LblCosto As Label
    Friend WithEvents LblPersonaNombre As Label
    Friend WithEvents LblPersonaId As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCosto As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents LblLinea2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
