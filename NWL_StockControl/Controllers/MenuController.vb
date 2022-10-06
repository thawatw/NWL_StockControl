Imports System.Data.Entity.Infrastructure
Imports System.Web.Mvc

Namespace Controllers
    Public Class MenuController
        Inherits Controller

        ' GET: Menu
        Function Index() As ActionResult
            Dim tUsrCode As String = TempData("MyData")
            Dim oListModel As List(Of TMnyMUserMenuWithMenuName)
            Dim oDB As New StockControlEntities
            'oListModel = (From it In oDB.TMnyMUserMenu Where it.XVUsrCode = tUsrCode Select it).ToList
            oListModel = (From it In oDB.Database.SqlQuery(Of TMnyMUserMenuWithMenuName) _
                              ("SELECT A.XVUsrCode,A.XVMnuCode,B.XVMnuName,A.XBUmnIsRead 
                                ,A.XBUmnIsSave,A.XBUmnIsDelete,A.XBUmnIsCancel,A.XBUmnIsApprove
                              FROM TMnyMUserMenu A
                                INNER JOIN TMstMMenu B ON A.XVMnuCode=B.XVMnuCode")
                          Where it.XVUsrCode = tUsrCode
                          Select New TMnyMUserMenuWithMenuName _
                                 With {.XVUsrCode = it.XVUsrCode _
                                        , .XVMnuCode = it.XVMnuCode _
                                        , .XVMnuName = it.XVMnuName _
                                        , .XBUmnIsRead = it.XBUmnIsRead _
                                        , .XBUmnIsSave = it.XBUmnIsSave _
                                        , .XBUmnIsDelete = it.XBUmnIsDelete _
                                        , .XBUmnIsCancel = it.XBUmnIsCancel _
                                        , .XBUmnIsApprove = it.XBUmnIsApprove}).ToList
            Return View(oListModel)
        End Function
    End Class
End Namespace