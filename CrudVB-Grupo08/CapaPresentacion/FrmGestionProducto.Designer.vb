<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dtgProductos = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New FontAwesome.Sharp.IconButton()
        Me.btnActualizar = New FontAwesome.Sharp.IconButton()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.btnBuscar = New FontAwesome.Sharp.IconButton()
        Me.btnNuevo = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.nupPrecio = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.nupStock = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dtgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgProductos
        '
        Me.dtgProductos.AllowUserToAddRows = False
        Me.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgProductos.Location = New System.Drawing.Point(12, 214)
        Me.dtgProductos.Name = "dtgProductos"
        Me.dtgProductos.Size = New System.Drawing.Size(511, 120)
        Me.dtgProductos.TabIndex = 9
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.btnEliminar.IconColor = System.Drawing.Color.Black
        Me.btnEliminar.IconSize = 16
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnEliminar.Location = New System.Drawing.Point(436, 170)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Rotation = 0R
        Me.btnEliminar.Size = New System.Drawing.Size(87, 25)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnActualizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnActualizar.IconColor = System.Drawing.Color.Black
        Me.btnActualizar.IconSize = 16
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnActualizar.Location = New System.Drawing.Point(436, 139)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Rotation = 0R
        Me.btnActualizar.Size = New System.Drawing.Size(87, 25)
        Me.btnActualizar.TabIndex = 5
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGuardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnGuardar.IconColor = System.Drawing.Color.Black
        Me.btnGuardar.IconSize = 16
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnGuardar.Location = New System.Drawing.Point(436, 108)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Rotation = 0R
        Me.btnGuardar.Size = New System.Drawing.Size(87, 25)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnBuscar.IconColor = System.Drawing.Color.Black
        Me.btnBuscar.IconSize = 16
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnBuscar.Location = New System.Drawing.Point(436, 77)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Rotation = 0R
        Me.btnBuscar.Size = New System.Drawing.Size(87, 25)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnNuevo.IconColor = System.Drawing.Color.Black
        Me.btnNuevo.IconSize = 16
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnNuevo.Location = New System.Drawing.Point(436, 46)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Rotation = 0R
        Me.btnNuevo.Size = New System.Drawing.Size(87, 25)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(108, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gestion de Productos"
        '
        'cbCategoria
        '
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(12, 175)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(162, 21)
        Me.cbCategoria.TabIndex = 10
        '
        'nupPrecio
        '
        Me.nupPrecio.DecimalPlaces = 1
        Me.nupPrecio.Location = New System.Drawing.Point(207, 112)
        Me.nupPrecio.Name = "nupPrecio"
        Me.nupPrecio.Size = New System.Drawing.Size(149, 20)
        Me.nupPrecio.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Categoria:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 112)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(162, 20)
        Me.txtDescripcion.TabIndex = 13
        '
        'nupStock
        '
        Me.nupStock.Location = New System.Drawing.Point(207, 175)
        Me.nupStock.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nupStock.Name = "nupStock"
        Me.nupStock.Size = New System.Drawing.Size(149, 20)
        Me.nupStock.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(207, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Precio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(207, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Stock:"
        '
        'FrmGestionProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(535, 349)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nupStock)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nupPrecio)
        Me.Controls.Add(Me.cbCategoria)
        Me.Controls.Add(Me.dtgProductos)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FrmGestionProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgProductos As DataGridView
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnActualizar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cbCategoria As ComboBox
    Friend WithEvents nupPrecio As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents nupStock As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
