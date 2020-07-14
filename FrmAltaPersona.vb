Imports Logica
Public Class FrmAltaPersona
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim Telefonos As New List(Of String)
        For x = 0 To LstTelefono.Items.Count - 1
            Telefonos.Add(LstTelefono.Items(x).ToString)
        Next
        If (ControladorPersona.NuevaPersona(TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtMail.Text.Trim, Telefonos)) Then
            MsgBox("Alta creada exitosamente")
        ElseIf (ControladorPersona.NuevaPersona(TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtMail.Text.Trim, Telefonos)) = 1 Then
            MsgBox("Error en comienzo de transacción")
        ElseIf (ControladorPersona.NuevaPersona(TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtMail.Text.Trim, Telefonos)) = 2 Then
            MsgBox("Las tablas no fueron bloqueadas")
        ElseIf (ControladorPersona.NuevaPersona(TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtMail.Text.Trim, Telefonos)) = 3 Then
            MsgBox("Hubo un error en la creación de la persona")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FrmMenuPrincipal.Show()
        Me.Close()

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        LstTelefono.Items.Add(TxtTelefono.Text)

    End Sub

    Private Sub FrmAltaPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class