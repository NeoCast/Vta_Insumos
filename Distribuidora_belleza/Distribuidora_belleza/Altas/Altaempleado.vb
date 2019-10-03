Public Class Altaempleado

    Private Sub EmpleadoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub Altaempleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BaseBellezaDataSet.empleado)
        Me.EmpleadoBindingSource.AddNew()
    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        If NombreTextBox.Text <> "" Then
            If ApellidoTextBox.Text <> "" Then
                If DniTextBox.Text <> "" And Len(DniTextBox.Text) >= 7 And Len(DniTextBox.Text) <= 10 And IsNumeric(DniTextBox.Text) Then
                    If TelefonoTextBox.Text <> "" And IsNumeric(TelefonoTextBox.Text) Then

                        Me.Validate()
                        Me.EmpleadoBindingSource.EndEdit()
                        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

                        MsgBox("se cargo con exito")
                        consulta_empleados.EmpleadoTableAdapter.Fill(Me.BaseBellezaDataSet.empleado)
                        NombreTextBox.Focus()
                        Me.EmpleadoBindingSource.AddNew()



                    Else
                        MsgBox("el campo del telefono es incorrecto")
                        Exit Sub

                    End If
                Else
                    MsgBox("el campo dni es incorrecto")
                    Exit Sub

                End If
            Else
                MsgBox("ingrese un apellido")
                Exit Sub

            End If
        Else
            MsgBox("ingrese un nombre")
            Exit Sub

        End If



      
    End Sub

    Private Sub btnfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfin.Click
        Me.Close()

    End Sub
End Class