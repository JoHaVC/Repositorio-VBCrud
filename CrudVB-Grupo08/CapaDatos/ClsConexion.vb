Imports System.Data.SqlClient
Imports System.Configuration
Public Class ClsConexion
    Private Con As SqlConnection
    Public Sub New()
        Con = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conexionBD").ConnectionString)
    End Sub

    Public Property _Con As SqlConnection
        Get
            Return Con
        End Get
        Set(value As SqlConnection)
            Con = value
        End Set
    End Property

    Function cn() As SqlConnection
        Return _Con
    End Function
End Class
