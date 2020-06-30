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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
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
        Me.LblId.Location = New System.Drawing.Point(31, 58)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(195, 13)
        Me.LblId.TabIndex = 0
        Me.LblId.Text = "Seleccione el ID del servicio a modificar"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(274, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(70, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(148, 135)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(121, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'TxtCosto
        '
        Me.TxtCosto.Location = New System.Drawing.Point(148, 205)
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(121, 20)
        Me.TxtCosto.TabIndex = 3
        '
        'CmbTipo
        '
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Items.AddRange(New Object() {"Limpieza", "Mantenimiento", "Electricidad", "Telecomunicaciones", "Informática"})
        Me.CmbTipo.Location = New System.Drawing.Point(148, 271)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.CmbTipo.TabIndex = 4
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(69, 118)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 5
        Me.LblNombre.Text = "Nombre"
        '
        'LblCosto
        '
        Me.LblCosto.AutoSize = True
        Me.LblCosto.Location = New System.Drawing.Point(69, 184)
        Me.LblCosto.Name = "LblCosto"
        Me.LblCosto.Size = New System.Drawing.Size(77, 13)
        Me.LblCosto.TabIndex = 6
        Me.LblCosto.Text = "Costo Menusal"
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Location = New System.Drawing.Point(69, 243)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(28, 13)
        Me.LblTipo.TabIndex = 7
        Me.LblTipo.Text = "Tipo"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(53, 337)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(93, 31)
        Me.BtnAceptar.TabIndex = 8
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(152, 337)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(93, 31)
        Me.BtnCancelar.TabIndex = 9
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(251, 337)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(93, 31)
        Me.BtnVolver.TabIndex = 10
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'FrmModificarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 430)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LblTipo)
        Me.Controls.Add(Me.LblCosto)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.CmbTipo)
        Me.Controls.Add(Me.TxtCosto)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LblId)
        Me.Name = "FrmModificarServicio"
        Me.Text = "FrmModificarServicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblId As Label
    Friend WithEvents ComboBox1 As ComboBox
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
