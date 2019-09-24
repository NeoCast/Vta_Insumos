Public Class AltaArticulo

    Private Sub ArticulosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub AltaArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BaseBellezaDataSet.articulos)
        Me.ArticulosBindingSource.AddNew()

    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click


        If DescripcionTextBox.Text <> "" Then
            If PrecioTextBox.Text <> "" And IsNumeric(PrecioTextBox.Text) Then
                If RubroTextBox.Text <> "" Then
                    If MarcaTextBox.Text <> "" Then

                        Me.ArticulosBindingSource.Current("descripcion") = DescripcionTextBox.Text
                        Me.ArticulosBindingSource.Current("cantidad_stock") = Cantidad_stockTextBox.Text
                        Me.ArticulosBindingSource.Current("precio") = PrecioTextBox.Text
                        Me.ArticulosBindingSource.Current("rubro") = RubroTextBox.Text
                        Me.ArticulosBindingSource.Current("marca") = MarcaTextBox.Text
                        Me.Validate()
                        Me.ArticulosBindingSource.EndEdit()
                        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

                        MsgBox("se cargo con exito")
                        Me.ArticulosTableAdapter.Fill(Me.BaseBellezaDataSet.articulos)
                        inicio.ArticulosTableAdapter.Fill(inicio.BaseBellezaDataSet.articulos)

                        Me.ArticulosBindingSource.AddNew()

                        DescripcionTextBox.Focus()
                    Else
                        MsgBox("el campo de marca esta incompleto")
                        Exit Sub

                    End If
                Else
                    MsgBox("el campo de rubro esta incompleto")
                    Exit Sub

                End If
            Else
                MsgBox("el campo de precio esta incompleto")
                Exit Sub

            End If
        Else
            MsgBox("el campo descripcion esta incompleto")
            Exit Sub
        End If

       
    End Sub

    Private Sub btnfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfin.Click
        Me.Close()

    End Sub
End Class