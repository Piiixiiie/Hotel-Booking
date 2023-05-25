Module Module1

    Sub Main()
        Dim famName As String
        Dim arrDate As String
        Dim duration As String
        Dim sinRm As Integer
        Dim douRm As Integer
        Dim famSu As Integer
        Dim sinRmT As Integer
        Dim douRmT As Integer
        Dim famSuT As Integer
        Dim roomT As Integer
        Dim nTotal As Double
        Dim discount As Double
        Dim aTotal As Double
        Dim VATTotal As Double


        Console.WriteLine("Hello what is the name the rooms will be under?")
        famName = Console.ReadLine()
        Console.WriteLine("Hi " & famName & ", we offer 3 different rooms. We also give a 10% discount for 3 or more rooms for 7 or more days!")

        Console.WriteLine("So what will the arrival date be " & famName & "?")
        arrDate = Console.ReadLine()


        Console.WriteLine("And how long would you like to stay with us for? We have up to 2 weeks free")

        Do Until duration > 0 And duration < 15
        Console.WriteLine("We cannot accomodate your stay above 15 days or below 1 night, Please select another amount of days.")
            duration = Console.ReadLine()
        Loop

        Console.WriteLine("Amazing, so below are our prices for each type of room per night.")


        Console.WriteLine("Single Room - £47")
        Console.WriteLine("Double Room - £90")
        Console.WriteLine("Family Suite - £250")


        Console.WriteLine("Please choose which kind of rooms you will require.")



        Do Until roomT >= 1 And roomT < 5

            Console.WriteLine("How many Single Room(s) do you require?")
            sinRm = Console.ReadLine()

            Console.WriteLine("And how many Double Room(s) do you require?")
            douRm = Console.ReadLine()

            Console.WriteLine("And finally how many Family Suite(s) do you require?")
            famSu = Console.ReadLine()

        roomT = (famSu + douRm + sinRm)

            If roomT > 4 Then
                Console.WriteLine("Please rememebr we have a 4 Rooms per booking limit. Thank You.")
            End If
        Loop

        Console.WriteLine("Thank you for choosing to stay with us, below your total will be displayed.")

        If roomT > 3 And duration > 7 Then

            Console.WriteLine("You have booked, " & sinRm & " Single room(s)")
            Console.WriteLine("You have booked, " & douRm & " Double room(s)")
            Console.WriteLine("You have booked, " & famSu & " Family Suite(s)")
            Console.WriteLine("You are eligible for a discount of 10% ")

            sinRmT = (sinRm * 47)
            douRmT = (douRm * 90)
            famSuT = (famSu * 250)

            nTotal = (sinRmT + douRmT + famSuT)
            aTotal = (nTotal * duration)
            discount = (aTotal * 0.9)
            VATTotal = (discount * 1.2)

        Else

            Console.WriteLine("You have booked, " & sinRm & " Single room(s)")
            Console.WriteLine("You have booked, " & douRm & " Double room(s)")
            Console.WriteLine("You have booked, " & famSu & " Family Suite(s)")

            sinRmT = (sinRm * 47)
            douRmT = (douRm * 90)
            famSuT = (famSu * 250)

            nTotal = (sinRmT + douRmT + famSuT)
            aTotal = (nTotal * duration)
            VATTotal = (aTotal * 1.2)

        End If

    Math.Round(nTotal, 2)
    Math.Round(aTotal, 2)
    Math.Round(VATTotal, 2)

        Console.WriteLine("So your total per night will be, £" & nTotal)
        Console.WriteLine("Your total for the whole duration will be, £" & aTotal)
        Console.WriteLine("Including taxes that will be, £" & VATTotal)
        Console.WriteLine("We will be seeing you on, " & arrDate & ", we hope you enjoy your stay, " & famName & ".")



        Console.ReadLine()

    End Sub

End Module
