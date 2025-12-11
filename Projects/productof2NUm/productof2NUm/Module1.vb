Module Module1

    Sub Main()
        Dim tryagain As String
        Do
            Dim firstNum As Double
            Dim secondNum As Double
            Dim prod As Double

            Console.WriteLine("PRODUCT OF TWO NUMBERS: ")
            Console.WriteLine("ENTER FIRST NUMBER:")
            firstNum = Console.ReadLine()
            Console.WriteLine("ENTER SECOND NUMBER:  ")
            secondNum = Console.ReadLine()
            prod = firstNum * secondNum
            Console.WriteLine("PRODUCT IS: " & prod.ToString)
            Console.WriteLine("DO YOU WANT TO TRY AGAIN (Y/N)")
            tryagain = Console.ReadLine().ToLower()
        Loop While tryagain = "y"
        Console.WriteLine("ENTTER ANY KEY TO EXITT")












        Console.ReadLine()

    End Sub

End Module
