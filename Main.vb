Imports NLog
Imports NLog.LogManager

Public Class Main

    Public Shared logger As Logger

    Public Sub New()
        InitializeComponent()
        logger = GetCurrentClassLogger()
    End Sub

End Class