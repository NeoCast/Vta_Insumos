Imports System.Data
Imports System.Data.SqlServerCe

Public Class Loggin

    Public conexion As New SqlCeConnection("Data Source=C:\Users\Usuario\Documents\github\Vta_Insumos\Distribuidora_belleza\Distribuidora_belleza\BaseBelleza.sdf")
    Public comando As SqlCeCommand
    Public da As SqlCeDataAdapter
    Public tabla As DataTable
    Public Sub login(ByVal usuario As String, ByVal contraseña As String)
        Try
            conexion.Open()
            comando = New SqlCeCommand("select usuario, tipo from Registro_usuario where usuario= @usuario and contraseña=@contraseña", conexion)

            comando.Parameters.Add("usuario")
            comando.Parameters.Add("contraseña")
            comando.Parameters("usuario").Value = Convert.ToString(usuario)
            comando.Parameters("contraseña").Value = Convert.ToString(contraseña)
            da = New SqlCeDataAdapter(comando)
            tabla = New DataTable()
            da.Fill(tabla)
            If tabla.Rows.Count = 1 Then
                Me.Hide()
                If Convert.ToString(tabla.Rows(0)(1)) = "admin" Then

                    tipo_usuario = 1
                    inicio.Show()

                ElseIf Convert.ToString(tabla.Rows(0)(1)) = "cajero" Then

                    tipo_usuario = 2
                    inicio.Show()

                Else
                    MsgBox("usuario y/o contraseña incorrecta", vbExclamation, "error")

                End If

            End If

        Catch ex As Exception

            MsgBox("error" + ex.ToString)
        Finally
            conexion.Close()

        End Try
    End Sub
    Private Sub Loggin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.Registro_usuario' Puede moverla o quitarla según sea necesario.
        Me.Registro_usuarioTableAdapter.Fill(Me.BaseBellezaDataSet.Registro_usuario)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        login(Me.TextBox1.Text, Me.TextBox2.Text)
    End Sub

    Private Sub Registro_usuarioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Registro_usuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub
End Class