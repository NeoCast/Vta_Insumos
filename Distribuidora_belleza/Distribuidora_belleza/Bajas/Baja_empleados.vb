Public Class Baja_empleados

    Private Sub EmpleadoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub Baja_empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BaseBellezaDataSet.empleado)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        If TextBox1.Text = "" Then
            MsgBox("Ingrese un Id de empleado")
        Else
            Me.EmpleadoTableAdapter.buscarEmpleado((Me.BaseBellezaDataSet.empleado), TextBox1.Text)

        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim consulta, codconsulta, fila As Integer
        codconsulta = TextBox1.Text
        fila = Me.EmpleadoBindingSource.Find("id_empleado", codconsulta)
        If fila = -1 Then
            MsgBox("no se encontro")
        Else

            consulta = MsgBox("Desea eliminar empleado", 32 + 1)
            If consulta = 1 Then
                Me.EmpleadoTableAdapter.eliminarEmpleado(TextBox1.Text)
                Me.EmpleadoBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)
                Me.EmpleadoTableAdapter.Fill(Me.BaseBellezaDataSet.empleado)
                consulta_empleados.EmpleadoTableAdapter.Fill(Me.BaseBellezaDataSet.empleado)
            End If
        End If
    End Sub
End Class