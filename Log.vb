Imports NLog
Imports NLog.LogManager

Public Class Log

    Public Shared logger As Logger

    Public Sub New()
        logger = GetCurrentClassLogger()
    End Sub

End Class