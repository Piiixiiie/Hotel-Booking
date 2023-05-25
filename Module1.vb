﻿Module Module1

    Sub Main()
    'All of the variables to make the code work properly'
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

    'General gathering of data including name and arrival dates'
    Console.WriteLine("Hello what is the name the rooms will be under?")
    famName = Console.ReadLine()
    Console.WriteLine("Hi " & famName & ", we offer 3 different rooms. We also give a 10% discount for 3 or more rooms for 7 or more days!")

    Console.WriteLine("So what will the arrival date be " & famName & "?")
    arrDate = Console.ReadLine()


    Console.WriteLine("And how long would you like to stay with us for? We have up to 2 weeks free")
    'A loop only allowing up to 14 days to be booked and a minimum of 1 day'
    Do Until duration > 0 And duration < 15
        'the console throws this error up if over 14 days booked or less than 1 day'
        Console.WriteLine("We cannot accommodate your stay above 15 days or below 1 night, Please select another amount of days.")
        duration = Console.ReadLine()
    Loop
    'Below it details the rooms and prices for each type'
    Console.WriteLine("Amazing, so below are our prices for each type of room per night.")


    Console.WriteLine("Single Room - £47")
    Console.WriteLine("Double Room - £90")
    Console.WriteLine("Family Suite - £250")


    Console.WriteLine("Please choose which kind of rooms you will require.")


    'A loop that allows for 1 to 4 rooms to be booked at once, this is in total not of each type.'
    Do Until roomT >= 1 And roomT < 5
        'Data Gathering for a price'
        Console.WriteLine("How many Single Room(s) do you require?")
        sinRm = Console.ReadLine()
        'Data Gathering for a price'
        Console.WriteLine("And how many Double Room(s) do you require?")
        douRm = Console.ReadLine()
        'Data Gathering for a price'
        Console.WriteLine("And finally how many Family Suite(s) do you require?")
        famSu = Console.ReadLine()
        'Simple mathmatic equasion that will give a total number of rooms to allow the loop logic to take place'
        roomT = (famSu + douRm + sinRm)
        'An If statement that will take place upon trying to book more than 4 rooms'
        If roomT > 4 Then
            Console.WriteLine("Please rememebr we have a 4 Rooms per booking limit. Thank You.")
        End If
    Loop

    Console.WriteLine("Thank you for choosing to stay with us, below your total will be displayed.")
    'An if statment that gives the person booking a discount upon reaching certain criteria'
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
        'A function that will round all the  prices to 2 decimal places'
        Math.Round(nTotal, 2)
        Math.Round(aTotal, 2)
        Math.Round(VATTotal, 2)

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

        Math.Round(nTotal, 2)
        Math.Round(aTotal, 2)
        Math.Round(VATTotal, 2)

    End If

    'A full ending to the successful booking'
    Console.WriteLine("So your total per night will be, £" & nTotal)
    Console.WriteLine("Your total for the whole duration will be, £" & aTotal)
    Console.WriteLine("Including taxes that will be, £" & VATTotal)
    Console.WriteLine("We will be seeing you on, " & arrDate & ", we hope you enjoy your stay, " & famName & ".")



    Console.ReadLine()

End Sub

End Module
