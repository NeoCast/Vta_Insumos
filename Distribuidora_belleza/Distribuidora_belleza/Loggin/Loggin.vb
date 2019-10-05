Public Class Loggin

    Private Sub Loggin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.Registro_usuario' Puede moverla o quitarla según sea necesario.
        Me.Registro_usuarioTableAdapter.Fill(Me.BaseBellezaDataSet.Registro_usuario)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            If TextBox2.Text <> "" Then
                Dim consulta As Integer
                consulta = Me.Registro_usuarioBindingSource.Find("usuario", TextBox1.Text)
                If consulta = -1 Then
                    MsgBox("El usuario no existe", vbExclamation, "Error en el usuario")
                    TextBox1.Focus()
                Else

                    Me.Registro_usuarioBindingSource.Position = consulta

                    If Me.Registro_usuarioBindingSource.Current("contraseña") = TextBox2.Text Then

                        If Me.Registro_usuarioBindingSource.Current("tipo") = "cajero" Then
                            tipo_usuario = 2
                        Else
                            tipo_usuario = 1
                        End If
                    End If
                End If

            Else
                MsgBox("ingrese una contraseña", vbCritical)
                Exit Sub
            End If
        Else
            MsgBox("ingrese un usuario", vbCritical)
            Exit Sub
        End If
    End Sub

    Private Sub Registro_usuarioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Registro_usuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub
End Class