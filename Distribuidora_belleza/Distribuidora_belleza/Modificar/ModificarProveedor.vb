Public Class ModificarProveedor


    Private Sub ModificarProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.BaseBellezaDataSet.proveedor)
        'txtId_proveedor.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim consulta As Integer

        consulta = MsgBox("Esta seguro de realizar la modificación, los cambios son permanentes", 32 + 1)
        If consulta = 1 Then
            Me.ProveedorTableAdapter.modificarProveeedor(txtNombre.Text, txtTelefono.Text, txtMail.Text, txtLocalidad.Text, txtDireccion.Text, txtC_p.Text, txtId_proveedor.Text)
            Me.ProveedorBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)
            consulta_proveedor.ProveedorTableAdapter.Fill(consulta_proveedor.BaseBellezaDataSet.proveedor)
            MsgBox("Modificacion realizada con exito")
            Me.Close()

        End If

    End Sub

  
End Class