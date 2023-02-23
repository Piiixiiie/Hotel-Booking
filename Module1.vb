Module Module1

    Sub Main()
        Dim famName As String
        Dim arrDate As String
        Dim amtRooms As Double
        Dim sinRm As Integer
        Dim douRm As Integer
        Dim famSu As Integer
        Dim Total As Double
        Dim rooms As Integer
        Dim ans As Boolean

        Console.WriteLine("Hello what is the name the rooms will be under?")
        famName = Console.ReadLine()
        Console.WriteLine("Hi " & famName & ", we offer 3 different rooms. We also give a 10% discount for 3 or more rooms for 7 or more days!")

        Console.WriteLine("So what will the arrival date be " & famName & "?")
        arrDate = Console.ReadLine()

        Console.WriteLine("And how many rooms? Please note we have a max of 4 per booking.")
        amtRooms = Console.ReadLine()

        Console.WriteLine("Below are our prices for each type of room per night.")

        Console.WriteLine("Single Room - £47")
        Console.WriteLine("Double Room - £90")
        Console.WriteLine("Family Suite - £250")


        Console.WriteLine("Please choose which kind of rooms you will require.")



        Console.WriteLine("How many Single Room(s) do you require?")
        sinRm = Console.ReadLine()

        Console.WriteLine("And how many Double Room(s) do you require?")
        douRm = Console.ReadLine()

        Console.WriteLine("And Fianlly how many Family Suite(s) do you require?")
        famSu = Console.ReadLine()





        Console.ReadLine()

    End Sub

End Module
