<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarContrata
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarContrata))
        Me.CmbServicios = New System.Windows.Forms.ComboBox()
        Me.LblSeleccion = New System.Windows.Forms.Label()
        Me.DgvContratos = New System.Windows.Forms.DataGridView()
        Me.NudDDesde = New System.Windows.Forms.NumericUpDown()
        Me.NudMDesde = New System.Windows.Forms.NumericUpDown()
        Me.NudYDesde = New System.Windows.Forms.NumericUpDown()
        Me.LblDesde = New System.Windows.Forms.Label()
        Me.LblHasta = New System.Windows.Forms.Label()
        Me.NudYHasta = New System.Windows.Forms.NumericUpDown()
        Me.NudMHasta = New System.Windows.Forms.NumericUpDown()
        Me.NudDHasta = New System.Windows.Forms.NumericUpDown()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        CType(Me.DgvContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudDDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudMDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudYDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudYHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudMHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudDHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbServicios
        '
        Me.CmbServicios.BackColor = System.Drawing.Color.LightBlue
        Me.CmbServicios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbServicios.FormattingEnabled = True
        Me.CmbServicios.Items.AddRange(New Object() {"Limpieza", "Mantenimiento", "Electricidad", "Telecomunicaciones", "Informatica"})
        Me.CmbServicios.Location = New System.Drawing.Point(581, 37)
        Me.CmbServicios.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbServicios.Name = "CmbServicios"
        Me.CmbServicios.Size = New System.Drawing.Size(160, 24)
        Me.CmbServicios.TabIndex = 0
        '
        'LblSeleccion
        '
        Me.LblSeleccion.AutoSize = True
        Me.LblSeleccion.BackColor = System.Drawing.Color.Transparent
        Me.LblSeleccion.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeleccion.ForeColor = System.Drawing.SystemColors.Window
        Me.LblSeleccion.Location = New System.Drawing.Point(199, 32)
        Me.LblSeleccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSeleccion.Name = "LblSeleccion"
        Me.LblSeleccion.Size = New System.Drawing.Size(359, 29)
        Me.LblSeleccion.TabIndex = 1
        Me.LblSeleccion.Text = "Seleccione un tipo de servicio:"
        '
        'DgvContratos
        '
        Me.DgvContratos.AllowUserToAddRows = False
        Me.DgvContratos.AllowUserToDeleteRows = False
        Me.DgvContratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvContratos.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DgvContratos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContratos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvContratos.Location = New System.Drawing.Point(65, 154)
        Me.DgvContratos.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvContratos.MultiSelect = False
        Me.DgvContratos.Name = "DgvContratos"
        Me.DgvContratos.ReadOnly = True
        Me.DgvContratos.RowHeadersVisible = False
        Me.DgvContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvContratos.Size = New System.Drawing.Size(929, 103)
        Me.DgvContratos.TabIndex = 2
        '
        'NudDDesde
        '
        Me.NudDDesde.BackColor = System.Drawing.Color.LightBlue
        Me.NudDDesde.Location = New System.Drawing.Point(125, 345)
        Me.NudDDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.NudDDesde.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.NudDDesde.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudDDesde.Name = "NudDDesde"
        Me.NudDDesde.Size = New System.Drawing.Size(68, 22)
        Me.NudDDesde.TabIndex = 3
        Me.NudDDesde.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NudMDesde
        '
        Me.NudMDesde.BackColor = System.Drawing.Color.LightBlue
        Me.NudMDesde.Location = New System.Drawing.Point(222, 345)
        Me.NudMDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.NudMDesde.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NudMDesde.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudMDesde.Name = "NudMDesde"
        Me.NudMDesde.Size = New System.Drawing.Size(68, 22)
        Me.NudMDesde.TabIndex = 4
        Me.NudMDesde.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NudYDesde
        '
        Me.NudYDesde.BackColor = System.Drawing.Color.LightBlue
        Me.NudYDesde.Location = New System.Drawing.Point(312, 345)
        Me.NudYDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.NudYDesde.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NudYDesde.Minimum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.NudYDesde.Name = "NudYDesde"
        Me.NudYDesde.Size = New System.Drawing.Size(103, 22)
        Me.NudYDesde.TabIndex = 5
        Me.NudYDesde.Value = New Decimal(New Integer() {2020, 0, 0, 0})
        '
        'LblDesde
        '
        Me.LblDesde.AutoSize = True
        Me.LblDesde.BackColor = System.Drawing.Color.Transparent
        Me.LblDesde.Font = New System.Drawing.Font("Trebuchet MS", 10.25!)
        Me.LblDesde.ForeColor = System.Drawing.Color.White
        Me.LblDesde.Location = New System.Drawing.Point(43, 345)
        Me.LblDesde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDesde.Name = "LblDesde"
        Me.LblDesde.Size = New System.Drawing.Size(70, 23)
        Me.LblDesde.TabIndex = 6
        Me.LblDesde.Text = "Desde :"
        '
        'LblHasta
        '
        Me.LblHasta.AutoSize = True
        Me.LblHasta.BackColor = System.Drawing.Color.Transparent
        Me.LblHasta.Font = New System.Drawing.Font("Trebuchet MS", 10.25!)
        Me.LblHasta.ForeColor = System.Drawing.Color.White
        Me.LblHasta.Location = New System.Drawing.Point(43, 441)
        Me.LblHasta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblHasta.Name = "LblHasta"
        Me.LblHasta.Size = New System.Drawing.Size(66, 23)
        Me.LblHasta.TabIndex = 10
        Me.LblHasta.Text = "Hasta :"
        '
        'NudYHasta
        '
        Me.NudYHasta.BackColor = System.Drawing.Color.LightBlue
        Me.NudYHasta.Location = New System.Drawing.Point(312, 441)
        Me.NudYHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.NudYHasta.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NudYHasta.Minimum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.NudYHasta.Name = "NudYHasta"
        Me.NudYHasta.Size = New System.Drawing.Size(103, 22)
        Me.NudYHasta.TabIndex = 9
        Me.NudYHasta.Value = New Decimal(New Integer() {2020, 0, 0, 0})
        '
        'NudMHasta
        '
        Me.NudMHasta.BackColor = System.Drawing.Color.LightBlue
        Me.NudMHasta.Location = New System.Drawing.Point(222, 441)
        Me.NudMHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.NudMHasta.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NudMHasta.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudMHasta.Name = "NudMHasta"
        Me.NudMHasta.Size = New System.Drawing.Size(68, 22)
        Me.NudMHasta.TabIndex = 8
        Me.NudMHasta.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NudDHasta
        '
        Me.NudDHasta.BackColor = System.Drawing.Color.LightBlue
        Me.NudDHasta.Location = New System.Drawing.Point(125, 441)
        Me.NudDHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.NudDHasta.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.NudDHasta.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudDHasta.Name = "NudDHasta"
        Me.NudDHasta.Size = New System.Drawing.Size(68, 22)
        Me.NudDHasta.TabIndex = 7
        Me.NudDHasta.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.BackgroundImage = CType(resources.GetObject("BtnModificar.BackgroundImage"), System.Drawing.Image)
        Me.BtnModificar.Enabled = False
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnModificar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnModificar.Location = New System.Drawing.Point(761, 335)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(158, 50)
        Me.BtnModificar.TabIndex = 11
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancelar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(761, 424)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(158, 53)
        Me.BtnCancelar.TabIndex = 12
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'FrmModificarContrata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1050, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.LblHasta)
        Me.Controls.Add(Me.NudYHasta)
        Me.Controls.Add(Me.NudMHasta)
        Me.Controls.Add(Me.NudDHasta)
        Me.Controls.Add(Me.LblDesde)
        Me.Controls.Add(Me.NudYDesde)
        Me.Controls.Add(Me.NudMDesde)
        Me.Controls.Add(Me.NudDDesde)
        Me.Controls.Add(Me.DgvContratos)
        Me.Controls.Add(Me.LblSeleccion)
        Me.Controls.Add(Me.CmbServicios)
        Me.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmModificarContrata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Contrato"
        CType(Me.DgvContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudDDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudMDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudYDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudYHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudMHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudDHasta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbServicios As ComboBox
    Friend WithEvents LblSeleccion As Label
    Friend WithEvents DgvContratos As DataGridView
    Friend WithEvents NudDDesde As NumericUpDown
    Friend WithEvents NudMDesde As NumericUpDown
    Friend WithEvents NudYDesde As NumericUpDown
    Friend WithEvents LblDesde As Label
    Friend WithEvents LblHasta As Label
    Friend WithEvents NudYHasta As NumericUpDown
    Friend WithEvents NudMHasta As NumericUpDown
    Friend WithEvents NudDHasta As NumericUpDown
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnCancelar As Button
End Class
