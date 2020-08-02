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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAltaServicio))
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
        Me.LblLinea2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BtnCancelar, "BtnCancelar")
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'LblTipo
        '
        resources.ApplyResources(Me.LblTipo, "LblTipo")
        Me.LblTipo.BackColor = System.Drawing.Color.Transparent
        Me.LblTipo.ForeColor = System.Drawing.Color.White
        Me.LblTipo.Name = "LblTipo"
        '
        'LblCosto
        '
        resources.ApplyResources(Me.LblCosto, "LblCosto")
        Me.LblCosto.BackColor = System.Drawing.Color.Transparent
        Me.LblCosto.ForeColor = System.Drawing.Color.White
        Me.LblCosto.Name = "LblCosto"
        '
        'LblPersonaNombre
        '
        resources.ApplyResources(Me.LblPersonaNombre, "LblPersonaNombre")
        Me.LblPersonaNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblPersonaNombre.ForeColor = System.Drawing.Color.White
        Me.LblPersonaNombre.Name = "LblPersonaNombre"
        '
        'LblPersonaId
        '
        resources.ApplyResources(Me.LblPersonaId, "LblPersonaId")
        Me.LblPersonaId.BackColor = System.Drawing.Color.Transparent
        Me.LblPersonaId.ForeColor = System.Drawing.Color.White
        Me.LblPersonaId.Name = "LblPersonaId"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.LightBlue
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TxtNombre, "TxtNombre")
        Me.TxtNombre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNombre.Name = "TxtNombre"
        '
        'TxtCosto
        '
        Me.TxtCosto.AcceptsTab = True
        Me.TxtCosto.BackColor = System.Drawing.Color.LightBlue
        Me.TxtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TxtCosto, "TxtCosto")
        Me.TxtCosto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtCosto.Name = "TxtCosto"
        '
        'TxtId
        '
        Me.TxtId.BackColor = System.Drawing.Color.LightBlue
        Me.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.TxtId, "TxtId")
        Me.TxtId.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtId.Name = "TxtId"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BtnAceptar, "BtnAceptar")
        Me.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'CmbTipo
        '
        Me.CmbTipo.BackColor = System.Drawing.Color.White
        Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.CmbTipo, "CmbTipo")
        Me.CmbTipo.ForeColor = System.Drawing.Color.Black
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Items.AddRange(New Object() {resources.GetString("CmbTipo.Items"), resources.GetString("CmbTipo.Items1"), resources.GetString("CmbTipo.Items2"), resources.GetString("CmbTipo.Items3"), resources.GetString("CmbTipo.Items4")})
        Me.CmbTipo.Name = "CmbTipo"
        '
        'LblLinea2
        '
        Me.LblLinea2.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.LblLinea2, "LblLinea2")
        Me.LblLinea2.Name = "LblLinea2"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'FrmAltaServicio
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblLinea2)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAltaServicio"
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
    Friend WithEvents LblLinea2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
