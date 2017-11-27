Module Module1

    Sub Main()
        Dim intValue1, intValue2 As Integer
        Dim Cale_Class As New Class1

        intValue1 = 3
        intValue2 = 10

        Cale_Class.Calc_Plus(intValue1, intValue2)
        Cale_Class.Calc_Minus(intValue1, intValue2)
        Cale_Class.Calc_Multi(intValue1, intValue2)
        Cale_Class.Calc_Division(intValue1, intValue2)

        Console.WriteLine()
        Console.WriteLine("{0} + {1} = {2}", intValue1, intValue2, Cale_Class.intPlus)
        Console.WriteLine("{0} - {1} = {2}", intValue1, intValue2, Cale_Class.intMinus)
        Console.WriteLine("{0} * {1} = {2}", intValue1, intValue2, Cale_Class.intMulti)
        Console.WriteLine("{0} / {1} = {2}", intValue1, intValue2, Cale_Class.intDivision)
    End Sub

End Module
