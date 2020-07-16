Imports Logica
Public Class FrmAltaContrata

    Dim Persona As String = ""
    Dim Servicio As String = ""
    Dim Desde As String = ""
    Dim Hasta As String = ""
    Dim Costo As String = ""

    Private Sub FrmAltaContrata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpDesde.Format = DateTimePickerFormat.Custom
        DtpDesde.CustomFormat = "dd/MM/yyyy"
        DtpHasta.Format = DateTimePickerFormat.Custom
        DtpHasta.CustomFormat = "dd/MM/yyyy"
        CargarIdPersonas()
        CargarIdServicios()

    End Sub

    Private Sub CargarIdPersonas()
        Dim LectorPersonas As IDataReader
        Try
            LectorPersonas = ControladorContrata.ObtenerIdPersonas
            While LectorPersonas.Read
                CmbUsuario.Items.Add(LectorPersonas.GetValue(0))
            End While
        Catch ex As Exception
            MsgBox("No fue posible cargar a los usuarios del sistema!", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub CargarIdServicios()
        Dim LectorServicios As IDataReader
        Try
            LectorServicios = ControladorContrata.ObtenerIdServicios(CmbUsuario.Text)
            While LectorServicios.Read
                CmbServicio.Items.Add(LectorServicios.GetValue(0))
            End While
        Catch ex As Exception
            MsgBox("No fue posible cargar a los servicios del sistema!", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub CmbUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUsuario.SelectedIndexChanged
        Dim LectorNombrePerona As IDataReader
        Try
            LectorNombrePerona = ControladorContrata.ObtenerNombrePersona(CmbUsuario.Text)
            While LectorNombrePerona.Read
                Persona = LectorNombrePerona.GetValue(0)
            End While
            ModificarLabel()
        Catch ex As Exception
            MsgBox("No encontramos un nombre para ese identificador", MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub CmbServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbServicio.SelectedIndexChanged
        Dim LectorNombreServicio As IDataReader
        Try
            LectorNombreServicio = ControladorContrata.ObtenerNombreServicio(CmbServicio.Text)
            While LectorNombreServicio.Read
                Servicio = LectorNombreServicio.GetValue(0)
            End While
            ModificarLabel()
            ObtenerCosto()
        Catch ex As Exception
            MsgBox("No encontramos un nombre para ese identificador", MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub DtpDesde_ValueChanged(sender As Object, e As EventArgs) Handles DtpDesde.ValueChanged
        Desde = DtpDesde.Value.ToShortDateString()
        ModificarLabel()
        ObtenerCosto()

    End Sub

    Private Sub DtpHasta_ValueChanged(sender As Object, e As EventArgs) Handles DtpHasta.ValueChanged
        Hasta = DtpHasta.Value.ToShortDateString()
        ModificarLabel()
        ObtenerCosto()

    End Sub

    Private Sub ModificarLabel()
        LblDescripcion.Text = "
            La persona: " + Persona + " contratara el servicio: " + Servicio + "
            Desde el : " + Desde + " Hasta el: " + Hasta + " teniendo que abonar en total: " + Costo + "
        "
        HabilitarConfirmacion()
    End Sub

    Private Sub HabilitarConfirmacion()
        If Persona = "" Or Servicio = "" Or Desde = "" Or Hasta = "" Or CalcularDias() < 0 Then
            ChbConfirmar.Enabled = False
            ChbConfirmar.Checked = False
        Else
            ChbConfirmar.Enabled = True
        End If

    End Sub

    Private Sub ObtenerCosto()
        If Servicio <> "" And Desde <> "" And Hasta <> "" Then

            Dim Diferencia As String = DateDiff(DateInterval.Month, DtpDesde.Value.Date, DtpHasta.Value.Date) + 1

            Dim LectorCosto As IDataReader
            If CalcularDias() >= 0 Then
                Try
                    LectorCosto = ControladorContrata.ObtenerCosto(Diferencia, CmbServicio.Text)
                    While LectorCosto.Read
                        Costo = LectorCosto.GetValue(0)
                        ModificarLabel()
                    End While
                Catch ex As Exception
                    MsgBox("No se pudo calcular el costo", MsgBoxStyle.Critical)
                End Try
            Else
                MsgBox("El fin del contrato no puede terminar antes de empezar!", MsgBoxStyle.Information)

            End If
        End If

    End Sub

    Private Function CalcularDias()
        Dim DiferenciaDias As String = DateDiff(DateInterval.Day, DtpDesde.Value.Date, DtpHasta.Value.Date)
        Return DiferenciaDias

    End Function

    Private Sub ChbConfirmar_CheckedChanged(sender As Object, e As EventArgs) Handles ChbConfirmar.CheckedChanged
        If ChbConfirmar.Checked Then
            BtnAceptar.Enabled = True
            BtnAceptar.Cursor = Cursors.Hand
            BtnAceptar.BackColor = Color.GhostWhite
        Else
            BtnAceptar.Enabled = False
            BtnAceptar.Cursor = DefaultCursor
            BtnAceptar.BackColor = Color.Gainsboro
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LimpiarTextBoxes()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarTextBoxes()
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim ContrataDesde As String = DtpDesde.Value.Year.ToString() + "-" + DtpDesde.Value.Month.ToString() + "-" + DtpDesde.Value.Day.ToString()
        Dim ContrataHasta As String = DtpHasta.Value.Year.ToString() + "-" + DtpHasta.Value.Month.ToString() + "-" + DtpHasta.Value.Day.ToString()
        Try
            ControladorContrata.GuardarContratacion(CmbUsuario.Text, CmbServicio.Text, ContrataDesde, ContrataHasta)
            MsgBox("Contrato realizado con exito!", MsgBoxStyle.Information)
            LimpiarTextBoxes()
        Catch ex As Exception
            MsgBox("El Usuario seleccionado ya contrato este servicio en esta fecha!")
        End Try

    End Sub

    Private Sub LimpiarTextBoxes()
        CmbUsuario.Text = ""
        CmbServicio.Text = ""
        ModificarLabel()
        HabilitarConfirmacion()

    End Sub
End Class