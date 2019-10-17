Public Class inicio

    Private Sub inicio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim resultado As Integer
        resultado = MsgBox("¿Desea cerrar sesion?", 32 + 1)
        If resultado <> 1 Then
            e.Cancel = True
        Else

            loggin2.Show()

        End If
    End Sub


    Private Sub inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BaseBellezaDataSet.articulos)
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.BaseBellezaDataSet.proveedor)
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BaseBellezaDataSet.empleado)
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.BaseBellezaDataSet.cliente)
        If tipo_usuario = 2 Then
            EliminarToolStripMenuItem.Enabled = False
            UsuariosToolStripMenuItem.Enabled = False
            ModifivcToolStripMenuItem.Enabled = False


        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        consulta_articulo.ShowDialog()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        consulta_cliente.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        consulta_empleados.ShowDialog()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        consulta_proveedor.ShowDialog()

    End Sub

    Private Sub ArticuloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticuloToolStripMenuItem.Click
        AltaArticulo.ShowDialog()

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem.Click
        Altacliente.ShowDialog()

    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadoToolStripMenuItem.Click
        Altaempleado.ShowDialog()

    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedorToolStripMenuItem.Click
        Altaproveedor.ShowDialog()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub ClienteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem1.Click
        Baja_cliente.ShowDialog()

    End Sub



    Private Sub ArticuloToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticuloToolStripMenuItem1.Click
        Baja_articulo.ShowDialog()

    End Sub

    Private Sub ClienteToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem2.Click
        Baja_empleados.ShowDialog()
    End Sub

    Private Sub ProveedorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedorToolStripMenuItem1.Click
        Baja_proveedores.ShowDialog()

    End Sub


    Private Sub NuevaVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaVentaToolStripMenuItem.Click
        ventas.ShowDialog()


    End Sub

    Private Sub VentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentaToolStripMenuItem.Click
        consulta_vta.ShowDialog()

    End Sub

    Private Sub DetalleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetalleToolStripMenuItem.Click
        consulta_detalle.ShowDialog()


    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Close()
        'loggin2.Show()

    End Sub

    
    
    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        Ayuda.ShowDialog()

    End Sub

   

    Private Sub CrearUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearUsuarioToolStripMenuItem.Click
        CrearUsuario.ShowDialog()

    End Sub

    Private Sub ConsultarYEliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarYEliminarToolStripMenuItem.Click
        Consulta_usuarios.ShowDialog()
    End Sub

    Private Sub ModificarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModificarEliminar_Usuario.ShowDialog()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVender.Click
        ventas.ShowDialog()

    End Sub

    Private Sub ArticuloToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticuloToolStripMenuItem2.Click
        ModificarArticulo.ShowDialog()


    End Sub

    Private Sub ClienteToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem3.Click
        ModificarCliente.ShowDialog()


    End Sub

    Private Sub ProveedorToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedorToolStripMenuItem2.Click
        ModificarProveedor.ShowDialog()

    End Sub

    Private Sub EmpleadoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadoToolStripMenuItem1.Click
        ModificarEmpleado.ShowDialog()

    End Sub

    Private Sub ModifivcToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifivcToolStripMenuItem.Click

    End Sub
End Class