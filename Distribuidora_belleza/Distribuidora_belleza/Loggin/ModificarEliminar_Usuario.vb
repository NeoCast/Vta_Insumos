﻿Public Class ModificarEliminar_Usuario

    Private Sub Registro_usuarioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Registro_usuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub ModificarEliminar_Usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.Registro_usuario' Puede moverla o quitarla según sea necesario.
        Me.Registro_usuarioTableAdapter.Fill(Me.BaseBellezaDataSet.Registro_usuario)
        txtId_empleado.Enabled = False

    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim consulta As Integer
        consulta = MsgBox("Esta seguro de actualizar los datos, los cambios que realice serán permanente", 32 + 1)
        If consulta = 1 Then

            Me.Registro_usuarioTableAdapter.ActualizarUsuario(txtContraseña.Text, txtTipo.Text, txtId_empleado.Text, txtUsuario.Text)
            Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)
            Consulta_usuarios.Registro_usuarioTableAdapter.Fill(Consulta_usuarios.BaseBellezaDataSet.Registro_usuario)
            Me.Close()

        End If
    End Sub

   
End Class