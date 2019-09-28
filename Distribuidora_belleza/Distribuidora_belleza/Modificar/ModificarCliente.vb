Public Class ModificarCliente

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub ModificarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.BaseBellezaDataSet.cliente)
        txtId_cliente.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ClienteTableAdapter.modificarCliente(txtNombre.Text, txtTelefono.Text, txtMail.Text, txtId_cliente.Text)
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)
        consulta_cliente.ClienteTableAdapter.Fill(consulta_cliente.BaseBellezaDataSet.cliente)
        Me.Close()
    End Sub
End Class