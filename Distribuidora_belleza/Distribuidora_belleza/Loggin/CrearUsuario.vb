Public Class CrearUsuario

    Private Sub Registro_usuarioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Registro_usuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub CrearUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BaseBellezaDataSet.empleado)
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.Registro_usuario' Puede moverla o quitarla según sea necesario.
        Me.Registro_usuarioTableAdapter.Fill(Me.BaseBellezaDataSet.Registro_usuario)
        Me.Registro_usuarioBindingSource.AddNew()
        UsuarioTextBox.Text = ""
        With ComboBox1.Items
            .Add("cajero")
            .Add("admin")
        End With
        Id_empleadoComboBox.Enabled = False
        NombreTextBox.Enabled = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If UsuarioTextBox.Text = "" Then
            If ContraseñaTextBox.Text = "" Then
                If ComboBox1.Text = "" Then
                    If ComboBox1.SelectedIndex = 0 And Id_empleadoComboBox.Text = "" Then
                        MsgBox("Por favor seleccione el codigo correspondiente del empleado", vbCritical, "error")
                    Else
                        Me.Registro_usuarioBindingSource.Current("usuario") = UsuarioTextBox.Text
                        Me.Registro_usuarioBindingSource.Current("contraseña") = ContraseñaTextBox.Text
                        Me.Registro_usuarioBindingSource.Current("tipo") = Convert.ToString(ComboBox1.SelectedItem)
                        Me.Registro_usuarioBindingSource.Current("id_empleado") = Id_empleadoComboBox.SelectedItem
                        Me.Registro_usuarioBindingSource.EndEdit()
                        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)
                        Me.Registro_usuarioTableAdapter.Fill(Me.BaseBellezaDataSet.Registro_usuario)

                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Id_empleadoComboBox.Enabled = True
            NombreTextBox.Enabled = True

        End If
    End Sub
End Class