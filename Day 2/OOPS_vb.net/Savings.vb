Public Class Savings
    Inherits Accounts

    'this class object, savings class object will now have all the properties and methods from parent
    ' additionally they can have its own properties and methods as well

    Private v_interestRate As Integer
    Public Property InterestRate() As Integer
        Get
            Return v_interestRate
        End Get
        Set(value As Integer)
            v_interestRate = value
        End Set
    End Property


End Class
