Imports Logica

Public Class FrmEliminarPersona
    Private Sub FrmEliminarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()

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
        Try

            Select Case MsgBox("Esta seguro que desea eliminar", MsgBoxStyle.YesNo)
                Case DialogResult.Yes
                    Try
                        ControladorPersona.EliminarPersona(CmbIdPersona.Text)
                        CmbIdPersona.Items.Clear()
                        CargarDatos()
                        LimpiarCampos()
                    Catch ex As Exception
                        MsgBox("No se puede eliminar al usuario", MsgBoxStyle.Critical)
                    End Try
                Case DialogResult.No

            End Select

        Catch
        End Try


    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        FrmMenuPrincipal.Show()
        Me.Close()
    End Sub
    Private Sub CargarDatos()
        Dim LectorId As IDataReader
        LectorId = ControladorPersona.ObtenerIdPersona

        While LectorId.Read
            CmbIdPersona.Items.Add(LectorId.GetValue(0))
        End While
    End Sub
    Private Sub LimpiarCampos()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtMail.Clear()
        LstTelefono.Items.Clear()


    End Sub
End Class