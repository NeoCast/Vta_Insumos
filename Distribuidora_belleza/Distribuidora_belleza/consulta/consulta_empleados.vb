Public Class consulta_empleados

    Private Sub EmpleadoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub consulta_empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BaseBellezaDataSet.empleado)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim dni As Integer = Val(TextBox1.Text)
        If TextBox1.Text = "" Then
            EmpleadoTableAdapter.Fill(Me.BaseBellezaDataSet.empleado)
        Else
            EmpleadoTableAdapter.consultaNombre((Me.BaseBellezaDataSet.empleado), TextBox1.Text)
        End If
    End Sub


    Private Sub EmpleadoDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmpleadoDataGridView.CellDoubleClick
        Dim fila As Integer
        fila = EmpleadoDataGridView.CurrentCellAddress.Y
        If EmpleadoDataGridView.Item(0, fila).Value Is DBNull.Value Then
            Exit Sub
        Else
            ModificarEmpleado.txtId_empleado.Text = EmpleadoDataGridView.Item(0, fila).Value()
            ModificarEmpleado.txtNombre.Text = EmpleadoDataGridView.Item(1, fila).Value()
            ModificarEmpleado.txtApellido.Text = EmpleadoDataGridView.Item(2, fila).Value()
            ModificarEmpleado.txtDni.Text = EmpleadoDataGridView.Item(3, fila).Value()
            ModificarEmpleado.txtTelefono.Text = EmpleadoDataGridView.Item(4, fila).Value()
            ModificarEmpleado.txtLocalidad.Text = EmpleadoDataGridView.Item(5, fila).Value()
            ModificarEmpleado.txtDireccion.Text = EmpleadoDataGridView.Item(6, fila).Value()
            ModificarEmpleado.txtCp.Text = EmpleadoDataGridView.Item(7, fila).Value()

            ModificarEmpleado.Show()

        End If
    End Sub
End Class