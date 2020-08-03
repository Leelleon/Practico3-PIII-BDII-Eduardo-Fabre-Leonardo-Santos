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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListarContrata))
        Me.DgvContratos = New System.Windows.Forms.DataGridView()
        Me.BtnVolver = New System.Windows.Forms.Button()
        CType(Me.DgvContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvContratos
        '
        Me.DgvContratos.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DgvContratos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvContratos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContratos.Location = New System.Drawing.Point(13, 110)
        Me.DgvContratos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DgvContratos.MultiSelect = False
        Me.DgvContratos.Name = "DgvContratos"
        Me.DgvContratos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvContratos.RowHeadersVisible = False
        Me.DgvContratos.Size = New System.Drawing.Size(1020, 409)
        Me.DgvContratos.TabIndex = 0
        '
        'BtnVolver
        '
        Me.BtnVolver.BackgroundImage = CType(resources.GetObject("BtnVolver.BackgroundImage"), System.Drawing.Image)
        Me.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVolver.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.Location = New System.Drawing.Point(838, 34)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(178, 44)
        Me.BtnVolver.TabIndex = 1
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'FrmListarContrata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1050, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.DgvContratos)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmListarContrata"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar Contrato"
        CType(Me.DgvContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvContratos As DataGridView
    Friend WithEvents BtnVolver As Button
End Class
