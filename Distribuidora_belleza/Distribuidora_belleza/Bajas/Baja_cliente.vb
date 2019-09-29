Public Class Baja_cliente

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub Baja_cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.BaseBellezaDataSet.cliente)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        If TextBox1.Text = "" Then
            MsgBox("Ingrese un Id de cliente")
        Else
            Me.ClienteTableAdapter.buscarCliente((Me.BaseBellezaDataSet.cliente), TextBox1.Text)

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim consulta As Integer
        consulta = MsgBox("Desea eliminar cliente", 32 + 1)
        If consulta = 1 Then
            Me.ClienteTableAdapter.eliminarCliente(TextBox1.Text)
            Me.ClienteTableAdapter.Fill(Me.BaseBellezaDataSet.cliente)
            consulta_cliente.ClienteTableAdapter.Fill(Me.BaseBellezaDataSet.cliente)

        End If

    End Sub
End Class