<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaContrata
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
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.CmbUsuario = New System.Windows.Forms.ComboBox()
        Me.CmbServicio = New System.Windows.Forms.ComboBox()
        Me.LblPersona = New System.Windows.Forms.Label()
        Me.LblServicio = New System.Windows.Forms.Label()
        Me.LblDesde = New System.Windows.Forms.Label()
        Me.LblHasta = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Location = New System.Drawing.Point(160, 231)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(0, 16)
        Me.LblDescripcion.TabIndex = 0
        '
        'CmbUsuario
        '
        Me.CmbUsuario.FormattingEnabled = True
        Me.CmbUsuario.Location = New System.Drawing.Point(68, 97)
        Me.CmbUsuario.Name = "CmbUsuario"
        Me.CmbUsuario.Size = New System.Drawing.Size(121, 24)
        Me.CmbUsuario.TabIndex = 1
        '
        'CmbServicio
        '
        Me.CmbServicio.FormattingEnabled = True
        Me.CmbServicio.Location = New System.Drawing.Point(234, 97)
        Me.CmbServicio.Name = "CmbServicio"
        Me.CmbServicio.Size = New System.Drawing.Size(121, 24)
        Me.CmbServicio.TabIndex = 2
        '
        'LblPersona
        '
        Me.LblPersona.AutoSize = True
        Me.LblPersona.Location = New System.Drawing.Point(102, 56)
        Me.LblPersona.Name = "LblPersona"
        Me.LblPersona.Size = New System.Drawing.Size(46, 16)
        Me.LblPersona.TabIndex = 3
        Me.LblPersona.Text = "Usuario"
        '
        'LblServicio
        '
        Me.LblServicio.AutoSize = True
        Me.LblServicio.Location = New System.Drawing.Point(267, 56)
        Me.LblServicio.Name = "LblServicio"
        Me.LblServicio.Size = New System.Drawing.Size(48, 16)
        Me.LblServicio.TabIndex = 4
        Me.LblServicio.Text = "Servicio"
        '
        'LblDesde
        '
        Me.LblDesde.AutoSize = True
        Me.LblDesde.Location = New System.Drawing.Point(490, 60)
        Me.LblDesde.Name = "LblDesde"
        Me.LblDesde.Size = New System.Drawing.Size(38, 16)
        Me.LblDesde.TabIndex = 5
        Me.LblDesde.Text = "Desde"
        '
        'LblHasta
        '
        Me.LblHasta.AutoSize = True
        Me.LblHasta.Location = New System.Drawing.Point(630, 60)
        Me.LblHasta.Name = "LblHasta"
        Me.LblHasta.Size = New System.Drawing.Size(37, 16)
        Me.LblHasta.TabIndex = 6
        Me.LblHasta.Text = "Hasta"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(395, 85)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 7
        '
        'FrmAltaContrata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 375)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.LblHasta)
        Me.Controls.Add(Me.LblDesde)
        Me.Controls.Add(Me.LblServicio)
        Me.Controls.Add(Me.LblPersona)
        Me.Controls.Add(Me.CmbServicio)
        Me.Controls.Add(Me.CmbUsuario)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmAltaContrata"
        Me.Text = "FrmAltaContrata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDescripcion As Label
    Friend WithEvents CmbUsuario As ComboBox
    Friend WithEvents CmbServicio As ComboBox
    Friend WithEvents LblPersona As Label
    Friend WithEvents LblServicio As Label
    Friend WithEvents LblDesde As Label
    Friend WithEvents LblHasta As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
