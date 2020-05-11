Imports CapaNegocio
Public Class FrmGestionProducto

    Dim objProductoCn As New ClsProductoCN
    Private Sub FrmGestionProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarProductos()
    End Sub
    Sub mostrarProductos()
        dtgProductos.DataSource = objProductoCn.listaDeProductos
    End Sub
End Class