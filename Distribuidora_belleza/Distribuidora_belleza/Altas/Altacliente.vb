Imports System.Data
Imports System.Data.SqlServerCe

Public Class Altacliente

    Private dt As New DataTable

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

    End Sub

    Private Sub Altacliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BaseBellezaDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.BaseBellezaDataSet.cliente)

        Me.ClienteBindingSource.AddNew()

    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click

        If NombreTextBox.Text <> "" Then
            If TelefonoTextBox.Text <> "" And IsNumeric(TelefonoTextBox.Text) Then

                If MailTextBox.Text <> "" Then

                    Me.ClienteBindingSource.Current("nombre") = NombreTextBox.Text
                    Me.ClienteBindingSource.Current("telefono") = TelefonoTextBox.Text
                    Me.ClienteBindingSource.Current("mail") = MailTextBox.Text


                    Me.Validate()
                    Me.ClienteBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.BaseBellezaDataSet)

                    MsgBox("se cargo con exito")

                    Me.ClienteTableAdapter.Fill(Me.BaseBellezaDataSet.cliente)
                    inicio.ArticulosTableAdapter.Fill(inicio.BaseBellezaDataSet.articulos)

                    Me.ClienteBindingSource.AddNew()
                    NombreTextBox.Focus()

                Else
                    MsgBox("el campo de mail esta vacio")
                    Exit Sub

                End If
            Else
                MsgBox("el campo de telefono es incorrecto")
                Exit Sub

            End If
        Else
            MsgBox("el campo de nombre esta vacio")
            Exit Sub

        End If
        Dim dt As New DataTable
        Dim ultimo As Integer
        Dim ultimoCliente As New SqlCeCommand("SELECT MAX(Id_cliente) FROM [cliente]", conexion) 'trae el ultimo registro que se guardo
        conexion.Open() 'abro la conexion
        dt.TableName = "ultimoCliente"        'a la tabla creada le doy un nombre creo que no es necesario, pero asi estaba en internet
        dt.Load(ultimoCliente.ExecuteReader)   'lleno esa tabla declarada anteriormente con los datos que me trae la consulta de ultimoRegistro
        Dim reader As SqlCeDataReader = ultimoCliente.ExecuteReader

        'registro = ultimoRegistro.ExecuteReader



        If reader.Read Then
            ultimo = dt.Rows(0).Item(0).ToString
            reader.Close()
            MsgBox("El número de cliente es:    " + ultimo.ToString)
            conexion.Close()

        End If



    End Sub

    Private Sub btnfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfin.Click
        Me.Close()

    End Sub
End Class