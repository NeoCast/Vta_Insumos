Imports System.Data.SqlServerCe
Imports System.Data

Public Class ventas

    Private comando As SqlCeCommand
    Private registro As SqlCeDataReader
    Private fecha As Date = Date.Now
    Private dt As New DataTable


    Private Sub ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.Registro_usuario' Puede moverla o quitarla según sea necesario.
        Me.Registro_usuarioTableAdapter.Fill(Me.BaseBellezaDataSet.Registro_usuario)
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.BaseBellezaDataSet.ventas)
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BaseBellezaDataSet.articulos)
        DateTimePicker1.Value = Now
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False


        lblCodEmp.Text = cod_empleado
        comando = New SqlCeCommand("select nombre from empleado where id_empleado= @id", conexion)
        comando.Parameters.AddWithValue("@id", lblCodEmp.Text)
        conexion.Open()
        registro = comando.ExecuteReader()
        If registro.Read() Then
            lblNombreEmp.Text = Convert.ToString(registro("nombre"))
        End If
        conexion.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim consulta As String
        consulta = TextBox1.Text

        If TextBox1.Text = "" Then
            MsgBox("El campo esta vacio")
        Else
            ArticulosTableAdapter.buscarArticulo((Me.BaseBellezaDataSet.articulos), TextBox1.Text)


            Me.txtDescripcion.Text = Me.ArticulosBindingSource.Current("descripcion")
            Me.txtPrecio.Text = Me.ArticulosBindingSource.Current("precio")
            Me.txtstock.Text = Me.ArticulosBindingSource.Current("cantidad_stock")
            Me.txtminimo.Text = Me.ArticulosBindingSource.Current("stock_minimo")
            If Val(txtstock.Text) < Val(txtminimo.Text) Then
                MsgBox("Por favor contacte al proveedor del articulo: " + TextBox1.Text + "para rellenar el stock")
            End If

            Button3.Enabled = True


        End If

    End Sub

    Private Sub ArticulosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ArticulosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        Dim cantidad As Integer
        Dim total As Double
        Dim precio As Double = Val(txtPrecio.Text)
        cantidad = NumericUpDown1.Value
        total = cantidad * precio
        txtTotal.Text = total


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If NumericUpDown1.Value = 0 Then
            MsgBox("por favor ingrese una cantidad valida")
            Exit Sub
        Else
            DataGridView1.Rows.Add(TextBox1.Text, txtDescripcion.Text, txtPrecio.Text, NumericUpDown1.Value, txtTotal.Text)

            Button2.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True


            TextBox1.Clear()
            txtDescripcion.Clear()
            txtPrecio.Clear()
            NumericUpDown1.Value = 0
            txtTotal.Clear()
        End If

     




    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow
        For Each fila In DataGridView1.Rows
            total += Convert.ToDouble(fila.Cells("Total").Value)


        Next fila
        txtVentaTotal.Text = total


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ' Dim stock, stockMin, checkStock As Integer
        Dim q As Integer = 0

        Dim fila As New DataGridViewRow 'creo el objeto fila de la clase datagridviewRow para poder recorrer todas las filas del datagrid del form

        For Each fila In DataGridView1.Rows 'utilizo este for each solo para evaluar que no se quiera enviar una venta vacia
            q += 1


        Next fila
        If q = 1 Then
            MsgBox("no hay nada")
            Exit Sub

        End If
       

        'armo el insert con sus parametros correspondientes
        Dim cmdVentas As New SqlCeCommand("insert into ventas(fecha,total,cod_vendedor,cod_cliente) values (@fecha, @total, @cod_vendedor, @cod_cliente)", conexion)
        Dim ultimaVenta As Integer
        'agrego los parametros para el insert
        With cmdVentas.Parameters
            .Add("@fecha", SqlDbType.DateTime).Value = fecha
            .Add("@total", SqlDbType.Float).Value = Val(txtVentaTotal.Text)
            .Add("@cod_vendedor", SqlDbType.Int).Value = lblCodEmp.Text
            .Add("@cod_cliente", SqlDbType.Int).Value = txtCliente.Text

        End With
        conexion.Open() 'abro la conexion a la base


        cmdVentas.ExecuteNonQuery() ' ejecuto el insert
        MsgBox("venta realizada con exito")

        conexion.Close() 'cierro la conexion a la base
        'Try
        Dim ultimoRegistro As New SqlCeCommand("SELECT MAX(Id_ventas) FROM [ventas]", conexion) 'trae el ultimo registro que se guardo
        conexion.Open() 'abro la conexion
        dt.TableName = "ultimaVenta"        'a la tabla creada le doy un nombre creo que no es necesario, pero asi estaba en internet
        dt.Load(ultimoRegistro.ExecuteReader)   'lleno esa tabla declarada anteriormente con los datos que me trae la consulta de ultimoRegistro
        Dim reader As SqlCeDataReader = ultimoRegistro.ExecuteReader

        'registro = ultimoRegistro.ExecuteReader



        If reader.Read Then
            ultimaVenta = dt.Rows(0).Item(0).ToString
            reader.Close()
            MsgBox("busqueda del primero con exito")
            conexion.Close()

        End If

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try


        'Try


        For Each fila In DataGridView1.Rows 'recorro todas las filas del datagridview
            If IsDBNull(fila.Cells) Then    'pregunto si la fila es un dato nulo para la base de datos
                MsgBox("carga finalizada")
                Exit Sub
            Else
                Dim cmd As New SqlCeCommand("insert into detalle_vta(id_venta,id_cliente,id_vendedor,id_articulo,descripcion,precio,cantidad,total_articulo,fecha) values (@id_venta,@id_cliente,@id_vendedor,@id_art, @descripcion, @precio, @cantidad, @total, @fecha)", conexion)
                Dim update As New SqlCeCommand("update articulos set cantidad_stock=@cant where id_articulo ='" & Convert.ToInt32(fila.Cells("Id_Articulo").Value) & "'")
                update.Parameters.Add("cant", SqlDbType.Int).Value = Convert.ToInt32(fila.Cells("Cantidad").Value)
                'agrego los parametros para el insert
                With cmd.Parameters
                    .Add("@id_venta", SqlDbType.Int).Value = ultimaVenta
                    .Add("@id_cliente", SqlDbType.Int).Value = Convert.ToInt32(txtCliente.Text)
                    .Add("@id_vendedor", SqlDbType.Int).Value = Convert.ToInt32(lblCodEmp.Text)
                    .Add("@id_art", SqlDbType.Int).Value = Convert.ToInt32(fila.Cells("Id_Articulo").Value)
                    .Add("@descripcion", SqlDbType.NVarChar).Value = Convert.ToString(fila.Cells("Descripcion").Value)
                    .Add("@precio", SqlDbType.Float).Value = Convert.ToDouble(fila.Cells("Precio").Value)
                    .Add("@cantidad", SqlDbType.Int).Value = Convert.ToInt32(fila.Cells("Cantidad").Value)
                    .Add("@total", SqlDbType.Float).Value = Convert.ToDouble(fila.Cells("Total").Value)
                    .Add("@fecha", SqlDbType.DateTime).Value = Convert.ToDateTime(fecha)
                End With


                conexion.Open() 'abro la conexion

                cmd.ExecuteNonQuery() ' ejecuto el insert
                update.ExecuteNonQuery() 'ejecuto el update para cambiar el valor del stock


                conexion.Close()    'cierro la conexion
            End If


        Next fila
        MsgBox("se ha cargado con exito")
        conexion.Close()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Try
            DataGridView1.Rows.RemoveAt(i)

        Catch ex As Exception
            Exit Sub

        End Try




    End Sub


    Private Sub BtnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsulta.Click
        If txtCliente.Text <> "" Then
            If consultarPersona(txtCliente.Text) = True Then
                MsgBox("el usuario esta registrado")
            Else
                MsgBox("no se encontro el usuario")
            End If
        End If
    End Sub


    Function consultarPersona(ByVal id As String) As Boolean
        Dim resultado As Boolean = False

        Try
            comando = New SqlCeCommand("select * from cliente where id_cliente= '" & id & "'", conexion)
            conexion.Open()

            registro = comando.ExecuteReader
            If registro.Read = True Then
                registro.Close()

                resultado = True
            End If
            conexion.Close()

        Catch ex As Exception
            MsgBox("Error: " + ex.ToString)
        End Try
        Return resultado

    End Function


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbltiempo.Text = Date.Now.ToLongTimeString


    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        lblfecha.Text = Date.Now.ToShortDateString

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Altacliente.Show()

    End Sub
End Class