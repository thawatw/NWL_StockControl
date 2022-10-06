Public Class TMnyMUserMenuWithMenuName
    Inherits TMnyMUserMenu
    Private tC_XVMnuName As String
    Public Property XVMnuName() As String
        Get
            Return tC_XVMnuName
        End Get
        Set(ByVal value As String)
            tC_XVMnuName = value
        End Set
    End Property
End Class
