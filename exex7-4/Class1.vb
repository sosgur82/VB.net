Public Class myTriangle
    Public intWidth As Integer
    Public intHeight As Integer

    Public Sub SetWidth()
        Console.WriteLine("삼각형의 밑변을 입력하세요 : ")
        intWidth = Console.ReadLine()
    End Sub

    Public Sub setHeight()
        Console.WriteLine("삼각형의 높이를 입력하세요 : ")
        intHeight = Console.ReadLine()
    End Sub

    Public Function GetArea() As Single
        GetArea = intWidth * intWidth / 2
    End Function
End Class