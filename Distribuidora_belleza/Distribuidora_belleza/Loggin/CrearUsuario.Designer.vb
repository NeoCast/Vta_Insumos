<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearUsuario
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
        '<<<<<<< Updated upstream
        '        Me.components = New System.ComponentModel.Container()
        '        Dim UsuarioLabel As System.Windows.Forms.Label
        '        Dim ContraseñaLabel As System.Windows.Forms.Label
        '        Dim TipoLabel As System.Windows.Forms.Label
        '        Dim Id_empleadoLabel As System.Windows.Forms.Label
        '        Dim NombreLabel As System.Windows.Forms.Label
        '        Me.BaseBellezaDataSet = New form1.BaseBellezaDataSet()
        '        Me.Registro_usuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '        Me.Registro_usuarioTableAdapter = New form1.BaseBellezaDataSetTableAdapters.Registro_usuarioTableAdapter()
        '        Me.TableAdapterManager = New form1.BaseBellezaDataSetTableAdapters.TableAdapterManager()
        '        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        '        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        '        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        '        Me.Button1 = New System.Windows.Forms.Button()
        '        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '        Me.EmpleadoTableAdapter = New form1.BaseBellezaDataSetTableAdapters.empleadoTableAdapter()
        '        Me.Id_empleadoComboBox = New System.Windows.Forms.ComboBox()
        '        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        '        UsuarioLabel = New System.Windows.Forms.Label()
        '        ContraseñaLabel = New System.Windows.Forms.Label()
        '        TipoLabel = New System.Windows.Forms.Label()
        '        Id_empleadoLabel = New System.Windows.Forms.Label()
        '        NombreLabel = New System.Windows.Forms.Label()
        '        CType(Me.BaseBellezaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        '        CType(Me.Registro_usuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        '        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        '        Me.SuspendLayout()
        '        '
        '        'UsuarioLabel
        '        '
        '        UsuarioLabel.AutoSize = True
        '        UsuarioLabel.Location = New System.Drawing.Point(82, 32)
        '        UsuarioLabel.Name = "UsuarioLabel"
        '        UsuarioLabel.Size = New System.Drawing.Size(44, 13)
        '        UsuarioLabel.TabIndex = 1
        '        UsuarioLabel.Text = "usuario:"
        '        '
        '        'ContraseñaLabel
        '        '
        '        ContraseñaLabel.AutoSize = True
        '        ContraseñaLabel.Location = New System.Drawing.Point(82, 70)
        '        ContraseñaLabel.Name = "ContraseñaLabel"
        '        ContraseñaLabel.Size = New System.Drawing.Size(63, 13)
        '        ContraseñaLabel.TabIndex = 3
        '        ContraseñaLabel.Text = "contraseña:"
        '        '
        '        'TipoLabel
        '        '
        '        TipoLabel.AutoSize = True
        '        TipoLabel.Location = New System.Drawing.Point(82, 113)
        '        TipoLabel.Name = "TipoLabel"
        '        TipoLabel.Size = New System.Drawing.Size(27, 13)
        '        TipoLabel.TabIndex = 5
        '        TipoLabel.Text = "tipo:"
        '        '
        '        'Id_empleadoLabel
        '        '
        '        Id_empleadoLabel.AutoSize = True
        '        Id_empleadoLabel.Location = New System.Drawing.Point(34, 164)
        '        Id_empleadoLabel.Name = "Id_empleadoLabel"
        '        Id_empleadoLabel.Size = New System.Drawing.Size(67, 13)
        '        Id_empleadoLabel.TabIndex = 7
        '        Id_empleadoLabel.Text = "id empleado:"
        '        '
        '        'NombreLabel
        '        '
        '        NombreLabel.AutoSize = True
        '        NombreLabel.Location = New System.Drawing.Point(167, 164)
        '        NombreLabel.Name = "NombreLabel"
        '        NombreLabel.Size = New System.Drawing.Size(45, 13)
        '        NombreLabel.TabIndex = 9
        '        NombreLabel.Text = "nombre:"
        '        '
        '        'BaseBellezaDataSet
        '        '
        '        Me.BaseBellezaDataSet.DataSetName = "BaseBellezaDataSet"
        '        Me.BaseBellezaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '        '
        '        'Registro_usuarioBindingSource
        '        '
        '        Me.Registro_usuarioBindingSource.DataMember = "Registro_usuario"
        '        Me.Registro_usuarioBindingSource.DataSource = Me.BaseBellezaDataSet
        '        '
        '        'Registro_usuarioTableAdapter
        '        '
        '        Me.Registro_usuarioTableAdapter.ClearBeforeFill = True
        '        '
        '        'TableAdapterManager
        '        '
        '        Me.TableAdapterManager.articulosTableAdapter = Nothing
        '        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        '        Me.TableAdapterManager.clienteTableAdapter = Nothing
        '        Me.TableAdapterManager.detalle_vtaTableAdapter = Nothing
        '        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        '        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        '        Me.TableAdapterManager.Registro_usuarioTableAdapter = Me.Registro_usuarioTableAdapter
        '        Me.TableAdapterManager.UpdateOrder = form1.BaseBellezaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '        '
        '        'UsuarioTextBox
        '        '
        '        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registro_usuarioBindingSource, "usuario", True))
        '        Me.UsuarioTextBox.Location = New System.Drawing.Point(163, 29)
        '        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        '        Me.UsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        '        Me.UsuarioTextBox.TabIndex = 2
        '        '
        '        'ContraseñaTextBox
        '        '
        '        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registro_usuarioBindingSource, "contraseña", True))
        '        Me.ContraseñaTextBox.Location = New System.Drawing.Point(163, 67)
        '        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        '        Me.ContraseñaTextBox.Size = New System.Drawing.Size(100, 20)
        '        Me.ContraseñaTextBox.TabIndex = 4
        '        '
        '        'ComboBox1
        '        '
        '        Me.ComboBox1.FormattingEnabled = True
        '        Me.ComboBox1.Items.AddRange(New Object() {"cajero", "admin"})
        '        Me.ComboBox1.Location = New System.Drawing.Point(163, 110)
        '        Me.ComboBox1.Name = "ComboBox1"
        '        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        '        Me.ComboBox1.TabIndex = 6
        '        '
        '        'Button1
        '        '
        '        Me.Button1.Location = New System.Drawing.Point(153, 217)
        '        Me.Button1.Name = "Button1"
        '        Me.Button1.Size = New System.Drawing.Size(82, 47)
        '        Me.Button1.TabIndex = 7
        '        Me.Button1.Text = "Agregar"
        '        Me.Button1.UseVisualStyleBackColor = True
        '        '
        '        'EmpleadoBindingSource
        '        '
        '        Me.EmpleadoBindingSource.DataMember = "empleado"
        '        Me.EmpleadoBindingSource.DataSource = Me.BaseBellezaDataSet
        '        '
        '        'EmpleadoTableAdapter
        '        '
        '        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '        '
        '        'Id_empleadoComboBox
        '        '
        '        Me.Id_empleadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "id_empleado", True))
        '        Me.Id_empleadoComboBox.DataSource = Me.EmpleadoBindingSource
        '        Me.Id_empleadoComboBox.DisplayMember = "id_empleado"
        '        Me.Id_empleadoComboBox.FormattingEnabled = True
        '        Me.Id_empleadoComboBox.Location = New System.Drawing.Point(107, 161)
        '        Me.Id_empleadoComboBox.Name = "Id_empleadoComboBox"
        '        Me.Id_empleadoComboBox.Size = New System.Drawing.Size(45, 21)
        '        Me.Id_empleadoComboBox.TabIndex = 8
        '        Me.Id_empleadoComboBox.ValueMember = "id_empleado"
        '        '
        '        'NombreTextBox
        '        '
        '        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "nombre", True))
        '        Me.NombreTextBox.Location = New System.Drawing.Point(218, 161)
        '        Me.NombreTextBox.Name = "NombreTextBox"
        '        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        '        Me.NombreTextBox.TabIndex = 10
        '        '
        '        'CrearUsuario
        '        '
        '        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        '        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        '        Me.ClientSize = New System.Drawing.Size(376, 322)
        '        Me.Controls.Add(NombreLabel)
        '        Me.Controls.Add(Me.NombreTextBox)
        '        Me.Controls.Add(Id_empleadoLabel)
        '        Me.Controls.Add(Me.Id_empleadoComboBox)
        '        Me.Controls.Add(Me.Button1)
        '        Me.Controls.Add(Me.ComboBox1)
        '        Me.Controls.Add(UsuarioLabel)
        '        Me.Controls.Add(Me.UsuarioTextBox)
        '        Me.Controls.Add(ContraseñaLabel)
        '        Me.Controls.Add(Me.ContraseñaTextBox)
        '        Me.Controls.Add(TipoLabel)
        '        Me.Name = "CrearUsuario"
        '        Me.Text = "CrearUsuario"
        '        CType(Me.BaseBellezaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        '        CType(Me.Registro_usuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        '        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        '        Me.ResumeLayout(False)
        '        Me.PerformLayout()


        Me.components = New System.ComponentModel.Container()
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim Id_empleadoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Me.BaseBellezaDataSet = New form1.BaseBellezaDataSet()
        Me.Registro_usuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Registro_usuarioTableAdapter = New form1.BaseBellezaDataSetTableAdapters.Registro_usuarioTableAdapter()
        Me.TableAdapterManager = New form1.BaseBellezaDataSetTableAdapters.TableAdapterManager()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadoTableAdapter = New form1.BaseBellezaDataSetTableAdapters.empleadoTableAdapter()
        Me.Id_empleadoComboBox = New System.Windows.Forms.ComboBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        UsuarioLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        Id_empleadoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CType(Me.BaseBellezaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Registro_usuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuarioLabel.Location = New System.Drawing.Point(23, 26)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(61, 17)
        UsuarioLabel.TabIndex = 1
        UsuarioLabel.Text = "Usuario:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContraseñaLabel.Location = New System.Drawing.Point(23, 66)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(85, 17)
        ContraseñaLabel.TabIndex = 3
        ContraseñaLabel.Text = "Contraseña:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(23, 109)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(40, 17)
        TipoLabel.TabIndex = 5
        TipoLabel.Text = "Tipo:"
        '
        'Id_empleadoLabel
        '
        Id_empleadoLabel.AutoSize = True
        Id_empleadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_empleadoLabel.Location = New System.Drawing.Point(23, 155)
        Id_empleadoLabel.Name = "Id_empleadoLabel"
        Id_empleadoLabel.Size = New System.Drawing.Size(91, 17)
        Id_empleadoLabel.TabIndex = 7
        Id_empleadoLabel.Text = "ID empleado:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(23, 201)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 9
        NombreLabel.Text = "Nombre:"
        '
        'BaseBellezaDataSet
        '
        Me.BaseBellezaDataSet.DataSetName = "BaseBellezaDataSet"
        Me.BaseBellezaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.articulosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.detalle_vtaTableAdapter = Nothing
        Me.TableAdapterManager.empleadoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.Registro_usuarioTableAdapter = Me.Registro_usuarioTableAdapter
        Me.TableAdapterManager.UpdateOrder = form1.BaseBellezaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registro_usuarioBindingSource, "usuario", True))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(139, 23)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsuarioTextBox.TabIndex = 2
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Registro_usuarioBindingSource, "contraseña", True))
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(139, 63)
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContraseñaTextBox.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(139, 106)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(108, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 47)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
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
        'Id_empleadoComboBox
        '
        Me.Id_empleadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "id_empleado", True))
        Me.Id_empleadoComboBox.FormattingEnabled = True
        Me.Id_empleadoComboBox.Location = New System.Drawing.Point(139, 151)
        Me.Id_empleadoComboBox.Name = "Id_empleadoComboBox"
        Me.Id_empleadoComboBox.Size = New System.Drawing.Size(100, 21)
        Me.Id_empleadoComboBox.TabIndex = 8
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadoBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(139, 200)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 10
        '
        'CrearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 319)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Id_empleadoLabel)
        Me.Controls.Add(Me.Id_empleadoComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(Me.ContraseñaTextBox)
        Me.Controls.Add(TipoLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CrearUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrearUsuario"
        CType(Me.BaseBellezaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Registro_usuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BaseBellezaDataSet As form1.BaseBellezaDataSet
    Friend WithEvents Registro_usuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Registro_usuarioTableAdapter As form1.BaseBellezaDataSetTableAdapters.Registro_usuarioTableAdapter
    Friend WithEvents TableAdapterManager As form1.BaseBellezaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContraseñaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents EmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadoTableAdapter As form1.BaseBellezaDataSetTableAdapters.empleadoTableAdapter
    Friend WithEvents Id_empleadoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
End Class
