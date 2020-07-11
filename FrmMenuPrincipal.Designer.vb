<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlPersona = New System.Windows.Forms.Panel()
        Me.CbxBaja = New System.Windows.Forms.CheckBox()
        Me.LblActivo = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblPersonaNombre = New System.Windows.Forms.Label()
        Me.LblPersonaId = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtPersonaId = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.PnlPersona.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ServiciosToolStripMenuItem, Me.ContratosToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1145, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.ListarToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(94, 29)
        Me.ToolStripMenuItem1.Text = "Personas"
        '
        'NToolStripMenuItem
        '
        Me.NToolStripMenuItem.Name = "NToolStripMenuItem"
        Me.NToolStripMenuItem.Size = New System.Drawing.Size(171, 30)
        Me.NToolStripMenuItem.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(171, 30)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(171, 30)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(171, 30)
        Me.ListarToolStripMenuItem.Text = "Listar"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ModificarToolStripMenuItem1, Me.EliminarToolStripMenuItem1, Me.ListarToolStripMenuItem1})
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(93, 29)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem1
        '
        Me.ModificarToolStripMenuItem1.Name = "ModificarToolStripMenuItem1"
        Me.ModificarToolStripMenuItem1.Size = New System.Drawing.Size(252, 30)
        Me.ModificarToolStripMenuItem1.Text = "Modificar"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(252, 30)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'ListarToolStripMenuItem1
        '
        Me.ListarToolStripMenuItem1.Name = "ListarToolStripMenuItem1"
        Me.ListarToolStripMenuItem1.Size = New System.Drawing.Size(252, 30)
        Me.ListarToolStripMenuItem1.Text = "Listar"
        '
        'ContratosToolStripMenuItem
        '
        Me.ContratosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem1, Me.ModificarToolStripMenuItem2, Me.ListarToolStripMenuItem2, Me.EliminarToolStripMenuItem2})
        Me.ContratosToolStripMenuItem.Name = "ContratosToolStripMenuItem"
        Me.ContratosToolStripMenuItem.Size = New System.Drawing.Size(102, 29)
        Me.ContratosToolStripMenuItem.Text = "Contratos"
        '
        'NuevoToolStripMenuItem1
        '
        Me.NuevoToolStripMenuItem1.Name = "NuevoToolStripMenuItem1"
        Me.NuevoToolStripMenuItem1.Size = New System.Drawing.Size(171, 30)
        Me.NuevoToolStripMenuItem1.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem2
        '
        Me.ModificarToolStripMenuItem2.Name = "ModificarToolStripMenuItem2"
        Me.ModificarToolStripMenuItem2.Size = New System.Drawing.Size(171, 30)
        Me.ModificarToolStripMenuItem2.Text = "Modificar"
        '
        'ListarToolStripMenuItem2
        '
        Me.ListarToolStripMenuItem2.Name = "ListarToolStripMenuItem2"
        Me.ListarToolStripMenuItem2.Size = New System.Drawing.Size(171, 30)
        Me.ListarToolStripMenuItem2.Text = "Listar"
        '
        'EliminarToolStripMenuItem2
        '
        Me.EliminarToolStripMenuItem2.Name = "EliminarToolStripMenuItem2"
        Me.EliminarToolStripMenuItem2.Size = New System.Drawing.Size(171, 30)
        Me.EliminarToolStripMenuItem2.Text = "Eliminar"
        '
        'PnlPersona
        '
        Me.PnlPersona.Controls.Add(Me.CbxBaja)
        Me.PnlPersona.Controls.Add(Me.LblActivo)
        Me.PnlPersona.Controls.Add(Me.LblTelefono)
        Me.PnlPersona.Controls.Add(Me.LblMail)
        Me.PnlPersona.Controls.Add(Me.LblApellido)
        Me.PnlPersona.Controls.Add(Me.LblPersonaNombre)
        Me.PnlPersona.Controls.Add(Me.LblPersonaId)
        Me.PnlPersona.Controls.Add(Me.TxtTelefono)
        Me.PnlPersona.Controls.Add(Me.TxtMail)
        Me.PnlPersona.Controls.Add(Me.TxtNombre)
        Me.PnlPersona.Controls.Add(Me.TxtApellido)
        Me.PnlPersona.Controls.Add(Me.TxtPersonaId)
        Me.PnlPersona.Controls.Add(Me.Button3)
        Me.PnlPersona.Controls.Add(Me.BtnInsertar)
        Me.PnlPersona.Controls.Add(Me.BtnCancelar)
        Me.PnlPersona.Controls.Add(Me.BtnAceptar)
        Me.PnlPersona.Controls.Add(Me.DataGridView1)
        Me.PnlPersona.Location = New System.Drawing.Point(0, 38)
        Me.PnlPersona.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PnlPersona.Name = "PnlPersona"
        Me.PnlPersona.Size = New System.Drawing.Size(1133, 518)
        Me.PnlPersona.TabIndex = 1
        Me.PnlPersona.Visible = False
        '
        'CbxBaja
        '
        Me.CbxBaja.AutoSize = True
        Me.CbxBaja.Location = New System.Drawing.Point(266, 49)
        Me.CbxBaja.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CbxBaja.Name = "CbxBaja"
        Me.CbxBaja.Size = New System.Drawing.Size(22, 21)
        Me.CbxBaja.TabIndex = 33
        Me.CbxBaja.UseVisualStyleBackColor = True
        '
        'LblActivo
        '
        Me.LblActivo.AutoSize = True
        Me.LblActivo.Location = New System.Drawing.Point(234, 21)
        Me.LblActivo.Name = "LblActivo"
        Me.LblActivo.Size = New System.Drawing.Size(93, 20)
        Me.LblActivo.TabIndex = 32
        Me.LblActivo.Text = "Dar de Baja"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(90, 362)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(71, 20)
        Me.LblTelefono.TabIndex = 31
        Me.LblTelefono.Text = "Telefono"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(90, 278)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(37, 20)
        Me.LblMail.TabIndex = 30
        Me.LblMail.Text = "Mail"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(90, 186)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(65, 20)
        Me.LblApellido.TabIndex = 29
        Me.LblApellido.Text = "Apellido"
        '
        'LblPersonaNombre
        '
        Me.LblPersonaNombre.AutoSize = True
        Me.LblPersonaNombre.Location = New System.Drawing.Point(90, 98)
        Me.LblPersonaNombre.Name = "LblPersonaNombre"
        Me.LblPersonaNombre.Size = New System.Drawing.Size(65, 20)
        Me.LblPersonaNombre.TabIndex = 28
        Me.LblPersonaNombre.Text = "Nombre"
        '
        'LblPersonaId
        '
        Me.LblPersonaId.AutoSize = True
        Me.LblPersonaId.Location = New System.Drawing.Point(90, 21)
        Me.LblPersonaId.Name = "LblPersonaId"
        Me.LblPersonaId.Size = New System.Drawing.Size(23, 20)
        Me.LblPersonaId.TabIndex = 27
        Me.LblPersonaId.Text = "Id"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(122, 386)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(205, 26)
        Me.TxtTelefono.TabIndex = 26
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(122, 301)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(205, 26)
        Me.TxtMail.TabIndex = 25
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(122, 121)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(205, 26)
        Me.TxtNombre.TabIndex = 24
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(122, 209)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(205, 26)
        Me.TxtApellido.TabIndex = 23
        '
        'TxtPersonaId
        '
        Me.TxtPersonaId.Enabled = False
        Me.TxtPersonaId.Location = New System.Drawing.Point(122, 48)
        Me.TxtPersonaId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPersonaId.Name = "TxtPersonaId"
        Me.TxtPersonaId.Size = New System.Drawing.Size(68, 26)
        Me.TxtPersonaId.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(428, 290)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 38)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "<= Modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Enabled = False
        Me.BtnInsertar.Location = New System.Drawing.Point(428, 186)
        Me.BtnInsertar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(116, 38)
        Me.BtnInsertar.TabIndex = 20
        Me.BtnInsertar.Text = "Añadir =>"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.Location = New System.Drawing.Point(236, 450)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(108, 48)
        Me.BtnCancelar.TabIndex = 19
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.Location = New System.Drawing.Point(116, 450)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(114, 48)
        Me.BtnAceptar.TabIndex = 18
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(620, 31)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(368, 466)
        Me.DataGridView1.TabIndex = 17
        '
        'FrmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 568)
        Me.Controls.Add(Me.PnlPersona)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmMenuPrincipal"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PnlPersona.ResumeLayout(False)
        Me.PnlPersona.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PnlPersona As Panel
    Friend WithEvents CbxBaja As CheckBox
    Friend WithEvents LblActivo As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblPersonaNombre As Label
    Friend WithEvents LblPersonaId As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtPersonaId As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem2 As ToolStripMenuItem
End Class
