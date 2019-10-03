﻿Imports System.Data.SqlServerCe


Public Class ventas


    Private Sub ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.BaseBellezaDataSet.ventas)
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BaseBellezaDataSet.articulos)
        DateTimePicker1.Value = Now
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
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
        DataGridView1.Rows.Add(TextBox1.Text, txtDescripcion.Text, txtPrecio.Text, NumericUpDown1.Value, txtTotal.Text)

        Button2.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True


        TextBox1.Clear()
        txtDescripcion.Clear()
        txtPrecio.Clear()
        NumericUpDown1.Value = 0
        txtTotal.Clear()




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

        Dim conexion As New SqlCeConnection("Data Source= C:\Users\Usuario\Documents\github\Vta_Insumos\Distribuidora_belleza\Distribuidora_belleza\BaseBelleza.sdf")


        Dim fila As DataGridViewRow = New DataGridViewRow
        'Try


        For Each fila In DataGridView1.Rows
            Dim cmd As New SqlCeCommand("insert into ventas(Id_articulo,fecha,precio_unitario,cantidad,total,descripcion) values (@p1, @p2, @p3, @p4, @p5, @p6)", conexion)
            conexion.Open()

            'Me.VentasBindingSource.Current("id_articulo") = fila.Cells("")
            cmd.Parameters.Add("@p1", SqlDbType.Int).Value = Convert.ToInt32(fila.Cells("Id_Articulo").Value)
            cmd.Parameters.Add("@p2", SqlDbType.DateTime).Value = Convert.ToDateTime(DateTimePicker1.Value)
            cmd.Parameters.Add("@p3", SqlDbType.Float).Value = Convert.ToDouble(fila.Cells("Precio").Value)
            cmd.Parameters.Add("@p4", SqlDbType.Int).Value = Convert.ToInt32(fila.Cells("Cantidad").Value)
            cmd.Parameters.Add("@p5", SqlDbType.Float).Value = Convert.ToDouble(fila.Cells("Total").Value)
            cmd.Parameters.Add("@p6", SqlDbType.NVarChar).Value = Convert.ToString(fila.Cells("Descripcion").Value)
            cmd.ExecuteNonQuery()


            conexion.Close()

        Next fila
        MsgBox("se ha cargado con exito")
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        DataGridView1.Rows.RemoveAt(i)

    End Sub
End Class