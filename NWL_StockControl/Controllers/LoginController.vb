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

            oModel = (From it In oDB.TMstMUser Where it.XVUsrCode = poModel.XVUsrCode Select it).FirstOrDefault
            If oModel.XVUsrPwd = poModel.XVUsrPwd Then
                Return RedirectToAction("Index")
            Else
                Return RedirectToAction("Index")
            End If
        End Function
    End Class
End Namespace