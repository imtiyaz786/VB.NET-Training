Module Module1

    Sub Main()

#Region "Greetings"

        'declare variable

        'Dim guestName As String
        'Console.WriteLine("Please enter your name:")
        'guestName = Console.ReadLine()
        'Console.WriteLine("Hello and welcome to the vb.net world, " + guestName)

#End Region

#Region "Calculation"

        'Dim firstNumber As Integer
        'Dim secondNumber As Integer

        'Dim addResult As Integer
        'Dim subResult As Integer
        'Dim mulResult As Integer
        'Dim divResult As Integer

        'Console.WriteLine("Enter first number:")
        'firstNumber = Convert.ToInt32(Console.ReadLine())

        'Console.WriteLine("Enter second number:")
        'secondNumber = Convert.ToInt32(Console.ReadLine())

        'addResult = firstNumber + secondNumber
        'subResult = firstNumber - secondNumber
        'mulResult = firstNumber * secondNumber
        'divResult = firstNumber / secondNumber

        'Console.WriteLine("Addition: " & addResult)
        'Console.WriteLine("Subtraction: " & subResult)
        'Console.WriteLine("Multiplication: " & mulResult)
        'Console.WriteLine("Division: " & divResult)

#End Region

#Region "If Condiiton"

        'Dim number As Integer
        'Console.WriteLine("Enter a number:")
        'number = Console.ReadLine()

        'If number < 0 Then
        '    Console.WriteLine("This is negative number")

        'ElseIf number > 100 Then
        '    Console.WriteLine("This is more than 100, we expected a number between 0 and 100")

        'Else
        '    Console.WriteLine("Thank you, this is a good number :)")
        'End If

#End Region


#Region "CTC Calculation"

        Console.WriteLine("Welcome to CTC calculation App!")
        Console.WriteLine("_______________________________")

        Dim monthlyBasicSalary As Integer
        Dim workCity As String
        Dim cityAllowance As Integer
        Dim pf As Integer = 1200
        Dim dearnessAllowance As Integer = 1500
        Dim transportAllowance As Integer = 1000
        Dim foodCouponsWorth As Integer = 1000
        Dim AnnualCTC As Integer

        Console.WriteLine("Enter monthly basic salary:")
        monthlyBasicSalary = Console.ReadLine()

        Console.WriteLine("Enter work location:")
        workCity = Console.ReadLine()

        If workCity = "Mumbai" Then
            cityAllowance = 600
        ElseIf workCity = "Chennai" Then
            cityAllowance = 800
        ElseIf workCity = "Bangalore" Then
            cityAllowance = 1200
        End If

        AnnualCTC = (monthlyBasicSalary + cityAllowance + pf + dearnessAllowance + transportAllowance + foodCouponsWorth) * 12

        Console.WriteLine("Annaul basic salary     : " & monthlyBasicSalary * 12)
        Console.WriteLine("City Allowance          : " & cityAllowance * 12)
        Console.WriteLine("Contribution towards PF : " & pf * 12)
        Console.WriteLine("Dearness Allowance      : " & dearnessAllowance * 12)
        Console.WriteLine("Transport Allowance     : " & transportAllowance * 12)
        Console.WriteLine("Food Couption worth     : " & foodCouponsWorth * 12)
        Console.WriteLine("-------------------------------")
        Console.WriteLine("Total cost to company   : " & AnnualCTC)

#End Region

        Console.ReadLine()

    End Sub

End Module
