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
        Dim consulta As Integer

        consulta = MsgBox("Esta seguro de realizar la modificación, los cambios son permanentes", 32 + 1)
        If consulta = 1 Then


            Me.ClienteTableAdapter.modificarCliente(txtNombre.Text, txtTelefono.Text, txtMail.Text, txtId_cliente.Text)
            Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)
            consulta_cliente.ClienteTableAdapter.Fill(consulta_cliente.BaseBellezaDataSet.cliente)
            Me.ClienteTableAdapter.Fill(Me.BaseBellezaDataSet.cliente)
            MsgBox("Modificacion realizada con exito")
            Me.Close()
        End If
    End Sub
End Class