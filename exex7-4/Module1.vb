Module Module1

    Sub Main()
        Dim triangle As New myTriangle

        triangle.SetWidth()
        triangle.setHeight()

        Console.WriteLine()
        Console.WriteLine("삼각형의 넓이는 {0} 입니다.", triangle.GetArea())

    End Sub

End Module
