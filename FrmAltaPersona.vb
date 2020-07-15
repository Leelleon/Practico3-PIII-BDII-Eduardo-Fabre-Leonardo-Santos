Imports Logica
Public Class FrmAltaPersona
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        Dim Telefonos As New List(Of String)
        For x = 0 To LstTelefono.Items.Count - 1
            Telefonos.Add(LstTelefono.Items(x).ToString)
        Next
        If ControladorPersona.NuevaPersona(TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtMail.Text.Trim, Telefonos) = 2 Then
            MsgBox("Alta creada exitosamente")
        ElseIf ControladorPersona.NuevaPersona(TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtMail.Text.Trim, Telefonos) = 1 Then
            MsgBox("Error en comienzo de transacción")

        ElseIf ControladorPersona.NuevaPersona(TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtMail.Text.Trim, Telefonos) = 3 Then
            MsgBox("Hubo un error en la creación de la persona")
        End If
        Limpiar()

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        FrmMenuPrincipal.Show()
        Me.Close()

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        LstTelefono.Items.Add(TxtTelefono.Text)
        HabilitarBotonAceptar()
        TxtTelefono.Clear()

    End Sub

    Private Sub FrmAltaPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotonAceptar()
        BtnAgregar.Enabled = False

    End Sub
    Private Sub HabilitarBotonAceptar()
        If ((TxtNombre.Text <> "") And (TxtApellido.Text <> "") And (LstTelefono.Items.Count() > 0)) Then
            BtnAceptar.Enabled = True
        Else
            BtnAceptar.Enabled = False
        End If

    End Sub

    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefono.TextChanged
        HabilitarBotonAgregar(TxtTelefono.Text)
    End Sub

    Private Sub HabilitarBotonAgregar(Telefono As String)
        If IsNumeric(Telefono) Then
            BtnAgregar.Enabled = True
        Else
            BtnAgregar.Enabled = False
        End If
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        HabilitarBotonAceptar()
    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
        HabilitarBotonAceptar()
    End Sub

    Private Sub Limpiar()
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtMail.Text = ""
        LstTelefono.Items.Clear()

    End Sub

End Class