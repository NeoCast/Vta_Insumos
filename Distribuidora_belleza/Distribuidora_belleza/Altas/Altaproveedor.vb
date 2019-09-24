Public Class Altaproveedor

    Private Sub ProveedorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub Altaproveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.BaseBellezaDataSet.proveedor)
        Me.ProveedorBindingSource.AddNew()
    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        If NombreTextBox.Text <> "" Then
            If TelefonoTextBox.Text <> "" Then
                If MailTextBox.Text <> "" Then



                    Me.Validate() 'valida los datos para saber si son correctos en comparacion con la base 
                    Me.ProveedorBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet) 'el update nos permite actualizar el registro en blanco creado por el .addnew

                    MsgBox("se cargo con exito")
                    Me.ProveedorTableAdapter.Fill(Me.BaseBellezaDataSet.proveedor)
                    NombreTextBox.Focus()
                Else
                    MsgBox("ingrese un mail")
                    Exit Sub

                End If
            Else
                MsgBox("ingrese un telefono")
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