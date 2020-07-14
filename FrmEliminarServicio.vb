Imports Logica

Public Class FrmEliminarServicio

    Private Sub TxtId_TextChanged(sender As Object, e As EventArgs) Handles TxtId.TextChanged
        If TxtId.Text = "" Then
            PcbBusqueda.Enabled = False
            PcbBusqueda.Cursor = Cursors.Arrow
        Else
            BtnEliminar.Enabled = True
            PcbBusqueda.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub PcbBusqueda_Click(sender As Object, e As EventArgs) Handles PcbBusqueda.Click
        Dim LectorDatos As IDataReader
        Try
            LectorDatos = ControladorServicio.ObtenerDatos(TxtId.Text)
            BtnEliminar.Enabled = True
            BtnEliminar.Cursor = Cursors.Hand
            CargarTextBoxes(LectorDatos)
        Catch ex As Exception
            MsgBox("No existe un servicio con ese Identificador")
        End Try

    End Sub

    Private Sub CargarTextBoxes(Datos As IDataReader)
        While Datos.Read
            TxtNombre.Text = Datos.GetValue(0)
            TxtCosto.Text = Datos.GetValue(1)
            TxtTipo.Text = Datos.GetValue(2)
        End While

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        Select Case MsgBox("Seguro quiere eliminar al usuario?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    ControladorServicio.BajarServicio(TxtId.Text)
                    LimpiarTextBoxes()
                    BtnEliminar.Enabled = False
                    BtnEliminar.Cursor = Cursors.Arrow
                Catch ex As Exception
                    MsgBox("No se pudo eliminar a la persona", MsgBoxStyle.Critical)
                End Try
            Case MsgBoxResult.No
                TxtId.Text = ""
        End Select

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarTextBoxes()
        Me.Close()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LimpiarTextBoxes()
    End Sub

    Private Sub LimpiarTextBoxes()
        TxtId.Text = ""
        TxtNombre.Text = ""
        TxtCosto.Text = ""
        TxtTipo.Text = ""
    End Sub

End Class