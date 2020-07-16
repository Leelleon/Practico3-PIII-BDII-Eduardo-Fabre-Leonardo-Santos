Imports Logica
Public Class FrmModificarContrata

    Private Sub FrmModificarContrata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LectorServicios As IDataReader
        Try
            LectorServicios = ControladorContrata.ObtenerServiciosContratados()
            While LectorServicios.Read
                CmbServicios.Items.Add(LectorServicios.GetValue(0))
            End While
        Catch ex As Exception
            MsgBox("No se pudieron enconctrar servicios", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub CmbServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbServicios.SelectedIndexChanged
        Dim Contratos As New DataTable
        Try
            Contratos.Load(ControladorContrata.ObtenerContratos(CmbServicios.Text))
            DgvContratos.DataSource = Contratos
        Catch ex As Exception

        End Try
    End Sub


End Class