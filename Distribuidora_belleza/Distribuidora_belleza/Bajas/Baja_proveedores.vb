Public Class Baja_proveedores

    Private Sub ProveedorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub Baja_proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.BaseBellezaDataSet.proveedor)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Ingrese un Id de proveedor")
        Else
            Me.ProveedorTableAdapter.buscarProveedor((Me.BaseBellezaDataSet.proveedor), TextBox1.Text)

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim consulta As Integer
        consulta = MsgBox("Desea eliminar proveedor", 32 + 1)
        If consulta = 1 Then
            Me.ProveedorTableAdapter.eliminarProveedor(TextBox1.Text)
            Me.ProveedorTableAdapter.Fill(Me.BaseBellezaDataSet.proveedor)
            consulta_proveedor.ProveedorTableAdapter.Fill(Me.BaseBellezaDataSet.proveedor)

        End If
    End Sub
End Class