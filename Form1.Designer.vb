<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TpgPersonas = New System.Windows.Forms.TabPage()
        Me.TpgServicios = New System.Windows.Forms.TabPage()
        Me.TpgContratos = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblActivo = New System.Windows.Forms.Label()
        Me.CbxBaja = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TpgPersonas.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TpgPersonas)
        Me.TabControl1.Controls.Add(Me.TpgServicios)
        Me.TabControl1.Controls.Add(Me.TpgContratos)
        Me.TabControl1.Location = New System.Drawing.Point(-3, -2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1150, 573)
        Me.TabControl1.TabIndex = 0
        '
        'TpgPersonas
        '
        Me.TpgPersonas.Controls.Add(Me.CbxBaja)
        Me.TpgPersonas.Controls.Add(Me.LblActivo)
        Me.TpgPersonas.Controls.Add(Me.LblTelefono)
        Me.TpgPersonas.Controls.Add(Me.LblMail)
        Me.TpgPersonas.Controls.Add(Me.LblApellido)
        Me.TpgPersonas.Controls.Add(Me.LblNombre)
        Me.TpgPersonas.Controls.Add(Me.LblId)
        Me.TpgPersonas.Controls.Add(Me.TxtTelefono)
        Me.TpgPersonas.Controls.Add(Me.TxtMail)
        Me.TpgPersonas.Controls.Add(Me.TxtNombre)
        Me.TpgPersonas.Controls.Add(Me.TxtApellido)
        Me.TpgPersonas.Controls.Add(Me.TxtId)
        Me.TpgPersonas.Controls.Add(Me.Button3)
        Me.TpgPersonas.Controls.Add(Me.BtnInsertar)
        Me.TpgPersonas.Controls.Add(Me.BtnCancelar)
        Me.TpgPersonas.Controls.Add(Me.BtnAceptar)
        Me.TpgPersonas.Controls.Add(Me.DataGridView1)
        Me.TpgPersonas.Location = New System.Drawing.Point(4, 29)
        Me.TpgPersonas.Name = "TpgPersonas"
        Me.TpgPersonas.Padding = New System.Windows.Forms.Padding(3)
        Me.TpgPersonas.Size = New System.Drawing.Size(1142, 540)
        Me.TpgPersonas.TabIndex = 0
        Me.TpgPersonas.Text = "Personas"
        Me.TpgPersonas.UseVisualStyleBackColor = True
        '
        'TpgServicios
        '
        Me.TpgServicios.Location = New System.Drawing.Point(4, 29)
        Me.TpgServicios.Name = "TpgServicios"
        Me.TpgServicios.Size = New System.Drawing.Size(1142, 540)
        Me.TpgServicios.TabIndex = 2
        Me.TpgServicios.Text = "Servicios"
        Me.TpgServicios.UseVisualStyleBackColor = True
        '
        'TpgContratos
        '
        Me.TpgContratos.Location = New System.Drawing.Point(4, 29)
        Me.TpgContratos.Name = "TpgContratos"
        Me.TpgContratos.Size = New System.Drawing.Size(1142, 540)
        Me.TpgContratos.TabIndex = 3
        Me.TpgContratos.Text = "Contratos"
        Me.TpgContratos.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(582, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(368, 466)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.Location = New System.Drawing.Point(78, 455)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(114, 47)
        Me.BtnAceptar.TabIndex = 1
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.Location = New System.Drawing.Point(198, 455)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(108, 47)
        Me.BtnCancelar.TabIndex = 2
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Enabled = False
        Me.BtnInsertar.Location = New System.Drawing.Point(390, 191)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(116, 37)
        Me.BtnInsertar.TabIndex = 3
        Me.BtnInsertar.Text = "Añadir =>"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(390, 295)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 37)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "<= Modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(84, 53)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(68, 26)
        Me.TxtId.TabIndex = 5
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(84, 214)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(205, 26)
        Me.TxtApellido.TabIndex = 6
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(84, 126)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(205, 26)
        Me.TxtNombre.TabIndex = 7
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(84, 306)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(205, 26)
        Me.TxtMail.TabIndex = 8
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(84, 391)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(205, 26)
        Me.TxtTelefono.TabIndex = 9
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(52, 26)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(23, 20)
        Me.LblId.TabIndex = 10
        Me.LblId.Text = "Id"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(52, 103)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(65, 20)
        Me.LblNombre.TabIndex = 11
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(52, 191)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(65, 20)
        Me.LblApellido.TabIndex = 12
        Me.LblApellido.Text = "Apellido"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(52, 283)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(37, 20)
        Me.LblMail.TabIndex = 13
        Me.LblMail.Text = "Mail"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(52, 368)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(71, 20)
        Me.LblTelefono.TabIndex = 14
        Me.LblTelefono.Text = "Telefono"
        '
        'LblActivo
        '
        Me.LblActivo.AutoSize = True
        Me.LblActivo.Location = New System.Drawing.Point(196, 26)
        Me.LblActivo.Name = "LblActivo"
        Me.LblActivo.Size = New System.Drawing.Size(93, 20)
        Me.LblActivo.TabIndex = 15
        Me.LblActivo.Text = "Dar de Baja"
        '
        'CbxBaja
        '
        Me.CbxBaja.AutoSize = True
        Me.CbxBaja.Location = New System.Drawing.Point(227, 54)
        Me.CbxBaja.Name = "CbxBaja"
        Me.CbxBaja.Size = New System.Drawing.Size(22, 21)
        Me.CbxBaja.TabIndex = 16
        Me.CbxBaja.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 567)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TpgPersonas.ResumeLayout(False)
        Me.TpgPersonas.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpgPersonas As TabPage
    Friend WithEvents TpgServicios As TabPage
    Friend WithEvents TpgContratos As TabPage
    Friend WithEvents CbxBaja As CheckBox
    Friend WithEvents LblActivo As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblId As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
