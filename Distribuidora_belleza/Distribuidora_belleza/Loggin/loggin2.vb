Public Class loggin2

    Private Sub loggin2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.Registro_usuario' Puede moverla o quitarla según sea necesario.
        Me.Registro_usuarioTableAdapter.Fill(Me.BaseBellezaDataSet.Registro_usuario)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("Todos los campos tienen que estar completos")
        ElseIf TextBox2.Text = "" Then


            MsgBox("Todos los campos tienen que estar completos")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Focus()
        Else
            Dim consulta As Integer
            consulta = Me.Registro_usuarioBindingSource.Find("usuario", TextBox1.Text)
            If consulta = -1 Then
                MsgBox("El usuario ingresado no existe", vbExclamation, "Ingreso")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox1.Focus()
            Else
                Me.Registro_usuarioBindingSource.Position = consulta
                If Me.Registro_usuarioBindingSource.Current("contraseña") = TextBox2.Text Then
                    If Me.Registro_usuarioBindingSource.Current("tipo") = "cajero" Then

                        tipo_usuario = 2
                        usuario = TextBox1.Text
                        cod_empleado = Registro_usuarioBindingSource.Current("id_empleado")
                        MsgBox("Bienvenido. Codigo de empleado: " & cod_empleado)
                    Else
                        tipo_usuario = 1
                    End If

                    inicio.Show()
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    Me.Hide()

                Else

                    TextBox2.Text = ""
                    TextBox2.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub Registro_usuarioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Registro_usuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub
End Class