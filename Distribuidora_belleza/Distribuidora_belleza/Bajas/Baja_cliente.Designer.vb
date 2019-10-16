<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Baja_cliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseBellezaDataSet = New form1.BaseBellezaDataSet()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.ClienteTableAdapter = New form1.BaseBellezaDataSetTableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New form1.BaseBellezaDataSetTableAdapters.TableAdapterManager()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseBellezaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Id cliente"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(73, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(73, 225)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 9
        Me.BtnBuscar.Text = "buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(220, 94)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.Size = New System.Drawing.Size(440, 220)
        Me.ClienteDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn3.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "mail"
        Me.DataGridViewTextBoxColumn4.HeaderText = "mail"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.BaseBellezaDataSet
        '
        'BaseBellezaDataSet
        '
        Me.BaseBellezaDataSet.DataSetName = "BaseBellezaDataSet"
        Me.BaseBellezaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(73, 268)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 12
        Me.BtnEliminar.Text = "eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.articulosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.detalle_vtaTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.Registro_usuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = form1.BaseBellezaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'Baja_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(672, 334)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Baja_cliente"
        Me.Text = "Baja_cliente"
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseBellezaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BaseBellezaDataSet As form1.BaseBellezaDataSet
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As form1.BaseBellezaDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As form1.BaseBellezaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
End Class
