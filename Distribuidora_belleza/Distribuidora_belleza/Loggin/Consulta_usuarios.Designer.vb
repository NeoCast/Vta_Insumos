<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_usuarios
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BaseBellezaDataSet = New form1.BaseBellezaDataSet()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New form1.BaseBellezaDataSetTableAdapters.empleadoTableAdapter()
        Me.TableAdapterManager = New form1.BaseBellezaDataSetTableAdapters.TableAdapterManager()
        Me.Registro_usuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_usuarioTableAdapter = New form1.BaseBellezaDataSetTableAdapters.Registro_usuarioTableAdapter()
        Me.Registro_usuarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BaseBellezaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_usuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_usuarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(216, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 7
        '
        'BaseBellezaDataSet
        '
        Me.BaseBellezaDataSet.DataSetName = "BaseBellezaDataSet"
        Me.BaseBellezaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "empleado"
        Me.EmpleadoBindingSource.DataSource = Me.BaseBellezaDataSet
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.articulosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.detalle_vtaTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Me.EmpleadoTableAdapter
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.Registro_usuarioTableAdapter = Me.Registro_usuarioTableAdapter
        Me.TableAdapterManager.UpdateOrder = form1.BaseBellezaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'Registro_usuarioBindingSource
        '
        Me.Registro_usuarioBindingSource.DataMember = "Registro_usuario"
        Me.Registro_usuarioBindingSource.DataSource = Me.BaseBellezaDataSet
        '
        'Registro_usuarioTableAdapter
        '
        Me.Registro_usuarioTableAdapter.ClearBeforeFill = True
        '
        'Registro_usuarioDataGridView
        '
        Me.Registro_usuarioDataGridView.AutoGenerateColumns = False
        Me.Registro_usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Registro_usuarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Registro_usuarioDataGridView.DataSource = Me.Registro_usuarioBindingSource
        Me.Registro_usuarioDataGridView.Location = New System.Drawing.Point(102, 70)
        Me.Registro_usuarioDataGridView.Name = "Registro_usuarioDataGridView"
        Me.Registro_usuarioDataGridView.Size = New System.Drawing.Size(445, 220)
        Me.Registro_usuarioDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "usuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "usuario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "contraseña"
        Me.DataGridViewTextBoxColumn2.HeaderText = "contraseña"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "id_empleado"
        Me.DataGridViewTextBoxColumn4.HeaderText = "id_empleado"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Consulta_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 378)
        Me.Controls.Add(Me.Registro_usuarioDataGridView)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Consulta_usuarios"
        Me.Text = "Consulta_usuarios"
        CType(Me.BaseBellezaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_usuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_usuarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BaseBellezaDataSet As form1.BaseBellezaDataSet
    Friend WithEvents EmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadoTableAdapter As form1.BaseBellezaDataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents TableAdapterManager As form1.BaseBellezaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Registro_usuarioTableAdapter As form1.BaseBellezaDataSetTableAdapters.Registro_usuarioTableAdapter
    Friend WithEvents Registro_usuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Registro_usuarioDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
