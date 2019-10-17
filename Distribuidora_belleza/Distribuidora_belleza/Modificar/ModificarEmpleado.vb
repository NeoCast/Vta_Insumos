Public Class ModificarEmpleado

    Private Sub EmpleadoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub ModificarEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BaseBellezaDataSet.empleado)
        'txtId_empleado.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim consulta As Integer

        consulta = MsgBox("Esta seguro de realizar la modificación, los cambios son permanentes", 32 + 1)
        If consulta = 1 Then
            Me.EmpleadoTableAdapter.modificarEmpleado(txtNombre.Text, txtApellido.Text, txtDni.Text, txtTelefono.Text, txtLocalidad.Text, txtDireccion.Text, txtCp.Text, txtId_empleado.Text)
            Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)
            consulta_empleados.EmpleadoTableAdapter.Fill(consulta_empleados.BaseBellezaDataSet.empleado)
            MsgBox("Modificacion realizada con exito")
            Me.Close()
        End If

       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim codconsulta, fila As Integer
        codconsulta = txtId_empleado.Text
        fila = Me.EmpleadoBindingSource.Find("id_empleado", codconsulta)
        If fila = -1 Then
            MsgBox("No se encontro")
        Else
            EmpleadoTableAdapter.buscarEmpleado((Me.BaseBellezaDataSet.empleado), txtId_empleado.Text)
            txtNombre.Text = EmpleadoBindingSource.Current("nombre")
            txtApellido.Text = EmpleadoBindingSource.Current("apellido")
            txtDni.Text = EmpleadoBindingSource.Current("dni")
            txtTelefono.Text = EmpleadoBindingSource.Current("telefono")
            txtLocalidad.Text = EmpleadoBindingSource.Current("localidad")
            txtDireccion.Text = EmpleadoBindingSource.Current("direccion")
            txtCp.Text = EmpleadoBindingSource.Current("c_p")
            Button1.Enabled = True
        End If
    End Sub
End Class