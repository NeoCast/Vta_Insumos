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
            Registro_usuarioTableAdapter.consultaUsuario((Me.BaseBellezaDataSet.Registro_usuario), TextBox1.Text)


        End If
    End Sub


   
    Private Sub Registro_usuarioDataGridView_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Registro_usuarioDataGridView.CellContentClick
        Dim fila As Integer
        fila = Registro_usuarioDataGridView.CurrentCellAddress.Y
        If Registro_usuarioDataGridView.Item(0, fila).Value Is DBNull.Value Then

            Exit Sub
        Else

            ModificarEliminar_Usuario.txtUsuario.Text = Registro_usuarioDataGridView.Item(0, fila).Value()
            ModificarEliminar_Usuario.txtTipo.Text = Registro_usuarioDataGridView.Item(1, fila).Value()
            ModificarEliminar_Usuario.txtContraseña.Text = Registro_usuarioDataGridView.Item(2, fila).Value()
            ModificarEliminar_Usuario.txtId_empleado.Text = Registro_usuarioDataGridView.Item(3, fila).Value()

            ModificarEliminar_Usuario.Show()

        End If


    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If TextBox1.Text = "" Then
            MsgBox("Ingrese un NOMBRE")
        Else
            Me.Registro_usuarioTableAdapter.consultaUsuario((Me.BaseBellezaDataSet.Registro_usuario), TextBox1.Text)

        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim consulta, codconsulta, fila As String
        codconsulta = TextBox1.Text
        fila = Me.Registro_usuarioBindingSource.Find("usuario", codconsulta)
        If fila = -1 Then
            MsgBox("no se encontro")
        Else

            consulta = MsgBox("Desea eliminar usuario", 32 + 1)
            If consulta = 1 Then
                Me.Registro_usuarioTableAdapter.eliminarUsuario(TextBox1.Text)
                Me.Registro_usuarioBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)
                Me.Registro_usuarioTableAdapter.Fill(Me.BaseBellezaDataSet.Registro_usuario)
                Me.Registro_usuarioTableAdapter.Fill(Me.BaseBellezaDataSet.Registro_usuario)
            End If
        End If
    End Sub

End Class