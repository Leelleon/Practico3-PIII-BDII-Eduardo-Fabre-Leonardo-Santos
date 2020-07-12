Imports Logica

Public Class FrmEliminarPersona
    Private Sub FrmEliminarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ControladorPersona.EliminarPersona(CmbIdPersona.Text)
        MsgBox("Persona Eliminada correctamente")

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

    End Sub
End Class