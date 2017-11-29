Module Module1

    Sub Main()
        Dim sngValue_x As Single
        Dim sngValue_N As Single
        Dim sngResult As Single
        Console.WriteLine()
        Console.Write("밑 값을 입력하세요 : ")
        sngValue_x = Console.ReadLine()
        Console.Write("지수 값을 입력하세요 : ")
        sngValue_N = Console.ReadLine()


        sngResult = Power(sngValue_x, sngValue_N)
        Console.WriteLine()
        Console.WriteLine("{0}의{1}승 = {2}", sngValue_x, sngValue_N, sngResult)

    End Sub

    Public Function Power(x As Single, n As Single) As Single
        If n <= 1 Then
            Power = x
        Else
            Power = x ^ n
        End If
    End Function
End Module
