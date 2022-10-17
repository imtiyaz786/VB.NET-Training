Module Module1

    Sub Main()

#Region "Account Object"
        'Dim accObj1 As New Accounts With {
        '    .AccountNumber = 101,
        '    .AccountName = "Imtiyaz",
        '    .AccountBalance = 5000,
        '    .AccountIsActive = True
        '}

        'Console.WriteLine("Account Number    : " & accObj1.AccountNumber)
        'Console.WriteLine("Account Name      : " & accObj1.AccountName)
        'Console.WriteLine("Account Balance   : " & accObj1.AccountBalance)
        'Console.WriteLine("Account Is Active?: " & accObj1.AccountIsActive)

        'Console.WriteLine("Enter Choice")
        'Console.WriteLine("1. Withdraw")
        'Console.WriteLine("2. Deposit")

        'Dim choice As Integer = Console.ReadLine()

        'If choice = 1 Then
        '    accObj1.Withdraw(700)
        'Else
        '    accObj1.Depsoit(700)
        'End If

        'Console.WriteLine("Balance after transaction: " & accObj1.AccountBalance)
#End Region

#Region "Saving Object"

        'Dim savObj As New Savings With {
        '    .AccountBalance = 6000
        '}

        'Console.WriteLine("Available balance: " & savObj.AccountBalance)

        'savObj.Withdraw(1800)
        'Console.WriteLine("Available balance: " & savObj.AccountBalance)

        'savObj.InterestRate = 8

        'Console.WriteLine("Interest rate: " & savObj.InterestRate)
#End Region

#Region "Employee Object"

        Dim empobj As New Employee With {
            .EmployeeNumber = 2085836,
            .EmployeeName = "imtiyaz ali",
            .EmployeeDesignation = "software engineer",
            .EmployeeSalary = 26300,
            .EmployeeAvailableLeaves = 10
        }

        Console.WriteLine("Employee Number          : " & empobj.EmployeeNumber)
        Console.WriteLine("Employee Name            : " & empobj.EmployeeName)
        Console.WriteLine("Employee Designation     : " & empobj.EmployeeDesignation)
        Console.WriteLine("Employee Salary          : " & empobj.EmployeeSalary)
        Console.WriteLine("Employee Available Leaves: " & empobj.EmployeeAvailableLeaves)

        Console.WriteLine("Bonus Amount             : " & empobj.Bonus(20))
        empobj.ApplyLeave(2)
        Console.WriteLine("Remaining Leaves         : " & empobj.EmployeeAvailableLeaves)

#End Region

        Console.ReadLine()

    End Sub

End Module
