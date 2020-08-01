Imports Logica

Public Class FrmModificarServicio

    Private Sub FrmModificarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim LectorID As IDataReader
        Try
            LectorID = ControladorServicio.ObtenerIDs
            While LectorID.Read
                CmbId.Items.Add(LectorID.GetValue(0))
            End While
        Catch ex As Exception
            MsgBox("No se encontraron Servicios para modificar", MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub CmbId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbId.SelectedIndexChanged
        Dim LectorDatos As IDataReader
        Try
            LectorDatos = ControladorServicio.ObtenerDatos(CmbId.Text)
            CargarDatos(LectorDatos)
        Catch ex As Exception
            MsgBox("No se pudieron cargar los datos", MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Sub CargarDatos(Datos As IDataReader)
        While Datos.Read
            TxtNombre.Text = Datos.GetValue(0)
            TxtCosto.Text = Datos.GetValue(1)
            CmbTipo.Text = Datos.GetValue(2)
        End While
        PermitirCambio(TxtNombre.Text, TxtCosto.Text, CmbTipo.Text)
    End Sub

    Public Sub PermitirCambio(nombre As String, costo As String, tipo As String)
        BtnAceptar.Enabled = True
        BtnAceptar.Cursor = Cursors.Hand
        BtnAceptar.BackColor = Color.GhostWhite

    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim Servicio(4) As String
        Servicio(0) = CmbId.Text
        Servicio(1) = TxtNombre.Text
        Servicio(2) = TxtCosto.Text
        Servicio(3) = CmbTipo.Text
        ModificarServicio(Servicio)

    End Sub

    Private Sub ModificarServicio(Servicio() As String)
        Try
            ControladorServicio.ModificarServicio(Servicio)
            LimpiarTxt()
            BtnAceptar.Enabled = False
            BtnAceptar.Cursor = Cursors.Arrow
            BtnAceptar.BackColor = Color.Gainsboro
            MsgBox("El servicio se modificó exitosamente!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("No se puede modificar al servicio deseado", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarTxt()
        Me.Close()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LimpiarTxt()
    End Sub

    Private Sub LimpiarTxt()
        CmbId.SelectedText = ""
        TxtNombre.Text = ""
        TxtCosto.Text = ""
        CmbTipo.SelectedText = ""
    End Sub

End Class