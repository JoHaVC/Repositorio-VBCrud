Imports System.Data
Imports System.Data.SqlClient
Public Class ClsProductoDAO
    Dim con As ClsConexion
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim par As SqlParameter
    Dim dt As DataTable
    Public Sub New()
        con = New ClsConexion()
    End Sub

    Function listaProductos() As DataTable
        cmd = New SqlCommand("SP_ListaProductos", con.cn)
        cmd.CommandType = CommandType.StoredProcedure
        da = New SqlDataAdapter(cmd)
        dt = New DataTable()
        da.Fill(dt)

        Return dt
    End Function
    Sub buscarProducto(pro As ClsProductoDTO)
        cmd = New SqlCommand("SP_BuscarProducto", con.cn)
        cmd.CommandType = CommandType.StoredProcedure
        par = New SqlParameter("@descripcion", SqlDbType.VarChar, 50)
        par.Value = pro._Descripcion
        cmd.Parameters.Add(par)

        If con.cn.State = ConnectionState.Closed Then
            con.cn.Open()
        End If

        dr = cmd.ExecuteReader()

        If dr.Read = True Then
            pro._IdProducto = Convert.ToInt32(dr("idProducto"))
            pro._Descripcion = dr("descripcion").ToString()
            pro._Precio = Convert.ToSingle(dr("precio"))
            pro._Stock = Convert.ToInt32(dr("stock"))
            pro._IdCategoria = Convert.ToInt32(dr("idCategoria"))
        End If

        dr.Close()
        con.cn.Close()
    End Sub
    Sub InsertarProducto(pro As ClsProductoDTO)
        cmd = New SqlCommand("SP_InsertarProducto", con.cn)
        cmd.CommandType = CommandType.StoredProcedure
        par = New SqlParameter("@descripcion", SqlDbType.VarChar, 50)
        par.Value = pro._Descripcion
        cmd.Parameters.Add(par)

        par = New SqlParameter("@precio", SqlDbType.Float)
        par.Value = pro._Precio
        cmd.Parameters.Add(par)


        par = New SqlParameter("@stock", SqlDbType.Int)
        par.Value = pro._Stock
        cmd.Parameters.Add(par)

        par = New SqlParameter("@idCategoria", SqlDbType.Int)
        par.Value = pro._IdCategoria
        cmd.Parameters.Add(par)

        If con.cn.State = ConnectionState.Closed Then
            con.cn.Open()
        End If

        cmd.ExecuteNonQuery()

    End Sub

    Sub ActualizarProducto(pro As ClsProductoDTO)
        cmd = New SqlCommand("SP_ActualizarProducto", con.cn)
        cmd.CommandType = CommandType.StoredProcedure
        par = New SqlParameter("@idProducto", SqlDbType.Int)
        par.Value = pro._IdProducto
        cmd.Parameters.Add(par)

        par = New SqlParameter("@descripcion", SqlDbType.VarChar, 50)
        par.Value = pro._Descripcion
        cmd.Parameters.Add(par)

        par = New SqlParameter("@precio", SqlDbType.Float)
        par.Value = pro._Precio
        cmd.Parameters.Add(par)


        par = New SqlParameter("@stock", SqlDbType.Int)
        par.Value = pro._Stock
        cmd.Parameters.Add(par)

        par = New SqlParameter("@idCategoria", SqlDbType.Int)
        par.Value = pro._IdCategoria
        cmd.Parameters.Add(par)

        If con.cn.State = ConnectionState.Closed Then
            con.cn.Open()
        End If

        cmd.ExecuteNonQuery()

    End Sub

    Sub EliminarProducto(pro As ClsProductoDTO)
        cmd = New SqlCommand("SP_EliminarProducto", con.cn)
        cmd.CommandType = CommandType.StoredProcedure
        par = New SqlParameter("@idProducto", SqlDbType.Int)
        par.Value = pro._IdProducto
        cmd.Parameters.Add(par)

        If con.cn.State = ConnectionState.Closed Then
            con.cn.Open()
        End If

        cmd.ExecuteNonQuery()

    End Sub

End Class
