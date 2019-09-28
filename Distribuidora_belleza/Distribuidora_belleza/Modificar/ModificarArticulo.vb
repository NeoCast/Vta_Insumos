Public Class ModificarArticulo

    Private Sub ArticulosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub ModificarArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BaseBellezaDataSet.articulos)
        txtId_articulo.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ArticulosTableAdapter.modificarArticulo(txtDescripcion.Text, txtCantidad_de_stock.Text, txtPrecio.Text, txtRubro.Text, txtMarca.Text, txtId_articulo.Text)
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)
        consulta_articulo.ArticulosTableAdapter.Fill(consulta_articulo.BaseBellezaDataSet.articulos)
        Me.Close()
    End Sub
End Class