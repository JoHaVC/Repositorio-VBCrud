Imports CapaDatos
Public Class ClsProductoCN
    Dim objProductoDTO As ClsProductoDTO
    Dim objProductoDAO As ClsProductoDAO
    Sub New()
        objProductoDTO = New ClsProductoDTO
        objProductoDAO = New ClsProductoDAO
    End Sub

    Sub guardarProducto(desc As String, prec As Single, st As Integer,
                        idCat As Integer)
        objProductoDTO._Descripcion = desc
        objProductoDTO._Precio = prec
        objProductoDTO._Stock = st
        objProductoDTO._IdCategoria = idCat

        objProductoDAO.InsertarProducto(objProductoDTO)

    End Sub

    Function listaDeProductos() As DataTable
        Return objProductoDAO.listaProductos
    End Function
End Class
