<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListarServicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DgvServicios = New System.Windows.Forms.DataGridView()
        Me.BtnAscendente = New System.Windows.Forms.Button()
        Me.BtnDescendente = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.LblDesde = New System.Windows.Forms.Label()
        Me.LblHasta = New System.Windows.Forms.Label()
        CType(Me.DgvServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvServicios
        '
        Me.DgvServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DgvServicios.Location = New System.Drawing.Point(46, 142)
        Me.DgvServicios.Name = "DgvServicios"
        Me.DgvServicios.RowHeadersVisible = False
        Me.DgvServicios.RowTemplate.Height = 28
        Me.DgvServicios.Size = New System.Drawing.Size(590, 527)
        Me.DgvServicios.TabIndex = 0
        '
        'BtnAscendente
        '
        Me.BtnAscendente.Location = New System.Drawing.Point(690, 142)
        Me.BtnAscendente.Name = "BtnAscendente"
        Me.BtnAscendente.Size = New System.Drawing.Size(120, 52)
        Me.BtnAscendente.TabIndex = 1
        Me.BtnAscendente.Text = "Ascendente"
        Me.BtnAscendente.UseVisualStyleBackColor = True
        '
        'BtnDescendente
        '
        Me.BtnDescendente.Location = New System.Drawing.Point(690, 215)
        Me.BtnDescendente.Name = "BtnDescendente"
        Me.BtnDescendente.Size = New System.Drawing.Size(120, 52)
        Me.BtnDescendente.TabIndex = 2
        Me.BtnDescendente.Text = "Descendente"
        Me.BtnDescendente.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(690, 309)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 48)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(690, 376)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 50)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(690, 466)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 41)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DtpDesde
        '
        Me.DtpDesde.Location = New System.Drawing.Point(46, 70)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(292, 26)
        Me.DtpDesde.TabIndex = 7
        '
        'DtpHasta
        '
        Me.DtpHasta.Location = New System.Drawing.Point(344, 70)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(292, 26)
        Me.DtpHasta.TabIndex = 8
        '
        'LblDesde
        '
        Me.LblDesde.AutoSize = True
        Me.LblDesde.Location = New System.Drawing.Point(158, 31)
        Me.LblDesde.Name = "LblDesde"
        Me.LblDesde.Size = New System.Drawing.Size(68, 20)
        Me.LblDesde.TabIndex = 9
        Me.LblDesde.Text = "Desde..."
        '
        'LblHasta
        '
        Me.LblHasta.AutoSize = True
        Me.LblHasta.Location = New System.Drawing.Point(458, 31)
        Me.LblHasta.Name = "LblHasta"
        Me.LblHasta.Size = New System.Drawing.Size(64, 20)
        Me.LblHasta.TabIndex = 10
        Me.LblHasta.Text = "...Hasta"
        '
        'FrmListarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 712)
        Me.Controls.Add(Me.LblHasta)
        Me.Controls.Add(Me.LblDesde)
        Me.Controls.Add(Me.DtpHasta)
        Me.Controls.Add(Me.DtpDesde)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnDescendente)
        Me.Controls.Add(Me.BtnAscendente)
        Me.Controls.Add(Me.DgvServicios)
        Me.Name = "FrmListarServicio"
        Me.Text = "FrmListarServicio"
        CType(Me.DgvServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvServicios As DataGridView
    Friend WithEvents BtnAscendente As Button
    Friend WithEvents BtnDescendente As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DtpDesde As DateTimePicker
    Friend WithEvents DtpHasta As DateTimePicker
    Friend WithEvents LblDesde As Label
    Friend WithEvents LblHasta As Label
End Class
