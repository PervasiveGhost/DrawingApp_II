Public Class PBox
    Public Property Picture As Image
    Public Property w As Integer
    Public Property h As Integer

    Public Property Sides As Integer
    Public Property Radius As Integer
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point
    Public Sub New(i As Image, a As Point, b As Point)
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        Dim Points(Sides - 1) As Point

        For index = 0 To Sides - 1
            Dim X As Integer
            Dim Y As Integer

            X = Math.Cos(index * 2 * Math.PI / Sides) * Radius
            Y = Math.Sin(index * 2 * Math.PI / Sides) * Radius
            Points(index) = New Point(m_a.X + X, m_a.Y + Y)

        Next
        Using g As Graphics = Graphics.FromImage(m_image)
            g.DrawImage(Picture, m_a.X, m_a.Y, w, h)
        End Using

    End Sub


End Class
