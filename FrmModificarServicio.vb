Imports Logica

Public Class FrmModificarServicio


    Private Sub FrmModificarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim LectorID As IDataReader
        LectorID = ControladorServicio.ObtenerIDs

        While LectorID.Read
            CmbId.Items.Add(LectorID.GetValue(0))
        End While

    End Sub

    Private Sub CmbId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbId.SelectedIndexChanged
        Dim LectorDatos As IDataReader
        LectorDatos = ControladorServicio.ObtenerDatos(CmbId.Text)
        While LectorDatos.Read
            TxtNombre.Text = LectorDatos.GetValue(0)
            TxtCosto.Text = LectorDatos.GetValue(1)
            CmbTipo.Text = LectorDatos.GetValue(2)
        End While
        PermitirCambio(TxtNombre.Text, TxtCosto.Text, CmbTipo.Text)
    End Sub

    Public Sub PermitirCambio(nombre As String, costo As String, tipo As String)


    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim Servicio(4) As String
        Servicio(0) = CmbId.Text
        Servicio(1) = TxtNombre.Text
        Servicio(2) = TxtCosto.Text
        Servicio(3) = CmbTipo.Text
        ControladorServicio.ModificarServicio(Servicio)
        LimpiarTxt()
    End Sub

    Private Sub LimpiarTxt()
        CmbId.Text = ""
        TxtNombre.Text = ""
        TxtCosto.Text = ""
        CmbTipo.Text = ""
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarTxt()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        LimpiarTxt()
        Me.Close()
    End Sub
End Class