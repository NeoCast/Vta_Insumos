Public Class ModificarProveedor


    Private Sub ModificarProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.BaseBellezaDataSet.proveedor)
        'txtId_proveedor.Enabled = False
        Button1.Enabled = False

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

  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim codconsulta, fila As Integer
        codconsulta = txtId_proveedor.Text
        fila = Me.ProveedorBindingSource.Find("id_proveedor", txtId_proveedor.Text)
        If fila = -1 Then
            MsgBox("No se encontro")
        Else
            ProveedorTableAdapter.buscarProveedor((Me.BaseBellezaDataSet.proveedor), txtId_proveedor.Text)
            txtNombre.Text = ProveedorBindingSource.Current("nombre")
            txtTelefono.Text = ProveedorBindingSource.Current("telefono")
            txtMail.Text = ProveedorBindingSource.Current("mail")
            txtLocalidad.Text = ProveedorBindingSource.Current("localidad")
            txtDireccion.Text = ProveedorBindingSource.Current("direccion")
            txtC_p.Text = ProveedorBindingSource.Current("c_p")
            Button1.Enabled = True
        End If
    End Sub
End Class