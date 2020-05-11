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

    Sub modificarProducto(id As Integer, desc As String, prec As Single, st As Integer,
                        idCat As Integer)
        objProductoDTO._IdProducto = id
        objProductoDTO._Descripcion = desc
        objProductoDTO._Precio = prec
        objProductoDTO._Stock = st
        objProductoDTO._IdCategoria = idCat

        objProductoDAO.ActualizarProducto(objProductoDTO)

    End Sub

    Sub eliminarProducto(id As Integer)
        objProductoDTO._IdProducto = id
        objProductoDAO.EliminarProducto(objProductoDTO)
    End Sub

    Function listaDeProductos() As DataTable
        Return objProductoDAO.listaProductos
    End Function

    Function buscarProducto(descripcion) As String()
        Dim detallePro(4) As String
        objProductoDTO._Descripcion = descripcion
        objProductoDAO.buscarProducto(objProductoDTO)
        detallePro(0) = objProductoDTO._IdProducto
        detallePro(1) = objProductoDTO._Descripcion
        detallePro(2) = objProductoDTO._Precio
        detallePro(3) = objProductoDTO._Stock
        detallePro(4) = objProductoDTO._IdCategoria

        Return detallePro
    End Function
End Class
