Public Class ClsCategoriaDTO
    Private idCategoria As Integer
    Private descripcion As String

    Public Sub New()

    End Sub
    Public Sub New(descripcion As String)
        Me.descripcion = descripcion
    End Sub

    Public Property _IdCategoria As Integer
        Get
            Return Me.idCategoria
        End Get
        Set(value As Integer)
            Me.idCategoria = value
        End Set
    End Property
    Public Property _Descripcion As String
        Get
            Return Me.descripcion
        End Get
        Set(value As String)
            Me.descripcion = value
        End Set
    End Property
End Class
