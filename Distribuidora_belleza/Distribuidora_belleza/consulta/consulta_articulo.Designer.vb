<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consulta_articulo
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
        Me.BaseBellezaDataSet = New form1.BaseBellezaDataSet()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosTableAdapter = New form1.BaseBellezaDataSetTableAdapters.articulosTableAdapter()
        Me.TableAdapterManager = New form1.BaseBellezaDataSetTableAdapters.TableAdapterManager()
        Me.ArticulosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.BaseBellezaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaseBellezaDataSet
        '
        Me.BaseBellezaDataSet.DataSetName = "BaseBellezaDataSet"
        Me.BaseBellezaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "articulos"
        Me.ArticulosBindingSource.DataSource = Me.BaseBellezaDataSet
        '
        'ArticulosTableAdapter
        '
        Me.ArticulosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.articulosTableAdapter = Me.ArticulosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = form1.BaseBellezaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArticulosDataGridView
        '
        Me.ArticulosDataGridView.AutoGenerateColumns = False
        Me.ArticulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticulosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ArticulosDataGridView.DataSource = Me.ArticulosBindingSource
        Me.ArticulosDataGridView.Location = New System.Drawing.Point(26, 69)
        Me.ArticulosDataGridView.Name = "ArticulosDataGridView"
        Me.ArticulosDataGridView.Size = New System.Drawing.Size(654, 287)
        Me.ArticulosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_articulo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_articulo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cantidad_stock"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cantidad_stock"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn4.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "rubro"
        Me.DataGridViewTextBoxColumn5.HeaderText = "rubro"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn6.HeaderText = "marca"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(489, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"id_articulo", "descripcion", "rubro", "marca"})
        Me.ComboBox1.Location = New System.Drawing.Point(158, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Elija una opción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Parametro de busqueda "
        '
        'consulta_articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 401)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ArticulosDataGridView)
        Me.Name = "consulta_articulo"
        Me.Text = "consulta_articulo"
        CType(Me.BaseBellezaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BaseBellezaDataSet As form1.BaseBellezaDataSet
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosTableAdapter As form1.BaseBellezaDataSetTableAdapters.articulosTableAdapter
    Friend WithEvents TableAdapterManager As form1.BaseBellezaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ArticulosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
