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
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblCosto = New System.Windows.Forms.Label()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(46, 89)
        Me.LblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(286, 20)
        Me.LblId.TabIndex = 0
        Me.LblId.Text = "Seleccione el ID del servicio a modificar"
        '
        'CmbId
        '
        Me.CmbId.FormattingEnabled = True
        Me.CmbId.Location = New System.Drawing.Point(411, 85)
        Me.CmbId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbId.Name = "CmbId"
        Me.CmbId.Size = New System.Drawing.Size(103, 28)
        Me.CmbId.TabIndex = 0
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(222, 208)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(180, 26)
        Me.TxtNombre.TabIndex = 1
        '
        'TxtCosto
        '
        Me.TxtCosto.Location = New System.Drawing.Point(222, 315)
        Me.TxtCosto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(180, 26)
        Me.TxtCosto.TabIndex = 2
        '
        'CmbTipo
        '
        Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Items.AddRange(New Object() {"Limpieza", "Mantenimiento", "Electricidad", "Telecomunicaciones", "Informática"})
        Me.CmbTipo.Location = New System.Drawing.Point(222, 417)
        Me.CmbTipo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(180, 28)
        Me.CmbTipo.TabIndex = 3
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(104, 182)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(65, 20)
        Me.LblNombre.TabIndex = 5
        Me.LblNombre.Text = "Nombre"
        '
        'LblCosto
        '
        Me.LblCosto.AutoSize = True
        Me.LblCosto.Location = New System.Drawing.Point(104, 283)
        Me.LblCosto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCosto.Name = "LblCosto"
        Me.LblCosto.Size = New System.Drawing.Size(115, 20)
        Me.LblCosto.TabIndex = 6
        Me.LblCosto.Text = "Costo Menusal"
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Location = New System.Drawing.Point(104, 374)
        Me.LblTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(39, 20)
        Me.LblTipo.TabIndex = 7
        Me.LblTipo.Text = "Tipo"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(80, 518)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(140, 48)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(228, 518)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(140, 48)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(376, 518)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(140, 48)
        Me.BtnVolver.TabIndex = 6
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'FrmModificarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 662)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LblTipo)
        Me.Controls.Add(Me.LblCosto)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.CmbTipo)
        Me.Controls.Add(Me.TxtCosto)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.CmbId)
        Me.Controls.Add(Me.LblId)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmModificarServicio"
        Me.Text = "FrmModificarServicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblId As Label
    Friend WithEvents CmbId As ComboBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCosto As TextBox
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblCosto As Label
    Friend WithEvents LblTipo As Label
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnVolver As Button
End Class
