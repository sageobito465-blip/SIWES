Module ndFunction
    Public Function gradeScore(ByVal score As Double, ByVal unit As Double)
        Dim gp As Double
        If score >= 75.0 And score <= 100.0 Then
            gp = 4.0 * unit
        ElseIf score >= 70.0 And score <= 74.9 Then
            gp = 3.5 * unit
        ElseIf score >= 60.0 And score <= 69.9 Then
            gp = 3.0 * unit
        ElseIf score >= 50.0 And score <= 59.9 Then
            gp = 2.5 * unit
        ElseIf score >= 40.0 And score <= 49.9 Then
            gp = 2.0 * unit
        Else
            gp = 1.99 * unit

        End If
        Return gp

    End Function

End Module
