Imports System.Data
Imports System.Data.SqlServerCe


Public Class Altaempleado

    Private comando As SqlCeCommand
    Private registro As SqlCeDataReader

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
                        If consultarPersona(DniTextBox.Text) = True Then
                            MsgBox("el dni ya existe")
                            Exit Sub

                        Else
                            Me.Validate()
                            Me.EmpleadoBindingSource.EndEdit()
                            Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

                            MsgBox("se cargo con exito")
                            consulta_empleados.EmpleadoTableAdapter.Fill(Me.BaseBellezaDataSet.empleado)
                            NombreTextBox.Focus()
                            Me.EmpleadoBindingSource.AddNew()
                        End If
                      



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
    Function consultarPersona(ByVal dni As String) As Boolean
        Dim resultado As Boolean = False

        Try
            comando = New SqlCeCommand("select * from empleado where dni=@dni ", conexion)
            comando.Parameters.Add("@dni", SqlDbType.Int).Value = dni

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
End Class