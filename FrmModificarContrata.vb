Imports Logica
Public Class FrmModificarContrata

    Private Sub CmbServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbServicios.SelectedIndexChanged
        Dim Contratos As New DataTable
        Try
            Contratos.Load(ControladorContrata.ObtenerContratos(CmbServicios.Text))
            DgvContratos.DataSource = Contratos
        Catch ex As Exception
            MsgBox("No se pudieron cargar los contratos", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim ContrataDesde As String = NudYDesde.Value.ToString() + "-" + NudMDesde.Value.ToString() + "-" + NudDDesde.Value.ToString()
        Dim ContrataHasta As String = NudYHasta.Value.ToString() + "-" + NudMHasta.Value.ToString() + "-" + NudDHasta.Value.ToString()
        ObtenerPKs(ContrataDesde, ContrataHasta)
    End Sub

    Private Sub ObtenerPKs(Desde As String, Hasta As String)
        Dim Usuario As String = DgvContratos.Item(0, DgvContratos.CurrentRow.Index()).Value()
        Dim Servicio As String = DgvContratos.Item(1, DgvContratos.CurrentRow.Index()).Value()
        Dim Fecha As Date = DgvContratos.Item(2, DgvContratos.CurrentRow.Index()).Value()
        Dim FechaContratacion As String = Fecha.Year.ToString() + "-" + Fecha.Month.ToString() + "-" + Fecha.Day.ToString()
        ModificarContrato(Usuario, Servicio, FechaContratacion, Desde, Hasta)

    End Sub

    Private Sub ModificarContrato(usuario As String, servicio As String, fechaContratacion As String, desde As String, hasta As String)
        If FechasValidas(desde, hasta) Then
            Try
                ControladorContrata.ModificarContrato(usuario, servicio, fechaContratacion, desde, hasta)
                MsgBox("Contrato modificado con exito!", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString())
                MsgBox("Error al modificar el contrato!", MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("La fecha de termino del contrato no puede ser menor al inicio!", MsgBoxStyle.Information)
        End If
        DeshabilitarModificacion()

    End Sub

    Private Function FechasValidas(desde As Date, hasta As Date)
        If hasta < desde Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub DgvContratos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvContratos.CellContentClick
        NumericUpDownDesde()
        NumericUpDownHasta()
    End Sub

    Private Sub NumericUpDownDesde()
        Dim Desde As Date = DgvContratos.Item("Inicia", DgvContratos.CurrentRow.Index()).Value()
        NudDDesde.Value = Desde.Day.ToString()
        NudMDesde.Value = Desde.Month.ToString()
        NudYDesde.Value = Desde.Year.ToString()

    End Sub

    Private Sub NumericUpDownHasta()
        Dim Hasta As Date = DgvContratos.Item("Termina", DgvContratos.CurrentRow.Index()).Value()
        NudDHasta.Value = Hasta.Day.ToString()
        NudMHasta.Value = Hasta.Month.ToString()
        NudYHasta.Value = Hasta.Year.ToString()

    End Sub

    Private Sub DeshabilitarModificacion()
        BtnModificar.Enabled = False
        BtnModificar.Cursor = Cursors.Arrow
        BtnModificar.BackColor = Color.Gainsboro

    End Sub

    Private Sub HabilitarModificacion()
        BtnModificar.Enabled = True
        BtnModificar.Cursor = Cursors.Hand
        BtnModificar.BackColor = Color.GhostWhite

    End Sub



    Private Sub NudDDesde_ValueChanged(sender As Object, e As EventArgs) Handles NudDDesde.ValueChanged
        HabilitarModificacion()
    End Sub

    Private Sub NudMDesde_ValueChanged(sender As Object, e As EventArgs) Handles NudMDesde.ValueChanged
        HabilitarModificacion()
    End Sub

    Private Sub NudYDesde_ValueChanged(sender As Object, e As EventArgs) Handles NudYDesde.ValueChanged
        HabilitarModificacion()
    End Sub

    Private Sub NudDHasta_ValueChanged(sender As Object, e As EventArgs) Handles NudDHasta.ValueChanged
        HabilitarModificacion()
    End Sub

    Private Sub NudMHasta_ValueChanged(sender As Object, e As EventArgs) Handles NudMHasta.ValueChanged
        HabilitarModificacion()
    End Sub

    Private Sub NudYHasta_ValueChanged(sender As Object, e As EventArgs) Handles NudYHasta.ValueChanged
        HabilitarModificacion()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class