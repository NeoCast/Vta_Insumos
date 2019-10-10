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
        Dim NombreLabel As System.Windows.Forms.Label
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
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New form1.BaseBellezaDataSetTableAdapters.proveedorTableAdapter()
        Me.Id_proveedorComboBox = New System.Windows.Forms.ComboBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        DescripcionLabel = New System.Windows.Forms.Label()
        Cantidad_stockLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        RubroLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        Stock_minimoLabel = New System.Windows.Forms.Label()
        Id_proveedorLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseBellezaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(12, 119)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(86, 17)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripcion:"
        '
        'Cantidad_stockLabel
        '
        Cantidad_stockLabel.AutoSize = True
        Cantidad_stockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cantidad_stockLabel.Location = New System.Drawing.Point(12, 204)
        Cantidad_stockLabel.Name = "Cantidad_stockLabel"
        Cantidad_stockLabel.Size = New System.Drawing.Size(105, 17)
        Cantidad_stockLabel.TabIndex = 5
        Cantidad_stockLabel.Text = "Cantidad stock:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecioLabel.Location = New System.Drawing.Point(12, 162)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(52, 17)
        PrecioLabel.TabIndex = 7
        PrecioLabel.Text = "Precio:"
        '
        'RubroLabel
        '
        RubroLabel.AutoSize = True
        RubroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RubroLabel.Location = New System.Drawing.Point(12, 246)
        RubroLabel.Name = "RubroLabel"
        RubroLabel.Size = New System.Drawing.Size(51, 17)
        RubroLabel.TabIndex = 9
        RubroLabel.Text = "Rubro:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MarcaLabel.Location = New System.Drawing.Point(250, 246)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(51, 17)
        MarcaLabel.TabIndex = 11
        MarcaLabel.Text = "Marca:"
        '
        'Stock_minimoLabel
        '
        Stock_minimoLabel.AutoSize = True
        Stock_minimoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Stock_minimoLabel.Location = New System.Drawing.Point(250, 204)
        Stock_minimoLabel.Name = "Stock_minimoLabel"
        Stock_minimoLabel.Size = New System.Drawing.Size(95, 17)
        Stock_minimoLabel.TabIndex = 14
        Stock_minimoLabel.Text = "Stock minimo:"
        '
        'Id_proveedorLabel
        '
        Id_proveedorLabel.AutoSize = True
        Id_proveedorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_proveedorLabel.Location = New System.Drawing.Point(12, 76)
        Id_proveedorLabel.Name = "Id_proveedorLabel"
        Id_proveedorLabel.Size = New System.Drawing.Size(92, 17)
        Id_proveedorLabel.TabIndex = 15
        Id_proveedorLabel.Text = "Id proveedor:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(250, 79)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(78, 17)
        NombreLabel.TabIndex = 16
        NombreLabel.Text = "Proveedor:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(120, 119)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(110, 20)
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
        Me.Cantidad_stockTextBox.Location = New System.Drawing.Point(119, 202)
        Me.Cantidad_stockTextBox.Name = "Cantidad_stockTextBox"
        Me.Cantidad_stockTextBox.Size = New System.Drawing.Size(110, 20)
        Me.Cantidad_stockTextBox.TabIndex = 6
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(120, 160)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(110, 20)
        Me.PrecioTextBox.TabIndex = 8
        '
        'RubroTextBox
        '
        Me.RubroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "rubro", True))
        Me.RubroTextBox.Location = New System.Drawing.Point(119, 245)
        Me.RubroTextBox.Name = "RubroTextBox"
        Me.RubroTextBox.Size = New System.Drawing.Size(110, 20)
        Me.RubroTextBox.TabIndex = 10
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(350, 243)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(110, 20)
        Me.MarcaTextBox.TabIndex = 12
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(83, 302)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(97, 36)
        Me.btnagregar.TabIndex = 13
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnfin
        '
        Me.btnfin.Location = New System.Drawing.Point(255, 302)
        Me.btnfin.Name = "btnfin"
        Me.btnfin.Size = New System.Drawing.Size(92, 36)
        Me.btnfin.TabIndex = 14
        Me.btnfin.Text = "Fin"
        Me.btnfin.UseVisualStyleBackColor = True
        '
        'Stock_minimoTextBox
        '
        Me.Stock_minimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArticulosBindingSource, "stock_minimo", True))
        Me.Stock_minimoTextBox.Location = New System.Drawing.Point(350, 201)
        Me.Stock_minimoTextBox.Name = "Stock_minimoTextBox"
        Me.Stock_minimoTextBox.Size = New System.Drawing.Size(110, 20)
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
        Me.TableAdapterManager.Registro_usuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = form1.BaseBellezaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasTableAdapter = Nothing
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
        Me.Id_proveedorComboBox.Location = New System.Drawing.Point(120, 77)
        Me.Id_proveedorComboBox.Name = "Id_proveedorComboBox"
        Me.Id_proveedorComboBox.Size = New System.Drawing.Size(110, 21)
        Me.Id_proveedorComboBox.TabIndex = 16
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(351, 78)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(109, 20)
        Me.NombreTextBox.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Agregar articulo"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(482, 390)
        Me.ShapeContainer1.TabIndex = 19
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 241
        Me.LineShape1.X2 = 242
        Me.LineShape1.Y1 = 68
        Me.LineShape1.Y2 = 287
        '
        'AltaArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 390)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Id_proveedorLabel)
        Me.Controls.Add(Me.Id_proveedorComboBox)
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
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "AltaArticulo"
        Me.Text = "NUEVO ARTICULO"
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseBellezaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedorTableAdapter As form1.BaseBellezaDataSetTableAdapters.proveedorTableAdapter
    Friend WithEvents Id_proveedorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
