Imports System.Text
Imports BankAccounts
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class GUI_Test

    <TestMethod()> Public Sub TestCreateAccount()
        'Arrange
        Dim AccountOwner As String = "Ms Ammon Calypso"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim InterestRate As Double = 3.0
        Dim BankBalance As Double = 901336.28
        Dim CountryOfOrigin As String = "Switzerland"

        Dim newform As New BankAccountsForm()
        newform.SetTestforTesting(AccountOwner, AccountNumber, InterestRate, BankBalance, CountryOfOrigin)

        'Act
        newform.CreateAccount()
        Dim TempAccount() As BankAccount = newform.GetAccounts()

        'Assert
        Assert.AreEqual(AccountOwner, TempAccount(0).GetAccountOwner())
        Assert.AreEqual(AccountNumber, newform.GetAccounts(0).GetAccountNumber())
        Assert.AreEqual(InterestRate, newform.GetAccounts(0).GetInterestRate())
        Assert.AreEqual(BankBalance, newform.GetAccounts(0).GetBankBalance())
        Assert.AreEqual(CountryOfOrigin, newform.GetAccounts(0).GetCountryOfOrigin())

    End Sub

    <TestMethod()> Public Sub TestEmptyAccountOwner()
        Dim AccountOwner As String = ""
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim InterestRate As String = 3.0
        Dim BankBalance As String = 901336.28
        Dim CountryOfOrigin As String = "Switzerland"

        Dim newform As New BankAccountsForm()
        newform.SetTestforTesting(AccountOwner, AccountNumber, InterestRate, BankBalance, CountryOfOrigin)

        'Act
        Try
            newform.CreateAccount()
            Assert.Fail()
        Catch ex As Exception

            'Assert
            Assert.AreEqual("No Account Owner Has Been Entered", ex.Message)
        End Try

    End Sub
    <TestMethod()> Public Sub TestEmptyAccountNumber()
        Dim AccountOwner As String = "Ms Ammon Calypso"
        Dim AccountNumber As String = ""
        Dim InterestRate As String = 3.0
        Dim BankBalance As String = 901336.28
        Dim CountryOfOrigin As String = "Switzerland"

        Dim newform As New BankAccountsForm()
        newform.SetTestforTesting(AccountOwner, AccountNumber, InterestRate, BankBalance, CountryOfOrigin)

        'Act
        Try
            newform.CreateAccount()
            Assert.Fail()
        Catch ex As Exception

            'Assert
            Assert.AreEqual("No Account Number Has Been Entered", ex.Message)
        End Try

    End Sub

    <TestMethod()> Public Sub TestEmptyInterestRate()
        Dim AccountOwner As String = "Ms Ammon Calypso"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim InterestRate As String = ""
        Dim BankBalance As String = 901336.28
        Dim CountryOfOrigin As String = "Switzerland"

        Dim newform As New BankAccountsForm()
        newform.SetTestforTesting(AccountOwner, AccountNumber, InterestRate, BankBalance, CountryOfOrigin)

        'Act
        Try
            newform.CreateAccount()
            Assert.Fail()
        Catch ex As Exception

            'Assert
            Assert.AreEqual("No Interest Rate Has Been Entered", ex.Message)
        End Try

    End Sub


    <TestMethod()> Public Sub TestEmptyBankBalance()
        Dim AccountOwner As String = "Ms Ammon Calypso"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim InterestRate As String = 3.0
        Dim BankBalance As String = ""
        Dim CountryOfOrigin As String = "Switzerland"

        Dim newform As New BankAccountsForm()
        newform.SetTestforTesting(AccountOwner, AccountNumber, InterestRate, BankBalance, CountryOfOrigin)


        'Act
        Try
            newform.CreateAccount()
            Assert.Fail()
        Catch ex As Exception

            'Assert
            Assert.AreEqual("No Balance Has Been Entered", ex.Message)
        End Try

    End Sub

    <TestMethod()> Public Sub TestEmptyCountryofOrigin()
        Dim AccountOwner As String = "Ms Ammon Calypso"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim InterestRate As String = 3.0
        Dim BankBalance As String = 901336.28
        Dim CountryOfOrigin As String = ""

        Dim newform As New BankAccountsForm()
        newform.SetTestforTesting(AccountOwner, AccountNumber, InterestRate, BankBalance, CountryOfOrigin)


        'Act
        Try
            newform.CreateAccount()
            Assert.Fail()
        Catch ex As Exception

            'Assert
            Assert.AreEqual("No Country Has Been Entered", ex.Message)
        End Try

    End Sub

    <TestMethod()> Public Sub TestAddFiveAccounts()
        'Arrange 
        Dim AccountOwner As String = "Ms Ammon Calypso"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim InterestRate As String = 3.0
        Dim BankBalance As String = 901336.28
        Dim CountryOfOrigin As String = "Switzerland"

        Dim newform As New BankAccountsForm()

        'Act
        Try
            For Counter As Integer = 0 To 4
                newform.SetTestforTesting(Counter & "_" & AccountOwner, AccountNumber, InterestRate, BankBalance, CountryOfOrigin)
                newform.CreateAccount()
            Next

        Catch ex As Exception
            Assert.Fail()
        End Try

        'Assert
        Dim TempAccounts() As BankAccount = newform.GetAccounts()

        For Each BA In TempAccounts
            If BA Is Nothing Then Assert.Fail()
        Next

    End Sub

    <TestMethod()> Public Sub TestCannotAddSixAccounts()
        'Arrange 
        Dim AccountOwner As String = "Ms Ammon Calypso"
        Dim AccountNumber As String = "CH93 0076 2001 6734 8790 2"
        Dim InterestRate As String = 3.0
        Dim BankBalance As String = 901336.28
        Dim CountryOfOrigin As String = "Switzerland"

        Dim newform As New BankAccountsForm()

        'Act
        Try
            For Counter As Integer = 0 To 5
                newform.SetTestforTesting(Counter & "_" & AccountOwner, AccountNumber, InterestRate, BankBalance, CountryOfOrigin)
                newform.CreateAccount()
            Next

            'Assert
            Assert.Fail()

        Catch ex As Exception
            'Assert
            Assert.AreEqual("You Cannot Add a Sixth Account", ex.Message())

        End Try

    End Sub

End Class