Imports Logica

Public Class FrmEliminarContrata
    Private Sub FrmEliminarContrata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpFechaCreacion.Format = DateTimePickerFormat.Custom
        DtpFechaCreacion.CustomFormat = "dd/MM/yyyy"
        CargarIdUsuarios()

    End Sub

    Public Sub CargarIdUsuarios()
        Dim LectorIdUsuarios As IDataReader
        Try
            LectorIdUsuarios = ControladorContrata.ObtenerIdPersonas()
            While LectorIdUsuarios.Read
                CmbUsuarios.Items.Add(LectorIdUsuarios.GetValue(0))
            End While
        Catch ex As Exception
            'MsgBox("No se pudieron cargar los usuarios", MsgBoxStyle.Critical)
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub CmbUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUsuarios.SelectedIndexChanged
        CmbServicios.Items.Clear()
        CargarIdServicios()

    End Sub

    Public Sub CargarIdServicios()
        Dim LectorIdServicios As IDataReader
        Try
            LectorIdServicios = ControladorContrata.ObtenerIdServicios(CmbUsuarios.Text)
            While LectorIdServicios.Read
                CmbServicios.Items.Add(LectorIdServicios.GetValue(0))
            End While
        Catch ex As Exception
            MsgBox("No se pudieron cargar los usuarios", MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Sub CmbServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbServicios.SelectedIndexChanged
        HabilitarCalendario(CmbUsuarios.Text, CmbServicios.Text)

    End Sub

    Public Sub HabilitarCalendario(usuario As String, servicio As String)
        If usuario <> "" And servicio <> "" Then
            DtpFechaCreacion.Enabled = True
        Else
            DtpFechaCreacion.Enabled = False
        End If

    End Sub

    Public Sub DtpFechaCreacion_ValueChanged(sender As Object, e As EventArgs) Handles DtpFechaCreacion.ValueChanged
        PcbBusqueda.Enabled = True
        PcbBusqueda.Cursor = Cursors.Hand

    End Sub

    Public Sub PcbBusqueda_Click(sender As Object, e As EventArgs) Handles PcbBusqueda.Click
        Dim LectorContrato As IDataReader
        Dim Fecha As String = DtpFechaCreacion.Value.Year.ToString() + "-" + DtpFechaCreacion.Value.Month.ToString() + "-" + DtpFechaCreacion.Value.Day.ToString()
        TraerDatos(LectorContrato, Fecha)

    End Sub

    Public Sub TraerDatos(lector As IDataReader, fecha As String)
        Try
            lector = ControladorContrata.ObtenerContratoYPersonas(CmbUsuarios.Text, CmbServicios.Text, fecha)
            While lector.Read
                TxtNombreUsuario.Text = lector.GetValue(0)
                TxtNombreServicio.Text = lector.GetValue(1)
                TxtFechaEmpieza.Text = lector.GetValue(2)
                TxtFechaTermina.Text = lector.GetValue(3)
            End While
            If TxtNombreUsuario.Text <> "" Then
                HabilitarEliminar()
            Else
                MsgBox("No existe esta combinacion en los registros", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("No se pudieron obtener los datos para ese contrato!", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub HabilitarEliminar()
        BtnEliminar.Enabled = True
        BtnEliminar.Cursor = Cursors.Hand
        BtnEliminar.BackColor = Color.GhostWhite
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim Fecha As String = DtpFechaCreacion.Value.Year.ToString() + "-" + DtpFechaCreacion.Value.Month.ToString() + "-" + DtpFechaCreacion.Value.Day.ToString()
        Try
            ControladorContrata.EliminarContratacion(CmbUsuarios.Text, CmbServicios.Text, Fecha)
            MsgBox("Contato eliminado con exito!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("No se pudo eliminar el contrato", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub DeshabilitarEliminar()
        BtnEliminar.Enabled = False
        BtnEliminar.Cursor = Cursors.Arrow
        BtnEliminar.BackColor = Color.Gainsboro
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LimpiarTextBoxes()
        DeshabilitarEliminar()
    End Sub

    Public Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarTextBoxes()
        Me.Close()
    End Sub

    Public Sub LimpiarTextBoxes()
        CmbUsuarios.Text = ""
        CmbServicios.Text = ""
        TxtNombreUsuario.Text = ""
        TxtNombreServicio.Text = ""
        TxtFechaEmpieza.Text = ""
        TxtFechaTermina.Text = ""

    End Sub


End Class