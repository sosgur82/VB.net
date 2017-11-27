Module Module1

    Sub Main()
        Dim circle1 As New Circle(1, 1, 1)
        Dim circle2 As New Circle(2, 2, 2)

        Console.WriteLine()
        Console.WriteLine("첫번째 원의 정보 ")
        circle1.PrintCircle()

        Console.WriteLine()
        Console.WriteLine("두번째 원의 정보 ")
        circle2.PrintCircle()
    End Sub

End Module
