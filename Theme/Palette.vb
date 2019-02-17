Public Class Palette

    Public primary As Color = Color.Gainsboro
    Public secondary As Color = Color.Silver
    Public accent As Color = Color.DimGray
    Public highlight As Color = Color.Snow

    Public Sub New(primary As Color, secondary As Color, accent As Color, highlight As Color)
        Me.primary = primary
        Me.secondary = secondary
        Me.accent = accent
        Me.highlight = highlight
    End Sub

End Class