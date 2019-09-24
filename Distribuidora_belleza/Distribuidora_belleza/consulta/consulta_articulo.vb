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
End Class