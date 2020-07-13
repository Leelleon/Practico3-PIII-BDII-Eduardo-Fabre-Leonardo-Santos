Imports Logica

Public Class FrmModificarPersona
    Private Sub FrmModificarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LectorId As IDataReader
        LectorId = ControladorPersona.ObtenerIdPersona

        While LectorId.Read
            CmbIdPersona.Items.Add(LectorId.GetValue(0))
        End While

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim Telefonos As New List(Of String)
        For x = 0 To LstTelefono.Items.Count - 1
            Telefonos.Add(LstTelefono.Items(x).ToString)
        Next
        If ControladorPersona.ModificarPersona(TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtMail.Text.Trim, Telefonos) = 2 Then
            MsgBox("Modificacion exitosa")
        ElseIf ControladorPersona.ModificarPersona(TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtMail.Text.Trim, Telefonos) = 1 Then
            MsgBox("Error en comienzo de transacción")
        ElseIf ControladorPersona.ModificarPersona(TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtMail.Text.Trim, Telefonos) = 3 Then
            MsgBox("Hubo un error en la modificación de la persona")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim LectorId As IDataReader
        LectorId = ControladorPersona.ObtenerIdPersona

        While LectorId.Read
            CmbIdPersona.Items.Add(LectorId.GetValue(0))
        End While

    End Sub

    Private Sub CmbIdPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbIdPersona.SelectedIndexChanged
        Dim LeerDatosDePersona As IDataReader
        LeerDatosDePersona = ControladorPersona.TraerDatosDePersona(CmbIdPersona.Text)
        LstTelefono.Items.Clear()

        While LeerDatosDePersona.Read
            TxtNombre.Text = LeerDatosDePersona.GetValue(0)
            TxtApellido.Text = LeerDatosDePersona.GetValue(1)
            TxtMail.Text = LeerDatosDePersona.GetValue(2)
            LstTelefono.Items.Add(LeerDatosDePersona.GetValue(3))
        End While

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        LstTelefono.Items.Add(TxtTelefono.Text)
        TxtTelefono.Clear()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If TxtTelefono.Text = "" Then
            MsgBox("Debe seleccionar el telefono a modificar e ingresar el número nuevo")
        Else
            LstTelefono.Items.RemoveAt(LstTelefono.SelectedIndex)
            LstTelefono.Items.Add(TxtTelefono.Text)
            TxtTelefono.Clear()
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If LstTelefono.SelectedItem Then
            LstTelefono.Items.RemoveAt(LstTelefono.SelectedIndex)
        Else
            MsgBox("Seleccione el telefono de la lista a eliminar")
        End If


    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        FrmMenuPrincipal.Show()
        Me.Close()
    End Sub
End Class