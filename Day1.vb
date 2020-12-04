Imports System.IO

Module Day1
    Sub Main()

        Using sr As StreamReader = New StreamReader("inputday1.txt")
            Dim Line As Integer

            Dim Array1 As ArrayList = New ArrayList



            Line = sr.ReadLine()
            While Line <> Nothing
                Console.WriteLine(Line)
                Array1.Add(Line)

                Line = sr.ReadLine


            End While
            Console.ReadLine()
            'Console.WriteLine(Array1(7))
            For i = 0 To Array1.Count - 1
                Dim CurrentNumber1 As Integer = Array1(i)
                For j = 0 To Array1.Count - 1
                    Dim CurrentNumber2 As Integer = Array1(j)

                    'Dim Total As Integer = CurrentNumber1 + CurrentNumber2
                    Dim Answer As Integer = 2020
                    For k = 0 To Array1.Count - 1
                        Dim CurrentNumber3 As Integer = Array1(k)

                        If CurrentNumber1 + CurrentNumber2 + CurrentNumber3 = Answer Then
                            Dim MultTot As Integer
                            MultTot = CurrentNumber1 * CurrentNumber2 * CurrentNumber3
                            'Console.WriteLine(CurrentNumber1)
                            Console.WriteLine(CurrentNumber1)
                            Console.WriteLine(CurrentNumber2)
                            Console.WriteLine(CurrentNumber3)
                            Console.WriteLine((MultTot))
                            'Console.WriteLine("These Equal ", MultTot, "when multiplied Together")

                        End If
                    Next


                Next


            Next



            Console.ReadLine()
        End Using
    End Sub
End Module
