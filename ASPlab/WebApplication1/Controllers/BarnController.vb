Imports System.Web.Mvc

Namespace Controllers
    Public Class BarnController
        Inherits Controller

        ' GET: Barn
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace