Public Class Theme

    Public Shared Function GetFont() As Font
        ' TODO: If the user has a preferred font, send that
        Return GetStandardFont()
    End Function

    Private Shared Function GetStandardFont() As Font
        Return New Font("Segoe UI", 12.0F, FontStyle.Regular)
    End Function

    Public Shared Function GetPalette() As Palette
        ' TODO: If the user has a preferred palette, send that
        Return GetStandardPalette()
    End Function


    Private Shared Function GetStandardPalette() As Palette
        Return New Palette(Color.Gainsboro, Color.Silver, Color.DimGray, Color.Snow)
    End Function

End Class