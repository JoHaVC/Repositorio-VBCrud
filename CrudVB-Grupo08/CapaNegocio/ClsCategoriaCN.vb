Imports CapaDatos
Public Class ClsCategoriaCN
    Dim objCategoriaDTO As ClsCategoriaDTO
    Dim objCategoriaDAO As ClsCategoriaDAO

    Sub New()
        objCategoriaDTO = New ClsCategoriaDTO
        objCategoriaDAO = New ClsCategoriaDAO
    End Sub

    Function listaDeCategorias() As DataTable
        Return objCategoriaDAO.listaCategorias
    End Function
End Class
