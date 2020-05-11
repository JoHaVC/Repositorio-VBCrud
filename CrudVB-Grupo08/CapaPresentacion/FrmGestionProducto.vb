Imports CapaNegocio
Public Class FrmGestionProducto

    Dim objProductoCn As New ClsProductoCN
    Dim objCategoriaCn As New ClsCategoriaCN
    Dim idProducto As Integer = 0
    Private Sub FrmGestionProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarProductos()
        mostrarCategorias()
        controlesInicio()
    End Sub

    Sub controlesInicio()
        cbCategoria.Enabled = False
        nupPrecio.Enabled = False
        nupStock.Enabled = False
        btnGuardar.Enabled = False
        btnActualizar.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Sub mostrarProductos()
        dtgProductos.DataSource = objProductoCn.listaDeProductos
    End Sub

    Sub mostrarCategorias()
        cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        cbCategoria.ValueMember = "idCategoria"
        cbCategoria.DisplayMember = "descripcion"
        cbCategoria.DataSource = objCategoriaCn.listaDeCategorias
    End Sub

    Sub guardarDatos()
        objProductoCn.guardarProducto(
            txtDescripcion.Text,
            Convert.ToDecimal(nupPrecio.Value),
            Convert.ToInt32(nupStock.Value),
            Convert.ToInt32(cbCategoria.SelectedValue))
        MessageBox.Show("Producto Guardado Correctamente!!!")
    End Sub
    Sub actualizarDatos()
        objProductoCn.modificarProducto(
            idProducto,
            txtDescripcion.Text,
            Convert.ToDecimal(nupPrecio.Value),
            Convert.ToInt32(nupStock.Value),
            Convert.ToInt32(cbCategoria.SelectedValue))
        MessageBox.Show("Producto Actualizado Correctamente!!!")
    End Sub

    Sub eliminarDatos()
        objProductoCn.eliminarProducto(
            idProducto)
        MessageBox.Show("Producto Eliminado Correctamente!!!")
    End Sub

    Sub limpiarControles()
        txtDescripcion.Text = ""
        nupPrecio.Value = 0.0
        nupStock.Value = 0
        cbCategoria.SelectedIndex = 0
    End Sub
    Sub habilitarControles()
        txtDescripcion.Enabled = True
        nupPrecio.Enabled = True
        nupStock.Enabled = True
        cbCategoria.Enabled = True
        btnActualizar.Enabled = True
        btnEliminar.Enabled = True
    End Sub
    Sub inhabilitarControles()
        txtDescripcion.Enabled = True
        nupPrecio.Enabled = False
        nupStock.Enabled = False
        cbCategoria.Enabled = False
        btnActualizar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Sub nuevoRegistro()
        txtDescripcion.Text = ""
        nupPrecio.Value = 0.0
        nupStock.Value = 0
        cbCategoria.SelectedIndex = 0

        txtDescripcion.Enabled = True
        nupPrecio.Enabled = True
        nupStock.Enabled = True
        cbCategoria.Enabled = True
        btnGuardar.Enabled = True
        btnActualizar.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Sub buscarDatos()
        Dim datos() As String = objProductoCn.buscarProducto(txtDescripcion.Text)
        If datos(0) = 0 Then
            MessageBox.Show("La informacion no existe en el sistema !!!")
            txtDescripcion.Text = ""
        Else
            idProducto = Convert.ToInt32(datos(0))
            txtDescripcion.Text = datos(1)
            nupPrecio.Value = Convert.ToSingle(datos(2))
            nupStock.Value = Convert.ToSingle(datos(3))
            cbCategoria.SelectedValue = Convert.ToInt32(datos(4))
            btnGuardar.Enabled = False
            MessageBox.Show("Busqueda Correcta !!!")
            habilitarControles()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        guardarDatos()
        mostrarProductos()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtDescripcion.Text = "" Then
            MessageBox.Show("Campo Vacio  Verifique !!!")
        Else
            buscarDatos()
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        actualizarDatos()
        mostrarProductos()
        limpiarControles()
        inhabilitarControles()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarDatos()
        mostrarProductos()
        limpiarControles()
        inhabilitarControles()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        nuevoRegistro()
    End Sub
End Class