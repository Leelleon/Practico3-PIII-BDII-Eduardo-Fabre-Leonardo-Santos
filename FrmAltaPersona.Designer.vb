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
        Me.SuspendLayout()
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(12, 164)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(64, 17)
        Me.LblTelefono.TabIndex = 42
        Me.LblTelefono.Text = "Telefono"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(12, 122)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(33, 17)
        Me.LblMail.TabIndex = 41
        Me.LblMail.Text = "Mail"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(12, 88)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(58, 17)
        Me.LblApellido.TabIndex = 40
        Me.LblApellido.Text = "Apellido"
        '
        'LblPersonaNombre
        '
        Me.LblPersonaNombre.AutoSize = True
        Me.LblPersonaNombre.Location = New System.Drawing.Point(12, 46)
        Me.LblPersonaNombre.Name = "LblPersonaNombre"
        Me.LblPersonaNombre.Size = New System.Drawing.Size(58, 17)
        Me.LblPersonaNombre.TabIndex = 39
        Me.LblPersonaNombre.Text = "Nombre"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(116, 164)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(183, 22)
        Me.TxtTelefono.TabIndex = 3
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(116, 122)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtMail.MaxLength = 50
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(183, 22)
        Me.TxtMail.TabIndex = 2
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(116, 46)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombre.MaxLength = 20
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(183, 22)
        Me.TxtNombre.TabIndex = 0
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(116, 85)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtApellido.MaxLength = 20
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(183, 22)
        Me.TxtApellido.TabIndex = 1
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(63, 414)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(101, 38)
        Me.BtnAceptar.TabIndex = 6
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BtnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.Location = New System.Drawing.Point(232, 414)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(96, 38)
        Me.BtnVolver.TabIndex = 7
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(316, 164)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(96, 34)
        Me.BtnAgregar.TabIndex = 4
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'LstTelefono
        '
        Me.LstTelefono.FormattingEnabled = True
        Me.LstTelefono.ItemHeight = 16
        Me.LstTelefono.Location = New System.Drawing.Point(117, 200)
        Me.LstTelefono.Name = "LstTelefono"
        Me.LstTelefono.Size = New System.Drawing.Size(181, 180)
        Me.LstTelefono.TabIndex = 5
        '
        'FrmAltaPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.CancelButton = Me.BtnVolver
        Me.ClientSize = New System.Drawing.Size(445, 483)
        Me.ControlBox = False
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
End Class
