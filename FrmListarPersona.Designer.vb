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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListarPersona))
        Me.DgvListaPersona = New System.Windows.Forms.DataGridView()
        Me.BtnListar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        CType(Me.DgvListaPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvListaPersona
        '
        Me.DgvListaPersona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvListaPersona.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvListaPersona.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DgvListaPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListaPersona.Location = New System.Drawing.Point(137, 109)
        Me.DgvListaPersona.Name = "DgvListaPersona"
        Me.DgvListaPersona.ReadOnly = True
        Me.DgvListaPersona.RowTemplate.Height = 24
        Me.DgvListaPersona.Size = New System.Drawing.Size(797, 411)
        Me.DgvListaPersona.TabIndex = 0
        '
        'BtnListar
        '
        Me.BtnListar.BackColor = System.Drawing.Color.Transparent
        Me.BtnListar.BackgroundImage = CType(resources.GetObject("BtnListar.BackgroundImage"), System.Drawing.Image)
        Me.BtnListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnListar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnListar.ForeColor = System.Drawing.Color.White
        Me.BtnListar.Location = New System.Drawing.Point(119, 33)
        Me.BtnListar.Name = "BtnListar"
        Me.BtnListar.Size = New System.Drawing.Size(178, 44)
        Me.BtnListar.TabIndex = 1
        Me.BtnListar.Text = "Listar"
        Me.BtnListar.UseVisualStyleBackColor = False
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.Transparent
        Me.BtnVolver.BackgroundImage = CType(resources.GetObject("BtnVolver.BackgroundImage"), System.Drawing.Image)
        Me.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVolver.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.Location = New System.Drawing.Point(782, 33)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(178, 44)
        Me.BtnVolver.TabIndex = 2
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'FrmListarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnVolver
        Me.ClientSize = New System.Drawing.Size(1050, 532)
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
