Public Class consulta_detalle

    Private Sub Detalle_vtaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Detalle_vtaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub consulta_detalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.detalle_vta' Puede moverla o quitarla según sea necesario.
        Me.Detalle_vtaTableAdapter.Fill(Me.BaseBellezaDataSet.detalle_vta)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Detalle_vtaTableAdapter.consulta_detalle((Me.BaseBellezaDataSet.detalle_vta), TextBox1.Text)

        Catch ex As Exception
            MsgBox("no se encontro")
        End Try

    End Sub
End Class