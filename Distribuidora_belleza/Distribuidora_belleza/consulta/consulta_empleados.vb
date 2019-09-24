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
            EmpleadoTableAdapter.consultaDni((Me.BaseBellezaDataSet.empleado), dni)
        End If
    End Sub
End Class