Public Class consulta_articulo

    Private Sub ArticulosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub consulta_articulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BaseBellezaDataSet.articulos)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim consulta As String
        consulta = TextBox1.Text

        If TextBox1.Text = "" Then
            ArticulosTableAdapter.Fill(Me.BaseBellezaDataSet.articulos)

       

        ElseIf ComboBox1.SelectedItem = "descripcion" Then

            ArticulosTableAdapter.consultaDescripcion((Me.BaseBellezaDataSet.articulos), consulta)

        ElseIf ComboBox1.SelectedItem = "rubro" Then
            ArticulosTableAdapter.consultaRubro((Me.BaseBellezaDataSet.articulos), TextBox1.Text)

        Else

            ArticulosTableAdapter.consultaMarca((Me.BaseBellezaDataSet.articulos), TextBox1.Text)

        End If




    End Sub

  

    Private Sub ArticulosDataGridView_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ArticulosDataGridView.CellContentDoubleClick
        Dim fila As Integer
        fila = ArticulosDataGridView.CurrentCellAddress.Y
        If ArticulosDataGridView.Item(0, fila).Value Is DBNull.Value Then
            Exit Sub
        Else

            ModificarArticulo.txtId_articulo.Text = ArticulosDataGridView.Item(0, fila).Value()
            ModificarArticulo.txtDescripcion.Text = ArticulosDataGridView.Item(1, fila).Value()
            ModificarArticulo.txtCantidad_de_stock.Text = ArticulosDataGridView.Item(2, fila).Value()
            ModificarArticulo.txtPrecio.Text = ArticulosDataGridView.Item(3, fila).Value()
            ModificarArticulo.txtRubro.Text = ArticulosDataGridView.Item(4, fila).Value()
            ModificarArticulo.txtMarca.Text = ArticulosDataGridView.Item(5, fila).Value()

            ModificarArticulo.Show()

        End If
    End Sub
End Class