﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarPersona
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEliminarPersona))
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblPersonaNombre = New System.Windows.Forms.Label()
        Me.LblPersonaId = New System.Windows.Forms.Label()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.LstTelefono = New System.Windows.Forms.ListBox()
        Me.CmbIdPersona = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BtnVolver, "BtnVolver")
        Me.BtnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnVolver.ForeColor = System.Drawing.Color.White
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'LblTelefono
        '
        resources.ApplyResources(Me.LblTelefono, "LblTelefono")
        Me.LblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.LblTelefono.ForeColor = System.Drawing.Color.White
        Me.LblTelefono.Name = "LblTelefono"
        '
        'LblMail
        '
        resources.ApplyResources(Me.LblMail, "LblMail")
        Me.LblMail.BackColor = System.Drawing.Color.Transparent
        Me.LblMail.ForeColor = System.Drawing.Color.White
        Me.LblMail.Name = "LblMail"
        '
        'LblApellido
        '
        resources.ApplyResources(Me.LblApellido, "LblApellido")
        Me.LblApellido.BackColor = System.Drawing.Color.Transparent
        Me.LblApellido.ForeColor = System.Drawing.Color.White
        Me.LblApellido.Name = "LblApellido"
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
        'TxtMail
        '
        Me.TxtMail.BackColor = System.Drawing.Color.LightBlue
        resources.ApplyResources(Me.TxtMail, "TxtMail")
        Me.TxtMail.Name = "TxtMail"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.LightBlue
        resources.ApplyResources(Me.TxtNombre, "TxtNombre")
        Me.TxtNombre.Name = "TxtNombre"
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.LightBlue
        resources.ApplyResources(Me.TxtApellido, "TxtApellido")
        Me.TxtApellido.Name = "TxtApellido"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BtnEliminar, "BtnEliminar")
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'LstTelefono
        '
        Me.LstTelefono.BackColor = System.Drawing.Color.LightBlue
        resources.ApplyResources(Me.LstTelefono, "LstTelefono")
        Me.LstTelefono.FormattingEnabled = True
        Me.LstTelefono.Name = "LstTelefono"
        '
        'CmbIdPersona
        '
        Me.CmbIdPersona.BackColor = System.Drawing.Color.LightBlue
        Me.CmbIdPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.CmbIdPersona, "CmbIdPersona")
        Me.CmbIdPersona.FormattingEnabled = True
        Me.CmbIdPersona.Name = "CmbIdPersona"
        '
        'FrmEliminarPersona
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ControlBox = False
        Me.Controls.Add(Me.CmbIdPersona)
        Me.Controls.Add(Me.LstTelefono)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblPersonaNombre)
        Me.Controls.Add(Me.LblPersonaId)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Name = "FrmEliminarPersona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnVolver As Button
    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblPersonaNombre As Label
    Friend WithEvents LblPersonaId As Label
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents LstTelefono As ListBox
    Friend WithEvents CmbIdPersona As ComboBox
End Class
