<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaServicio
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
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.LblCosto = New System.Windows.Forms.Label()
        Me.LblPersonaNombre = New System.Windows.Forms.Label()
        Me.LblPersonaId = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Location = New System.Drawing.Point(280, 362)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(108, 48)
        Me.BtnCancelar.TabIndex = 55
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Location = New System.Drawing.Point(89, 267)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(39, 20)
        Me.LblTipo.TabIndex = 53
        Me.LblTipo.Text = "Tipo"
        '
        'LblCosto
        '
        Me.LblCosto.AutoSize = True
        Me.LblCosto.Location = New System.Drawing.Point(89, 201)
        Me.LblCosto.Name = "LblCosto"
        Me.LblCosto.Size = New System.Drawing.Size(51, 20)
        Me.LblCosto.TabIndex = 52
        Me.LblCosto.Text = "Costo"
        '
        'LblPersonaNombre
        '
        Me.LblPersonaNombre.AutoSize = True
        Me.LblPersonaNombre.Location = New System.Drawing.Point(89, 129)
        Me.LblPersonaNombre.Name = "LblPersonaNombre"
        Me.LblPersonaNombre.Size = New System.Drawing.Size(65, 20)
        Me.LblPersonaNombre.TabIndex = 51
        Me.LblPersonaNombre.Text = "Nombre"
        '
        'LblPersonaId
        '
        Me.LblPersonaId.AutoSize = True
        Me.LblPersonaId.Location = New System.Drawing.Point(89, 60)
        Me.LblPersonaId.Name = "LblPersonaId"
        Me.LblPersonaId.Size = New System.Drawing.Size(23, 20)
        Me.LblPersonaId.TabIndex = 50
        Me.LblPersonaId.Text = "Id"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(206, 129)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombre.MaxLength = 20
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(205, 26)
        Me.TxtNombre.TabIndex = 47
        '
        'TxtCosto
        '
        Me.TxtCosto.Location = New System.Drawing.Point(206, 195)
        Me.TxtCosto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCosto.MaxLength = 20
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(205, 26)
        Me.TxtCosto.TabIndex = 46
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(206, 60)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(68, 26)
        Me.TxtId.TabIndex = 45
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(133, 359)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(125, 55)
        Me.BtnAceptar.TabIndex = 44
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'CmbTipo
        '
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Location = New System.Drawing.Point(206, 258)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(205, 28)
        Me.CmbTipo.TabIndex = 56
        '
        'FrmAltaServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 461)
        Me.Controls.Add(Me.CmbTipo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.LblTipo)
        Me.Controls.Add(Me.LblCosto)
        Me.Controls.Add(Me.LblPersonaNombre)
        Me.Controls.Add(Me.LblPersonaId)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtCosto)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Name = "FrmAltaServicio"
        Me.Text = "FrmAltaServicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblTipo As Label
    Friend WithEvents LblCosto As Label
    Friend WithEvents LblPersonaNombre As Label
    Friend WithEvents LblPersonaId As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCosto As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents CmbTipo As ComboBox
End Class
