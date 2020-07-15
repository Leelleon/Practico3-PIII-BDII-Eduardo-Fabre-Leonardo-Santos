Imports Logica

Public Class FrmListarServicio

    Private Sub FrmListarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IniciarListado()
    End Sub

    Public Sub IniciarListado()
        Dim Listado As New DataTable
        Listado.Load(ControladorServicio.ListarServicio())
        DgvServicios.DataSource = Listado
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub

    Private Sub BtnRefrescar_Click(sender As Object, e As EventArgs) Handles BtnRefrescar.Click
        IniciarListado()
    End Sub

End Class