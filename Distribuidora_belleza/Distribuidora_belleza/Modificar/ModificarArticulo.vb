Public Class ModificarArticulo

    Private Sub ArticulosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub ModificarArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BaseBellezaDataSet.articulos)
        'txtId_articulo.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim consulta As Integer

        consulta = MsgBox("Esta seguro de realizar la modificación, los cambios son permanentes", 32 + 1)
        If consulta = 1 Then
            Me.Validate()
            Me.ArticulosTableAdapter.modificarArticulo(txtDescripcion.Text, txtCantidad_de_stock.Text, txtPrecio.Text, txtRubro.Text, txtMarca.Text, txtId_articulo.Text)
            Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)
            consulta_articulo.ArticulosTableAdapter.Fill(consulta_articulo.BaseBellezaDataSet.articulos)
            MsgBox("Modificacion realizada con exito")

            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim codconsulta, fila As Integer
        codconsulta = txtId_articulo.Text
        fila = Me.ArticulosBindingSource.Find("id_articulo", codconsulta)
        If fila = -1 Then
            MsgBox("No se encontro")
        Else
            ArticulosTableAdapter.buscarArticulo((Me.BaseBellezaDataSet.articulos), txtId_articulo.Text)
            txtDescripcion.Text = ArticulosBindingSource.Current("descripcion")
            txtCantidad_de_stock.Text = ArticulosBindingSource.Current("cantidad_stock")
            txtPrecio.Text = ArticulosBindingSource.Current("precio")
            txtRubro.Text = ArticulosBindingSource.Current("rubro")
            txtMarca.Text = ArticulosBindingSource.Current("marca")
            txtminimo.Text = ArticulosBindingSource.Current("stock_minimo")

            Button1.Enabled = True
        End If
    End Sub
End Class