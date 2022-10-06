Imports System.Web.Mvc

Namespace Controllers
    Public Class LoginController
        Inherits Controller

        ' GET: Login
        Function Index() As ActionResult

            Return View()
        End Function

        Function LoginCheck(ByVal poModel As TMstMUser) As ActionResult
            Dim oDB As New StockControlEntities
            Dim oModel As TMstMUser
            'Dim oListUserMenu As List(Of TMnyMUserMenu)

            oModel = (From it In oDB.TMstMUser Where it.XVUsrCode = poModel.XVUsrCode Select it).FirstOrDefault
            If oModel IsNot Nothing Then
                If oModel.XVUsrPwd = poModel.XVUsrPwd Then
                    'oListUserMenu = (From it In oDB.TMnyMUserMenu Where it.XVUsrCode = oModel.XVUsrCode Select it).ToList
                    'If oListUserMenu IsNot Nothing AndAlso oListUserMenu.Count > 0 Then
                    '    Return RedirectToAction("Index", "Menu", oListUserMenu)
                    'Else
                    '    Return RedirectToAction("Index")
                    'End If
                    'Return RedirectToAction("Index", "Menu", New RouteValueDictionary(New { controller = "", action = "Main", Id = Id } ) )
                    TempData("MyData") = oModel.XVUsrCode
                    Return RedirectToAction("Index", "Menu")
                Else
                    Return RedirectToAction("Index")
                End If
            Else
                Return RedirectToAction("Index")
            End If

        End Function
    End Class
End Namespace