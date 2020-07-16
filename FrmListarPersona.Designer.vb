<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListarPersona
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
        Me.DgvListaPersona = New System.Windows.Forms.DataGridView()
        Me.BtnListar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        CType(Me.DgvListaPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvListaPersona
        '
        Me.DgvListaPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListaPersona.Location = New System.Drawing.Point(12, 26)
        Me.DgvListaPersona.Name = "DgvListaPersona"
        Me.DgvListaPersona.RowTemplate.Height = 24
        Me.DgvListaPersona.Size = New System.Drawing.Size(619, 307)
        Me.DgvListaPersona.TabIndex = 0
        '
        'BtnListar
        '
        Me.BtnListar.Location = New System.Drawing.Point(62, 372)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(140, 42)
        Me.BtnListar.TabIndex = 1
        Me.BtnListar.Text = "Listar"
        Me.BtnListar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnVolver.Location = New System.Drawing.Point(440, 366)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(139, 48)
        Me.BtnVolver.TabIndex = 2
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'FrmListarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.CancelButton = Me.BtnVolver
        Me.ClientSize = New System.Drawing.Size(643, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnListar)
        Me.Controls.Add(Me.DgvListaPersona)
        Me.Name = "FrmListarPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar Personas"
        CType(Me.DgvListaPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvListaPersona As DataGridView
    Friend WithEvents BtnListar As Button
    Friend WithEvents BtnVolver As Button
End Class
