Imports Logica

Public Class FrmListarServicio
    Private Sub FrmListarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Listado As New DataTable
        Listado.Load(ControladorServicio.ListarServicio())
        DgvServicios.DataSource = Listado
    End Sub


End Class