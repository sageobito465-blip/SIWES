Module Module1

    Sub Main()
        Dim rep As String
        Do
            'Declare variabe for all numbers as double 
            Dim firstNum, secondNum, thirdNum, fourthNum, fifthNum As Double

            Console.WriteLine("HIGHEST OF NUMBERS")

            Console.WriteLine("ENTER FIRST NUMBER")
            firstNum = Console.ReadLine()

            Console.WriteLine("ENTER SECOND NUMBER")
            secondNum = Console.ReadLine()

            Console.WriteLine("ENTER THIRD NUMBER")
            thirdNum = Console.ReadLine()

            Console.WriteLine("ENTER FOURTH NUMBER")
            fourthNum = Console.ReadLine()

            Console.WriteLine("ENTER FIFTH NUMBER")
            fifthNum = Console.ReadLine()

            'Give conditions
            If (firstNum > secondNum) And (firstNum > thirdNum) And (firstNum > fourthNum) And (firstNum > fifthNum) Then
                Console.WriteLine("THE HIGHEST NUMBER IS :" & firstNum.ToString)

            ElseIf (secondNum > firstNum) And (secondNum > thirdNum) And (secondNum > fourthNum) And (secondNum > fifthNum) Then
                Console.WriteLine("THE HIGHEST NUMBER IS :" & secondNum.ToString)

            ElseIf (thirdNum > firstNum) And (thirdNum > secondNum) And (thirdNum > fourthNum) And (thirdNum > fifthNum) Then
                Console.WriteLine("THE HIGHEST NUMBER IS :" & thirdNum.ToString)

            ElseIf (fourthNum > firstNum) And (fourthNum > secondNum) And (fourthNum > thirdNum) And (fourthNum > fifthNum) Then
                Console.WriteLine("THE HIGHEST NUMBER IS :" & fourthNum.ToString)

            ElseIf (fifthNum > firstNum) And (fifthNum > secondNum) And (fifthNum > thirdNum) And (fifthNum > fourthNum) Then
                Console.WriteLine("THE HIGHEST NUMBER IS :" & fifthNum.ToString)
            Else
                Console.WriteLine("THEY ARE ALL EQUAL")

            End If
            Console.WriteLine("DO YOU WANT TO CONTINUE (Y/N)")
            rep = Console.ReadLine().ToLower()
        Loop While rep = "y"
        Console.WriteLine("PRESS ANY KEY TO EXIT")
















        Console.ReadLine()
    End Sub

End Module
