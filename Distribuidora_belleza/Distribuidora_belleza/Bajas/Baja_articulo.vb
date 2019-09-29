Public Class Baja_articulo

    Private Sub ArticulosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub Baja_articulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BaseBellezaDataSet.articulos)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        If TextBox1.Text = "" Then
            MsgBox("Ingrese un Id de articulo")
        Else
            Me.ArticulosTableAdapter.buscarArticulo((Me.BaseBellezaDataSet.articulos), TextBox1.Text)

        End If

    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim consulta, codconsulta, fila As Integer
        codconsulta = TextBox1.Text
        fila = Me.ArticulosBindingSource.Find("id_articulo", codconsulta)
        If fila = -1 Then
            MsgBox("No se encontro")
        Else

            consulta = MsgBox("Desea eliminar articulo", 32 + 1)

            If consulta = 1 Then
                Me.ArticulosTableAdapter.eliminarArticulo(TextBox1.Text)
                Me.ArticulosBindingSource.EndEdit()

                Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

                Me.ArticulosTableAdapter.Fill(Me.BaseBellezaDataSet.articulos)
                consulta_articulo.ArticulosTableAdapter.Fill(Me.BaseBellezaDataSet.articulos)

            End If
        End If
    End Sub
End Class