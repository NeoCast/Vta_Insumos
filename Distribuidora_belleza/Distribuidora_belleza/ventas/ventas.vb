Public Class ventas


    Private Sub ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.BaseBellezaDataSet.articulos)
        DateTimePicker1.Value = Now

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

    End Sub
End Class