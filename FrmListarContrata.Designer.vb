<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListarContrata
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
        Me.DgvContratos = New System.Windows.Forms.DataGridView()
        Me.BtnVolver = New System.Windows.Forms.Button()
        CType(Me.DgvContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvContratos
        '
        Me.DgvContratos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvContratos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContratos.Location = New System.Drawing.Point(21, 26)
        Me.DgvContratos.MultiSelect = False
        Me.DgvContratos.Name = "DgvContratos"
        Me.DgvContratos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvContratos.RowHeadersVisible = False
        Me.DgvContratos.Size = New System.Drawing.Size(765, 332)
        Me.DgvContratos.TabIndex = 0
        '
        'BtnVolver
        '
        Me.BtnVolver.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.Location = New System.Drawing.Point(21, 374)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(127, 43)
        Me.BtnVolver.TabIndex = 1
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'FrmListarContrata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(809, 429)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.DgvContratos)
        Me.Name = "FrmListarContrata"
        Me.Text = "FrmListarContrata"
        CType(Me.DgvContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvContratos As DataGridView
    Friend WithEvents BtnVolver As Button
End Class
