
Public Class SystemSupportMail
    Inherits MasterEmailServer
    Public Sub New()
        senderMail = "ezuarudo@gmail.com"
        password = "shadowlugia20"
        host = "smtp.gmail.com"
        port = 587
        ssl = True
        initializeSmptClient()
    End Sub
    Public Sub Notifications()

    End Sub
    Public Sub Errors()

    End Sub
End Class
