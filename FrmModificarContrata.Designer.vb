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
        Me.CmbServicios = New System.Windows.Forms.ComboBox()
        Me.LblSeleccion = New System.Windows.Forms.Label()
        Me.DgvContratos = New System.Windows.Forms.DataGridView()
        CType(Me.DgvContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbServicios
        '
        Me.CmbServicios.FormattingEnabled = True
        Me.CmbServicios.Location = New System.Drawing.Point(323, 69)
        Me.CmbServicios.Name = "CmbServicios"
        Me.CmbServicios.Size = New System.Drawing.Size(121, 21)
        Me.CmbServicios.TabIndex = 0
        '
        'LblSeleccion
        '
        Me.LblSeleccion.AutoSize = True
        Me.LblSeleccion.Location = New System.Drawing.Point(320, 33)
        Me.LblSeleccion.Name = "LblSeleccion"
        Me.LblSeleccion.Size = New System.Drawing.Size(117, 13)
        Me.LblSeleccion.TabIndex = 1
        Me.LblSeleccion.Text = "Seleccione un servicio:"
        '
        'DgvContratos
        '
        Me.DgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContratos.Location = New System.Drawing.Point(133, 121)
        Me.DgvContratos.Name = "DgvContratos"
        Me.DgvContratos.Size = New System.Drawing.Size(518, 150)
        Me.DgvContratos.TabIndex = 2
        '
        'FrmModificarContrata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DgvContratos)
        Me.Controls.Add(Me.LblSeleccion)
        Me.Controls.Add(Me.CmbServicios)
        Me.Name = "FrmModificarContrata"
        Me.Text = "FrmModificarContrata"
        CType(Me.DgvContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbServicios As ComboBox
    Friend WithEvents LblSeleccion As Label
    Friend WithEvents DgvContratos As DataGridView
End Class
