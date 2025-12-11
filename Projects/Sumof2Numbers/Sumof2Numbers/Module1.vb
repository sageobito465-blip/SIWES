Module Module1

    Sub Main()
        Dim gp As String
        Do

            Dim firstNum As Double
            Dim secondNum As Double
            Dim sum As Double

            Console.WriteLine("ENTER FIRST NUMBER:")
            firstNum = Console.ReadLine()
            Console.WriteLine("ENTER SECOND NUMBER:")
            secondNum = Console.ReadLine()
            sum = firstNum + secondNum
            Console.WriteLine("SUM IS:" & sum.ToString)
            Console.WriteLine("DO YOU WISH TO CONTINUE (Y/N)")
            gp = Console.ReadLine().ToLower()
        Loop While gp = "y"
        Console.WriteLine("PRESS ANY KEY TO EXIT")














        Console.ReadLine()
    End Sub

End Module
