<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaArticulo
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Cantidad_stockLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim RubroLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim Stock_minimoLabel As System.Windows.Forms.Label
        Dim Id_proveedorLabel As System.Windows.Forms.Label
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseBellezaDataSet = New form1.BaseBellezaDataSet()
        Me.Cantidad_stockTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.RubroTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnfin = New System.Windows.Forms.Button()
        Me.Stock_minimoTextBox = New System.Windows.Forms.TextBox()
        Me.ArticulosTableAdapter = New form1.BaseBellezaDataSetTableAdapters.articulosTableAdapter()
        Me.TableAdapterManager = New form1.BaseBellezaDataSetTableAdapters.TableAdapterManager()
        Me.ArticulosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New form1.BaseBellezaDataSetTableAdapters.proveedorTableAdapter()
        Me.Id_proveedorComboBox = New System.Windows.Forms.ComboBox()
        DescripcionLabel = New System.Windows.Forms.Label()
        Cantidad_stockLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        RubroLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        Stock_minimoLabel = New System.Windows.Forms.Label()
        Id_proveedorLabel = New System.Windows.Forms.Label()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseBellezaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(75, 37)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(64, 13)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "descripcion:"
        '
        'Cantidad_stockLabel
        '
        Cantidad_stockLabel.AutoSize = True
        Cantidad_stockLabel.Location = New System.Drawing.Point(75, 83)
        Cantidad_stockLabel.Name = "Cantidad_stockLabel"
        Cantidad_stockLabel.Size = New System.Drawing.Size(80, 13)
        Cantidad_stockLabel.TabIndex = 5
        Cantidad_stockLabel.Text = "cantidad stock:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(75, 124)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(39, 13)
        PrecioLabel.TabIndex = 7
        PrecioLabel.Text = "precio:"
        '
        'RubroLabel
        '
        RubroLabel.AutoSize = True
        RubroLabel.Location = New System.Drawing.Point(75, 167)
        RubroLabel.Name = "RubroLabel"
        RubroLabel.Size = New System.Drawing.Size(34, 13)
        RubroLabel.TabIndex = 9
        RubroLabel.Text = "rubro:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(75, 209)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(39, 13)
        MarcaLabel.TabIndex = 11
        MarcaLabel.Text = "marca:"
        '
        'Stock_minimoLabel
        '
        Stock_minimoLabel.AutoSize = True
        Stock_minimoLabel.Location = New System.Drawing.Point(75, 248)
        Stock_minimoLabel.Name = "Stock_minimoLabel"
        Stock_minimoLabel.Size = New System.Drawing.Size(71, 13)
        Stock_minimoLabel.TabIndex = 14
        Stock_minimoLabel.Text = "stock minimo:"
        '
        'Id_proveedorLabel
        '
        Id_proveedorLabel.AutoSize = True
        Id_proveedorLabel.Location = New System.Drawing.Point(75, 293)
        Id_proveedorLabel.Name = "Id_proveedorLabel"
        Id_proveedorLabel.Size = New System.Drawing.Size(69, 13)
        Id_proveedorLabel.TabIndex = 15
        Id_proveedorLabel.Text = "id proveedor:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(161, 34)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "articulos"
        Me.ArticulosBindingSource.DataSource = Me.BaseBellezaDataSet
        '
        'BaseBellezaDataSet
        '
        Me.BaseBellezaDataSet.DataSetName = "BaseBellezaDataSet"
        Me.BaseBellezaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cantidad_stockTextBox
        '
        Me.Cantidad_stockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "cantidad_stock", True))
        Me.Cantidad_stockTextBox.Location = New System.Drawing.Point(161, 80)
        Me.Cantidad_stockTextBox.Name = "Cantidad_stockTextBox"
        Me.Cantidad_stockTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cantidad_stockTextBox.TabIndex = 6
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(161, 121)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioTextBox.TabIndex = 8
        '
        'RubroTextBox
        '
        Me.RubroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "rubro", True))
        Me.RubroTextBox.Location = New System.Drawing.Point(161, 164)
        Me.RubroTextBox.Name = "RubroTextBox"
        Me.RubroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RubroTextBox.TabIndex = 10
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(161, 206)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MarcaTextBox.TabIndex = 12
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(101, 336)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 13
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnfin
        '
        Me.btnfin.Location = New System.Drawing.Point(223, 336)
        Me.btnfin.Name = "btnfin"
        Me.btnfin.Size = New System.Drawing.Size(75, 23)
        Me.btnfin.TabIndex = 14
        Me.btnfin.Text = "fin"
        Me.btnfin.UseVisualStyleBackColor = True
        '
        'Stock_minimoTextBox
        '
        Me.Stock_minimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "stock_minimo", True))
        Me.Stock_minimoTextBox.Location = New System.Drawing.Point(161, 248)
        Me.Stock_minimoTextBox.Name = "Stock_minimoTextBox"
        Me.Stock_minimoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Stock_minimoTextBox.TabIndex = 15
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
        Me.TableAdapterManager.detalle_vtaTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = form1.BaseBellezaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'ArticulosDataGridView
        '
        Me.ArticulosDataGridView.AutoGenerateColumns = False
        Me.ArticulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticulosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ArticulosDataGridView.DataSource = Me.ArticulosBindingSource
        Me.ArticulosDataGridView.Location = New System.Drawing.Point(333, 61)
        Me.ArticulosDataGridView.Name = "ArticulosDataGridView"
        Me.ArticulosDataGridView.Size = New System.Drawing.Size(428, 220)
        Me.ArticulosDataGridView.TabIndex = 15
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
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "id_proveedor"
        Me.DataGridViewTextBoxColumn7.HeaderText = "id_proveedor"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "stock_minimo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "stock_minimo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me.BaseBellezaDataSet
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'Id_proveedorComboBox
        '
        Me.Id_proveedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "id_proveedor", True))
        Me.Id_proveedorComboBox.FormattingEnabled = True
        Me.Id_proveedorComboBox.Location = New System.Drawing.Point(161, 290)
        Me.Id_proveedorComboBox.Name = "Id_proveedorComboBox"
        Me.Id_proveedorComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Id_proveedorComboBox.TabIndex = 16
        '
        'AltaArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 399)
        Me.Controls.Add(Id_proveedorLabel)
        Me.Controls.Add(Me.Id_proveedorComboBox)
        Me.Controls.Add(Me.ArticulosDataGridView)
        Me.Controls.Add(Stock_minimoLabel)
        Me.Controls.Add(Me.Stock_minimoTextBox)
        Me.Controls.Add(Me.btnfin)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Cantidad_stockLabel)
        Me.Controls.Add(Me.Cantidad_stockTextBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(RubroLabel)
        Me.Controls.Add(Me.RubroTextBox)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(Me.MarcaTextBox)
        Me.Name = "AltaArticulo"
        Me.Text = "ALTA DE ARTICULO"
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseBellezaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BaseBellezaDataSet As form1.BaseBellezaDataSet
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArticulosTableAdapter As form1.BaseBellezaDataSetTableAdapters.articulosTableAdapter
    Friend WithEvents TableAdapterManager As form1.BaseBellezaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cantidad_stockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RubroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents btnfin As System.Windows.Forms.Button
    Friend WithEvents Stock_minimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ArticulosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedorTableAdapter As form1.BaseBellezaDataSetTableAdapters.proveedorTableAdapter
    Friend WithEvents Id_proveedorComboBox As System.Windows.Forms.ComboBox
End Class
