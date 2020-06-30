Imports Logica

Public Class FrmModificarServicio

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim DatosServicio As New DataTable
        DatosServicio.Load(ControladorServicio.ObtenerDatos(CmbTipo.Text))
        Dim Datos(3) As String
        For x = 0 To Datos(3).Length
            Datos(0) = DatosServicio.Rows()
        Next
    End Sub

    Private Sub FrmModificarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbTipo.DataSource = ControladorServicio.ObtenerIDs
    End Sub
End Class