Public Class consulta_proveedor

    Private Sub ProveedorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub consulta_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.BaseBellezaDataSet.proveedor)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text = "" Then
            ProveedorTableAdapter.Fill(Me.BaseBellezaDataSet.proveedor)
        Else
            ProveedorTableAdapter.consultarNombProv((Me.BaseBellezaDataSet.proveedor), TextBox1.Text)
        End If
    End Sub


    Private Sub ProveedorDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProveedorDataGridView.CellDoubleClick
        Dim fila As Integer
        fila = ProveedorDataGridView.CurrentCellAddress.Y
        If Me.ProveedorDataGridView.Item(0, fila).Value Is DBNull.Value Then
            Exit Sub
        Else
            ModificarProveedor.txtId_proveedor.Text = ProveedorDataGridView.Item(0, fila).Value()
            ModificarProveedor.txtNombre.Text = ProveedorDataGridView.Item(1, fila).Value()
            ModificarProveedor.txtTelefono.Text = ProveedorDataGridView.Item(2, fila).Value()
            ModificarProveedor.txtMail.Text = ProveedorDataGridView.Item(3, fila).Value()
            ModificarProveedor.txtLocalidad.Text = ProveedorDataGridView.Item(4, fila).Value()
            ModificarProveedor.txtDireccion.Text = ProveedorDataGridView.Item(5, fila).Value()
            ModificarProveedor.txtC_p.Text = ProveedorDataGridView.Item(6, fila).Value()

            ModificarProveedor.Show()

        End If
    End Sub
End Class