Public Class consulta_vta

    Private Sub VentasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub consulta_vta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.BaseBellezaDataSet.ventas)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Then
            Me.VentasTableAdapter.revisarvta((Me.BaseBellezaDataSet.ventas), Convert.ToInt32(TextBox1.Text))
        ElseIf RadioButton2.Checked = True Then
            Me.VentasTableAdapter.resumen_venta((Me.BaseBellezaDataSet.ventas), CDate(DateTimePicker1.Value), CDate(DateTimePicker2.Value))

        Else
            MsgBox("seleccione un metodo de busqueda")

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow
        For Each fila In VentasDataGridView.Rows
            total += Convert.ToDouble(fila.Cells("total").Value)


        Next fila

        TextBox2.Text = total

    End Sub
End Class