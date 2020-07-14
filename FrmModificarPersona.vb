Imports Logica

Public Class FrmModificarPersona

    Public TelefonosViejos As List(Of String)

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
        If ControladorPersona.ModificarPersona(CmbIdPersona.Text, TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtMail.Text.Trim, Telefonos, TelefonosViejos) = 2 Then
            MsgBox("Modificacion exitosa")
        ElseIf ControladorPersona.ModificarPersona(CmbIdPersona.Text, TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtMail.Text.Trim, Telefonos, TelefonosViejos) = 1 Then
            MsgBox("Error en comienzo de transacción")
        ElseIf ControladorPersona.ModificarPersona(CmbIdPersona.Text, TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtMail.Text.Trim, Telefonos, TelefonosViejos) = 3 Then
            MsgBox("Hubo un error en la modificación de la persona")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TraerDatosDePersonas()

    End Sub

    Private Sub CmbIdPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbIdPersona.SelectedIndexChanged
        TraerDatosDePersonas()

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

    Private Sub TraerDatosDePersonas()
        Dim LeerDatosDePersona As IDataReader
        LeerDatosDePersona = ControladorPersona.TraerDatosDePersona(CmbIdPersona.Text)
        LstTelefono.Items.Clear()
        CargarDatos(LeerDatosDePersona)

    End Sub

    Private Sub CargarDatos(LeerDatosDePersona As IDataReader)

        While LeerDatosDePersona.Read
            TxtNombre.Text = LeerDatosDePersona.GetValue(0)
            TxtApellido.Text = LeerDatosDePersona.GetValue(1)
            TxtMail.Text = LeerDatosDePersona.GetValue(2)
            LstTelefono.Items.Add(LeerDatosDePersona.GetValue(3))
        End While
        GuardarTelefonosViejos(LstTelefono)

    End Sub

    Private Sub HabilitarBotonAgregar(Telefono As String)
        If IsNumeric(Telefono) Then
            BtnAgregar.Enabled = True
            BtnModificar.Enabled = True
        Else
            BtnAgregar.Enabled = False
            BtnModificar.Enabled = False
        End If
    End Sub

    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefono.TextChanged
        HabilitarBotonAgregar(TxtTelefono.Text)

    End Sub

    Public Sub GuardarTelefonosViejos(ListaTelefonosViejos As ListBox)

        For x = 0 To ListaTelefonosViejos.Items.Count - 1
            TelefonosViejos.Add(ListaTelefonosViejos.Items(x).ToString())
        Next

    End Sub


    '  Private Sub HabilitarBotonAceptar()
    ' If 
    '            BtnAceptar.Enabled = True
    'Else
    '       BtnAceptar.Enabled = False
    'End If

    'End Sub
End Class