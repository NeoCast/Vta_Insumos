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
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Cantidad_stockTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.RubroTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnfin = New System.Windows.Forms.Button()
        Me.ArticulosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseBellezaDataSet = New form1.BaseBellezaDataSet()
        Me.ArticulosTableAdapter = New form1.BaseBellezaDataSetTableAdapters.articulosTableAdapter()
        Me.TableAdapterManager = New form1.BaseBellezaDataSetTableAdapters.TableAdapterManager()
        DescripcionLabel = New System.Windows.Forms.Label()
        Cantidad_stockLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        RubroLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        CType(Me.ArticulosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseBellezaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(96, 52)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(64, 13)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "descripcion:"
        '
        'Cantidad_stockLabel
        '
        Cantidad_stockLabel.AutoSize = True
        Cantidad_stockLabel.Location = New System.Drawing.Point(96, 98)
        Cantidad_stockLabel.Name = "Cantidad_stockLabel"
        Cantidad_stockLabel.Size = New System.Drawing.Size(80, 13)
        Cantidad_stockLabel.TabIndex = 5
        Cantidad_stockLabel.Text = "cantidad stock:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(96, 139)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(39, 13)
        PrecioLabel.TabIndex = 7
        PrecioLabel.Text = "precio:"
        '
        'RubroLabel
        '
        RubroLabel.AutoSize = True
        RubroLabel.Location = New System.Drawing.Point(96, 182)
        RubroLabel.Name = "RubroLabel"
        RubroLabel.Size = New System.Drawing.Size(34, 13)
        RubroLabel.TabIndex = 9
        RubroLabel.Text = "rubro:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(96, 224)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(39, 13)
        MarcaLabel.TabIndex = 11
        MarcaLabel.Text = "marca:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(182, 49)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'Cantidad_stockTextBox
        '
        Me.Cantidad_stockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "cantidad_stock", True))
        Me.Cantidad_stockTextBox.Location = New System.Drawing.Point(182, 95)
        Me.Cantidad_stockTextBox.Name = "Cantidad_stockTextBox"
        Me.Cantidad_stockTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cantidad_stockTextBox.TabIndex = 6
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(182, 136)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioTextBox.TabIndex = 8
        '
        'RubroTextBox
        '
        Me.RubroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "rubro", True))
        Me.RubroTextBox.Location = New System.Drawing.Point(182, 179)
        Me.RubroTextBox.Name = "RubroTextBox"
        Me.RubroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RubroTextBox.TabIndex = 10
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(182, 221)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MarcaTextBox.TabIndex = 12
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(99, 276)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 13
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnfin
        '
        Me.btnfin.Location = New System.Drawing.Point(230, 276)
        Me.btnfin.Name = "btnfin"
        Me.btnfin.Size = New System.Drawing.Size(75, 23)
        Me.btnfin.TabIndex = 14
        Me.btnfin.Text = "fin"
        Me.btnfin.UseVisualStyleBackColor = True
        '
        'ArticulosDataGridView
        '
        Me.ArticulosDataGridView.AutoGenerateColumns = False
        Me.ArticulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArticulosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ArticulosDataGridView.DataSource = Me.ArticulosBindingSource
        Me.ArticulosDataGridView.Location = New System.Drawing.Point(306, 37)
        Me.ArticulosDataGridView.Name = "ArticulosDataGridView"
        Me.ArticulosDataGridView.Size = New System.Drawing.Size(447, 204)
        Me.ArticulosDataGridView.TabIndex = 14
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
        'AltaArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 349)
        Me.Controls.Add(Me.ArticulosDataGridView)
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
        Me.Text = "Form2"
        CType(Me.ArticulosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseBellezaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ArticulosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
