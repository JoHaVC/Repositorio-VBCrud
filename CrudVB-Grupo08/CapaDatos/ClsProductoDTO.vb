Public Class ClsProductoDTO
    Private idProducto As Integer
    Private descripcion As String
    Private precio As Single
    Private stock As Integer
    Private idCategoria As Integer

    Public Sub New()

    End Sub
    Public Sub New(descripcion As String, precio As Single, stock As Integer, idCategoria As Integer)
        Me.descripcion = descripcion
        Me.precio = precio
        Me.stock = stock
        Me.idCategoria = idCategoria
    End Sub

    Public Property _IdProducto As Integer
        Get
            Return Me.idProducto
        End Get
        Set(value As Integer)
            Me.idProducto = value
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

    Public Property _Precio As Single
        Get
            Return Me.precio
        End Get
        Set(value As Single)
            Me.precio = value
        End Set
    End Property
    Public Property _Stock As Integer
        Get
            Return Me.stock
        End Get
        Set(value As Integer)
            Me.stock = value
        End Set
    End Property

    Public Property _IdCategoria As Integer
        Get
            Return Me.idCategoria
        End Get
        Set(value As Integer)
            Me.idCategoria = value
        End Set
    End Property
End Class
