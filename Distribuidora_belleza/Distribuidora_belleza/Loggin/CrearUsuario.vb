Public Class CrearUsuario

    Private Sub Registro_usuarioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Registro_usuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub CrearUsuario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UsuarioTextBox.Text = ""
        Id_empleadoComboBox.Text = ""
        NombreTextBox.Text = ""

    End Sub

    Private Sub CrearUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.BaseBellezaDataSet.empleado)
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.Registro_usuario' Puede moverla o quitarla según sea necesario.
        Me.Registro_usuarioTableAdapter.Fill(Me.BaseBellezaDataSet.Registro_usuario)
        Me.Registro_usuarioBindingSource.AddNew()
        UsuarioTextBox.Text = ""
        Id_empleadoComboBox.Text = ""
        NombreTextBox.Text = ""

        Id_empleadoComboBox.Enabled = False
        NombreTextBox.Enabled = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim empleado As Integer = 0
        If UsuarioTextBox.Text <> "" Then

            If ContraseñaTextBox.Text <> "" Then

                If ComboBox1.Text <> "" Then

                    If ComboBox1.SelectedIndex = 0 And Id_empleadoComboBox.Text = "" Then
                        MsgBox("Por favor seleccione el codigo correspondiente del empleado", vbCritical, "error")
                    ElseIf ComboBox1.SelectedIndex = 0 Then
                        
                        Me.Registro_usuarioTableAdapter.nuevoUsuario(UsuarioTextBox.Text, ContraseñaTextBox.Text, ComboBox1.Text, Convert.ToInt32(Id_empleadoComboBox.Text))
                        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)
                        MsgBox("se cargo con exito")
                        Me.Registro_usuarioTableAdapter.Fill(Me.BaseBellezaDataSet.Registro_usuario)
                        Consulta_usuarios.Registro_usuarioTableAdapter.Fill(Consulta_usuarios.BaseBellezaDataSet.Registro_usuario)
                        loggin2.Registro_usuarioTableAdapter.Fill(loggin2.BaseBellezaDataSet.Registro_usuario)
                        Me.Registro_usuarioBindingSource.AddNew()


                    ElseIf ComboBox1.SelectedIndex = 1 Then


                        Me.Registro_usuarioTableAdapter.nuevoUsuario(UsuarioTextBox.Text, ContraseñaTextBox.Text, ComboBox1.Text, empleado)
                        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)
                        MsgBox("se cargo con exito")
                        Me.Registro_usuarioTableAdapter.Fill(Me.BaseBellezaDataSet.Registro_usuario)
                        Consulta_usuarios.Registro_usuarioTableAdapter.Fill(Consulta_usuarios.BaseBellezaDataSet.Registro_usuario)
                        loggin2.Registro_usuarioTableAdapter.Fill(loggin2.BaseBellezaDataSet.Registro_usuario)
                        Me.Registro_usuarioBindingSource.AddNew()

                    End If
                Else
                    MsgBox("seleccione el tipo de usuario")
                End If
            Else

            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Id_empleadoComboBox.Enabled = True
            NombreTextBox.Enabled = True

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()

    End Sub
End Class