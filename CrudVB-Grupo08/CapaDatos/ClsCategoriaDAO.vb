Imports System.Data
Imports System.Data.SqlClient
Public Class ClsCategoriaDAO
    Dim con As ClsConexion
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim par As SqlParameter
    Dim dt As DataTable
    Public Sub New()
        con = New ClsConexion()
    End Sub
    Function listaCategorias() As DataTable
        cmd = New SqlCommand("SP_ListaCategorias", con.cn)
        cmd.CommandType = CommandType.StoredProcedure
        da = New SqlDataAdapter(cmd)
        dt = New DataTable()
        da.Fill(dt)

        Return dt
    End Function
End Class
