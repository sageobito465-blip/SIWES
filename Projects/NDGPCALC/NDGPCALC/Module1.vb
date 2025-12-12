Module Module1

    Sub Main()
        Dim com111, com112, com113, com114, com115, mth111, gns111, gns101 As Double
        Dim level As Integer
        Dim sem As Integer


        Console.WriteLine("=============== MAPOLY GP CALCULATOR FOR COMPUTER SCIENCE ND 1 AND ND2 ===============")
        Console.WriteLine("SELET LEVEL: ENTER 1 FOR ND1, ENTER 2 FOR ND2.: ")
        level = Console.ReadLine()
        If level = 1 Then
            Console.WriteLine("SELECT SEMESTER: ENTER 1 FOR FIRST SEMMESTER, ENTER 2 FOR SECOND SEMESTER: ")
            sem = Console.ReadLine()
            If sem = 1 Then
                Console.WriteLine("ENTER SCORE FOR INTRODUCTION TO COMPUTING COM111 (3 UNITS)")
                com111 = Console.ReadLine()
                Console.WriteLine("ENTER SCORE FOR INTRODUCTION TO DIGITAL ELECTRONICS (3 UNITS)")
                com112 = Console.ReadLine()
                Console.WriteLine("ENTER SCORE FOR INTRODUCTION TO PROGRAMMING COM113 (3 UNITS)")
                com113 = Console.ReadLine()
                Console.WriteLine("ENTER SCORE FOR STATISTICS IN COMPUTING COM114 ( 2 UNITS)")
                com114 = Console.ReadLine()
                Console.WriteLine("ENTER SCORE FOR INTRODUCTION TO COMPUTER APPLICATION PACKAGES 1 COM115 ( 3 UNITS)")
                com115 = Console.ReadLine()
                Console.WriteLine("ENTER SCORE FOR CITIZENSHIP EDUCATION 1  GNS111 ( 2 UNITS)")
                gns111 = Console.ReadLine()
                Console.WriteLine("ENTER SCORE FOR USE OF ENGLISH 1 GNS101 ( 2 UNITS)")
                gns101 = Console.ReadLine()
                Console.WriteLine("ENTER SCORE FOR LOGIC AND LINEAR ALGEBRA MTH111 ( 2 UNITS)")
                mth111 = Console.ReadLine()

                Dim gpcom111, gpcom112, gpcom113, gpcom114, gpcom115, gpgns101, gpgns111, gpmth111 As Double

                Dim totalunit As Integer
                Dim gp As Double
                Dim totalscorePoint As Double
                gpcom111 = ndFunction.gradeScore(com111, 3)
                gpcom112 = ndFunction.gradeScore(com112, 3)
                gpcom113 = ndFunction.gradeScore(com113, 3)
                gpcom114 = ndFunction.gradeScore(com114, 2)
                gpcom115 = ndFunction.gradeScore(com115, 3)
                gpgns101 = ndFunction.gradeScore(gns101, 2)
                gpgns111 = ndFunction.gradeScore(gns111, 2)
                gpmth111 = ndFunction.gradeScore(mth111, 2)

                totalunit = 20
                totalscorePoint = gpcom111 + gpcom112 + gpcom113 + gpcom114 + gpcom115 + gpgns101 + gpgns111 + gpmth111
                gp = totalscorePoint / totalunit
                Console.WriteLine("TOTAL SCORE POINT IS: " & totalscorePoint.ToString())
                Console.WriteLine("TOTAL UNIT IS: " & totalunit)
                If gp >= 3.5 And gp <= 4.0 Then
                    Console.WriteLine("DISTINCTION: YOUR GP IS: " & gp.ToString())
                ElseIf gp >= 3.0 And gp <= 3.49 Then
                    Console.WriteLine("UPPER CREDIT: YOUR GP IS: " & gp.ToString())
                ElseIf gp >= 2.5 And gp <= 2.99 Then
                    Console.WriteLine("LOWER CREDIT: YOUR GP IS: " & gp.ToString())
                ElseIf gp >= 2.0 And gp <= 2.49 Then
                    Console.WriteLine("PASS: YOUR GP IS: " & gp.ToString())
                Else
                    Console.WriteLine("FAIL: YOUR GP IS: " & gp.ToString())

                End If
            ElseIf sem = 2 Then
                Dim com121, com122, com123, com124, com125, com126, gns128, gns102, gns228, eed126 As Double
                Dim totalunit As Integer
                Dim gpcom121, gpcom122, gpcom123, gpcom124, gpcom125, gpcom126, gpgns102, gpgns228, gpeed126, gpgns128 As Double
                Dim totalscorePoint As Double
                Dim gp As Double


                Console.WriteLine("ENTER SCORE FOR INTRODUCTION TO C PROGRAMMING LANGUAGE COM121 (3 UNITS)")
                com121 = Console.ReadLine()
                Console.WriteLine("ENTER SCORE FOR INTRODUCTION TO INTERNET COM122 (3 UNITS)")
                com122 = Console.ReadLine()
                Console.WriteLine("ENTER SCORE FOR PROGRAMMING LANGUAGE USING JAVA I COM123 (2 UNITS)")
                com123 = Console.ReadLine()
                Console.WriteLine("ENTER SCORE FOR  DATA STRUCTURE AND ALGORITHMS COM124( 3 UNITS)")
                com124 = Console.ReadLine()
                Console.WriteLine("ENTER SCORE FOR INTRODUCTION TO SYSTEM ANALYSIS AND DESIGN COM125 ( 3 UNITS)")
                com125 = Console.ReadLine()
                Console.WriteLine("ENTER SCORE FOR PC UPGRADE & MAINTENANCE COM126 ( 2 UNITS)")
                com126 = Console.ReadLine()
                Console.WriteLine("ENTER SCORE FOR COMMUNICATION IN ENGLISH I GNS102 ( 3 UNITS)")
                gns102 = Console.ReadLine()
                Console.WriteLine("ENTER SCORE FOR CITIZENSHIP EDUCATION II GNS128( 2 UNITS)")
                gns128 = Console.ReadLine()
                Console.WriteLine("ENNTER SCORE FOR RESEARCH METHODOLOGY GNS228 (2 UNITS)")
                gns228 = Console.ReadLine()
                Console.WriteLine("ENTER SCORE FOR INTRODUCTION TO ENTREPRENEURSHIP EED126 (2 UNITS)")
                eed126 = Console.ReadLine()

                gpcom121 = ndFunction.gradeScore(com121, 3)
                gpcom122 = ndFunction.gradeScore(com122, 3)
                gpcom123 = ndFunction.gradeScore(com123, 2)
                gpcom124 = ndFunction.gradeScore(com124, 3)
                gpcom125 = ndFunction.gradeScore(com125, 3)
                gpcom126 = ndFunction.gradeScore(com126, 3)
                gpgns102 = ndFunction.gradeScore(gns102, 2)
                gpgns128 = ndFunction.gradeScore(gns128, 2)
                gpgns228 = ndFunction.gradeScore(gns228, 2)
                gpeed126 = ndFunction.gradeScore(eed126, 2)


                totalunit = 25
                totalscorePoint = gpcom121 + gpcom122 + gpcom123 + gpcom124 + gpcom125 + gpcom126 + gpgns102 + gpgns228 + gpeed126 + gpgns128
                gp = totalscorePoint / totalunit
                Console.WriteLine("TOTAL SCORE IS: " & totalscorePoint.ToString())
                Console.WriteLine("TOTAL UNIT IS: " & totalunit)
                If gp >= 3.5 And gp <= 4.0 Then
                    Console.WriteLine("DISTINCTION: YOUR GP IS: " & gp.ToString())
                ElseIf gp >= 3.0 And gp <= 3.49 Then
                    Console.WriteLine("UPPER CREDIT: YOUR GP IS: " & gp.ToString())
                ElseIf gp >= 2.5 And gp <= 2.99 Then
                    Console.WriteLine("LOWER CREDIT: YOUR GP IS: " & gp.ToString())
                ElseIf gp >= 2.0 And gp <= 2.49 Then
                    Console.WriteLine("PASS: YOUR GP IS: " & gp.ToString())
                Else
                    Console.WriteLine("FAIL: YOUR GP IS: " & gp.ToString())

                End If
            Else
                Console.WriteLine("WRONG INPUT KINDLY FOLLOW THE INSTRUCTIONS ABOVE:")
            End If
        ElseIf level = 2 Then
            Console.WriteLine("ENTER SCORE FOR PROGRAMMING LANGUAGE USING JAVA II COM211 (3 UNITS)")
        End If
































        Console.ReadLine()

    End Sub

End Module
