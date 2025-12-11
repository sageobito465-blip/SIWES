Module Module1

    Sub Main()
        Dim msg As String
        Do

            Dim price As Double
            Dim mango As Integer
            Dim totalPrice As Double


            Console.WriteLine("SOFTWARE TO CALCULATE PRICES OF MANGO")
            Console.WriteLine("ENTER PRICE FOR MANGO")
            price = Console.ReadLine()
            Console.WriteLine("ENTER QUANTITY OF MANGO")
            mango = Console.ReadLine()
            totalPrice = price * mango
            Console.WriteLine("TOTAL PRICE IS :" & totalPrice.ToString)
            Console.WriteLine("DO YOU WISH TO CONTINUE (Y/N)")
            msg = Console.ReadLine().ToLower()
        Loop While msg = "y"




        Console.ReadLine()
    End Sub

End Module
