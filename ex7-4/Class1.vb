Public Class Point
    Public intX As Integer
    Public intY As Integer

    Public Sub New()
        intX = 0
        intY = 0
    End Sub

    Public Sub New(ByVal pointX As Integer, ByVal pointY As Integer)
        intX = pointX
        intY = pointY

    End Sub
    Public Sub New(ByVal setPoint As Point)
        intX = setPoint.intX
        intY = setPoint.intY
    End Sub
    Public Sub PrintPoint()
        Console.WriteLine("x = {0}, y = {1}", intX, intY)
    End Sub
End Class

Public Class Circle
    Public point As Point
    Public radius As Integer

    Public Sub New()
        point = New Point
        radius = 0

    End Sub

    Public Sub New(ByVal xPoint As Integer, ByVal yPoint As Integer, ByVal rad As Integer)
        point = New Point(xPoint, yPoint)
        radius = rad
    End Sub

    Public Sub New(ByVal setPoint As Point, ByVal rad As Integer)
        point = New Point(setPoint)
        radius = rad
    End Sub

    Public Sub PrintCircle()
        point.PrintPoint()
        Console.WriteLine("넓이 ={0}", radius * radius * 3.14)
    End Sub

End Class
