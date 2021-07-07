Imports System.Text
Imports BankAccounts
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class BankAccounts_Test

    <TestMethod()> Public Sub TestConstructors()

        'Arrange
        Dim AccountOwner As String = "Ms Ammon Calypso"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim InterestRate As Double = 3.0
        Dim BankBalance As Double = 901336.28
        Dim CountryOfOrigin As String = "Switzerland"


        'Act
        Dim Account1 As New BankAccounts.BankAccount(AccountOwner, AccountNumber, InterestRate, BankBalance, CountryOfOrigin)
        'Dim Account2 As New BankAccounts.BankAccount(AccountOwner, AccountNumber, InterestRate, BankBalance)
        'Dim Account3 As New BankAccounts.BankAccount(AccountOwner, AccountNumber, BankBalance)

        'Assert
        Assert.IsNotNull(Account1)

    End Sub

    Private Function NewAccount() As BankAccounts.BankAccount
        Dim AccountOwner As String = "Ms Ammon Calypso"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim InterestRate As Double = 3.0
        Dim BankBalance As Double = 901336.28
        Dim CountryOfOrigin As String = "Switzerland"

        Dim Account1 As New BankAccounts.BankAccount(AccountOwner, AccountNumber, InterestRate, BankBalance, CountryOfOrigin)

        Return Account1
    End Function

    <TestMethod()> Public Sub TestGetAccountHolder()

        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'Act
        Dim Name As String = Account1.GetAccountOwner

        'Assert
        Assert.AreEqual(Name, "Ms Ammon Calypso")

    End Sub
    <TestMethod()> Public Sub TestGetAccountNumber()

        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'Act
        Dim Number As String = Account1.GetAccountNumber

        'Assert
        Assert.AreEqual(Number, "CH93 0076 2001 6734 8790 2")

    End Sub

    <TestMethod()> Public Sub TestGetInterestRate()

        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'Act
        Dim Interest As Double = Account1.GetInterestRate

        'Assert
        Assert.AreEqual(Interest, 3.0)

    End Sub

    <TestMethod()> Public Sub TestGetBankBalance()

        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'Act
        Dim Balance As Double = Account1.GetBankBalance

        'Assert
        Assert.AreEqual(Balance, 901336.28)

    End Sub

    <TestMethod()> Public Sub TestGetCountryOfOrigin()

        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'Act
        Dim Country As String = Account1.GetCountryOfOrigin

        'Assert
        Assert.AreEqual(Country, "Switzerland")

    End Sub

    <TestMethod()> Public Sub TestSetInterestRate()

        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'Act
        Account1.SetInterestRate(5.1)

        'Assert
        Assert.AreEqual(5.1, Account1.GetInterestRate)
    End Sub

    <TestMethod()> Public Sub TestAddInterest()

        'Original Amount * R * T = Interest = 2,253.34 = 903,589.62
        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'Act
        Account1.AddInterest()

        'Assert
        Assert.AreEqual(Account1.GetBankBalance, 903589.62)

    End Sub

    <TestMethod()> Public Sub TestToStringMethod()
        'Must Print like This:
        'Switzerland + vbCrLf
        'CH93 76 2001 6734 8790 2 + vbcrlf
        'MS Ammon Calypso + vbcrlf
        'Interest: 3.0% + vbcrlf
        '901336.28 + vbcrlf

        'Arrange
        Dim TestString As New StringBuilder
        TestString.Append("Switzerland" & vbCrLf)
        TestString.Append("CH93 0076 2001 6734 8790 2" & vbCrLf)
        TestString.Append("Ms Ammon Calypso" & vbCrLf)
        TestString.Append("Interest: 3.0%" & vbCrLf)
        TestString.Append("901336.28" & vbCrLf)

        Dim Account1 As BankAccount = NewAccount()

        'Act
        Dim RealString = Account1.ToString()

        'Assert
        Assert.AreEqual(TestString.ToString(), RealString.ToString())

    End Sub

    <TestMethod()> Public Sub TestDeposit()
        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount
        Dim TestValue As Double = 901336.28 + 700.0

        'Act
        Dim RealValue As Double = Account1.Deposit(700.0)

        'Assert
        Assert.AreEqual(TestValue, RealValue)
    End Sub

    <TestMethod()> Public Sub TestSmallWithdrawl()
        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount
        Dim TestValue As Double = 901336.28 - 700.0

        'Act
        Dim RealValue As Double = Account1.Withdrawl(700.0)

        'Assert
        Assert.AreEqual(TestValue, RealValue)
    End Sub

    <TestMethod()> Public Sub TestLargeWithdrawl()
        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount
        Dim TestValue As Double = 901336.28

        'Act
        Try
            Dim RealValue As Double = Account1.Withdrawl(1000000.0)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        'Assert
        Assert.AreEqual(TestValue, Account1.GetBankBalance())

    End Sub
End Class