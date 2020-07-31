Imports Logica

Public Class FrmListarContrata
    Private Sub FrmListarContrata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim TablaContratos As New DataTable
            TablaContratos.Load(ControladorContrata.ListarContratos)
            DgvContratos.DataSource = TablaContratos
        Catch ex As Exception
            MsgBox(ex.ToString)
            'MsgBox("No se pudo cargar la lista!", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub
End Class
