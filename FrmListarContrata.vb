Public Class FrmListarContrata
    Private Sub FrmListarContrata_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DgvListarContrato_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListarContrato.CellContentClick

    End Sub

    'Private Sub BtnListar_Click(sender As Object, e As EventArgs) Handles BtnListar.Click
    '    Try
    '        Dim TablaContrata As New DataTable
    '        TablaContrata.Load(ControladorContrata.ListarDatosDeContrata)
    '        DgvListarContrato.DataSource = TablaContrata

    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        FrmMenuPrincipal.Show()
        Me.Close()
    End Sub
End Class