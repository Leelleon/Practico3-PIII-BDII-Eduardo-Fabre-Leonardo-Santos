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
        'FrmListarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 712)
        Me.Controls.Add(Me.DgvServicios)
        Me.Name = "FrmListarServicio"
        Me.Text = "FrmListarServicio"
        CType(Me.DgvServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvServicios As DataGridView
End Class
