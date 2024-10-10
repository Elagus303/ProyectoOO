Public Class RenderPersonalizadoMenuStrip
    'Heredar de clase
    Inherits ToolStripProfessionalRenderer

    'Sobreescribir procedimiento protegido
    Protected Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)
        If e.Item.Selected Then
            ' Cambiar el color de fondo cuando el elemento está seleccionado
            Dim selectedColor As Color = Color.DimGray ' Elige el color que prefieras
            Using brush As New SolidBrush(selectedColor)
                e.Graphics.FillRectangle(brush, e.Item.ContentRectangle)
            End Using
        Else
            ' Dibujar el fondo normal cuando no está seleccionado
            MyBase.OnRenderMenuItemBackground(e)
        End If
    End Sub
End Class
