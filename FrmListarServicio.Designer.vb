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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListarServicio))
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
        Me.DgvServicios.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DgvServicios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DgvServicios.Location = New System.Drawing.Point(12, 101)
        Me.DgvServicios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvServicios.Name = "DgvServicios"
        Me.DgvServicios.RowHeadersVisible = False
        Me.DgvServicios.RowTemplate.Height = 28
        Me.DgvServicios.Size = New System.Drawing.Size(1026, 420)
        Me.DgvServicios.TabIndex = 0
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.Transparent
        Me.BtnVolver.BackgroundImage = CType(resources.GetObject("BtnVolver.BackgroundImage"), System.Drawing.Image)
        Me.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVolver.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.Location = New System.Drawing.Point(822, 26)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(178, 44)
        Me.BtnVolver.TabIndex = 1
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'BtnRefrescar
        '
        Me.BtnRefrescar.BackColor = System.Drawing.Color.Transparent
        Me.BtnRefrescar.BackgroundImage = CType(resources.GetObject("BtnRefrescar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRefrescar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnRefrescar.ForeColor = System.Drawing.Color.White
        Me.BtnRefrescar.Location = New System.Drawing.Point(83, 26)
        Me.BtnRefrescar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnRefrescar.Name = "BtnRefrescar"
        Me.BtnRefrescar.Size = New System.Drawing.Size(178, 44)
        Me.BtnRefrescar.TabIndex = 0
        Me.BtnRefrescar.Text = "Refrescar"
        Me.BtnRefrescar.UseVisualStyleBackColor = False
        '
        'FrmListarServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1050, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnRefrescar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.DgvServicios)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmListarServicio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar Servicio"
        CType(Me.DgvServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvServicios As DataGridView
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnRefrescar As Button
End Class
