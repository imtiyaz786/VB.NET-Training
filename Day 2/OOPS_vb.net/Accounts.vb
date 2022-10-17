Public Class Accounts

    Private v_accNo As Integer
    Public Property AccountNumber() As Integer
        Get
            Return v_accNo
        End Get
        Set(value As Integer)
            v_accNo = value
        End Set
    End Property

    Private v_accName As String
    Public Property AccountName() As String
        Get
            Return v_accName
        End Get
        Set(value As String)
            v_accName = value
        End Set
    End Property

    Private v_accBalance As Double
    Public Property AccountBalance() As Double
        Get
            Return v_accBalance
        End Get
        Set(value As Double)
            v_accBalance = value
        End Set
    End Property

    Private b_accIsActive As Boolean
    Public Property AccountIsActive() As Boolean
        Get
            Return b_accIsActive
        End Get
        Set(value As Boolean)
            b_accIsActive = value
        End Set
    End Property

    Function Withdraw(amount As Integer) As Integer
        AccountBalance -= amount
        Return AccountBalance
    End Function

    Function Depsoit(amount As Integer) As Integer
        AccountBalance += amount
        Return AccountBalance
    End Function

End Class
