Public Class consulta_cliente

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub consulta_cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.BaseBellezaDataSet.cliente)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text = "" Then
            ClienteTableAdapter.Fill(Me.BaseBellezaDataSet.cliente)
        Else
            ClienteTableAdapter.consultarNombre((Me.BaseBellezaDataSet.cliente), TextBox1.Text)
        End If
    End Sub
End Class