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
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnRefrescar = New System.Windows.Forms.Button()
        CType(Me.DgvServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvServicios
        '
        Me.DgvServicios.AllowUserToAddRows = False
        Me.DgvServicios.AllowUserToDeleteRows = False
        Me.DgvServicios.BackgroundColor = System.Drawing.Color.White
        Me.DgvServicios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DgvServicios.Location = New System.Drawing.Point(37, 88)
        Me.DgvServicios.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvServicios.Name = "DgvServicios"
        Me.DgvServicios.RowHeadersVisible = False
        Me.DgvServicios.RowTemplate.Height = 28
        Me.DgvServicios.Size = New System.Drawing.Size(492, 348)
        Me.DgvServicios.TabIndex = 0
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.Gray
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVolver.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.Location = New System.Drawing.Point(152, 21)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(109, 36)
        Me.BtnVolver.TabIndex = 1
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'BtnRefrescar
        '
        Me.BtnRefrescar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnRefrescar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefrescar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnRefrescar.Location = New System.Drawing.Point(37, 21)
        Me.BtnRefrescar.Name = "BtnRefrescar"
        Me.BtnRefrescar.Size = New System.Drawing.Size(109, 36)
        Me.BtnRefrescar.TabIndex = 0
        Me.BtnRefrescar.Text = "Refrescar"
        Me.BtnRefrescar.UseVisualStyleBackColor = False
        '
        'FrmListarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(567, 463)
        Me.Controls.Add(Me.BtnRefrescar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.DgvServicios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmListarServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmListarServicio"
        CType(Me.DgvServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvServicios As DataGridView
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnRefrescar As Button
End Class
