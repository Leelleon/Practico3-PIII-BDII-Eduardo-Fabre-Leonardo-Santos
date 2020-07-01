Imports Logica

Public Class FrmModificarServicio

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbId.SelectedIndexChanged
        Dim DatosServicio As New DataTable
        DatosServicio.Load(ControladorServicio.ObtenerDatos(CmbTipo.Text))
        TxtNombre.Text = DatosServicio.Rows().Item(0).ToString()

    End Sub

    Private Sub FrmModificarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbTipo.DataSource = ControladorServicio.ObtenerIDs
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        CmbId.Text = ""
        TxtNombre.Text = ""
        TxtCosto.Text = ""
        CmbTipo.Text = ""

    End Sub
End Class