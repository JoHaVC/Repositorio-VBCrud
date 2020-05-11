Imports System.Data
Imports System.Data.SqlClient
Public Class ClsProductoDAO
    Dim con As ClsConexion
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
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
    Sub InsertarProducto(pro As ClsProductoDTO)
        cmd = New SqlCommand("SP_InsertarProducto", con.cn)
        cmd.CommandType = CommandType.StoredProcedure
        par = New SqlParameter("@descripcion", SqlDbType.VarChar, 50)
        par.Value = pro._Descripcion
        cmd.Parameters.Add(par)

        par = New SqlParameter("@precio", SqlDbType.Float)
        par.Value = pro._Descripcion
        cmd.Parameters.Add(par)


        par = New SqlParameter("@stock", SqlDbType.Int)
        par.Value = pro._Precio
        cmd.Parameters.Add(par)

        par = New SqlParameter("@idCategoria", SqlDbType.Int)
        par.Value = pro._IdCategoria
        cmd.Parameters.Add(par)

        If con.cn.State = ConnectionState.Closed Then
            con.cn.Open()
        End If

        cmd.ExecuteNonQuery()

    End Sub
End Class
