Public Class Consulta_usuarios

    Private Sub EmpleadoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub Consulta_usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.Registro_usuario' Puede moverla o quitarla según sea necesario.
        Me.Registro_usuarioTableAdapter.Fill(Me.BaseBellezaDataSet.Registro_usuario)
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BaseBellezaDataSet.empleado)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Registro_usuarioTableAdapter.Fill(Me.BaseBellezaDataSet.Registro_usuario)
        Else
            'Registro_usuarioTableAdapter.consultaUsuario(Me.BaseBellezaDataSet.Registro_usuario),TextBox1.text)


        End If
    End Sub

   
    Private Sub Registro_usuarioDataGridView_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Registro_usuarioDataGridView.CellContentClick
        'Dim fila As Integer
        'fila = Registro_usuarioDataGridView.CurrentCellAddress.Y
        'If Registro_usuarioDataGridView.Item(0, fila).Value Is DBNull.Value Then

        '    Exit Sub
        'Else

        '    ActualizarUsuario.txtUsuario.text = Registro_usuarioDataGridView.Item(0, fila).Value()
        '    ActualizarUsuario.txtTipo.text = Registro_usuarioDataGridView.Item(1, fila).Value()
        '    ActualizarUsuario.txtContraseña.text = Registro_usuarioDataGridView.Item(2, fila).Value()
        '    ActualizarUsuario.txtId_empleado.text = Registro_usuarioDataGridView.Item(3, fila).Value()

        ModificarEliminar_Usuario.Show()

        'End If


    End Sub
End Class