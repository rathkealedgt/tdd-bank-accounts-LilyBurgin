Imports System.Text

'''<summary>
'''This code represents a single bank account
'''</summary>
'''<author> Lily Burgin </author>
'''<Date> 12/05/2020 </Date>
Public Class BankAccount
    Private AccountOwner As String
    Private AccountNumber As String
    Private InterestRate As Double
    Private BankBalance As Double
    Private CountryOfOrigin As String

    Public Sub New(accountowner As String, accountnumber As String, interestrate As Double, bankbalance As Double, countryoforigin As String)
        Me.AccountOwner = accountowner
        Me.AccountNumber = accountnumber
        Me.InterestRate = interestrate
        Me.BankBalance = bankbalance
        Me.CountryOfOrigin = countryoforigin

    End Sub

    Public Function GetAccountOwner() As String
        Return Me.AccountOwner

    End Function

    Public Function GetAccountNumber() As String
        Return Me.AccountNumber
    End Function


    Public Function GetInterestRate() As Double
        Return Me.InterestRate
    End Function

    Public Function GetBankBalance() As Double
        Return Me.BankBalance
    End Function

    Public Function GetCountryOfOrigin() As String
        Return Me.CountryOfOrigin
    End Function

    Public Function SetInterestRate(interest As Double)
        Me.InterestRate = interest

        Return Nothing
    End Function

    Public Function AddInterest()
        Dim BalancewInterest As Double = Me.BankBalance + (Me.BankBalance * 0.03 * (1 / 12))

        Me.BankBalance = Math.Round(BalancewInterest, 2)

        Return Nothing
    End Function

    Public Overrides Function ToString() As String
        Dim AccountString As New StringBuilder
        AccountString.Append(CountryOfOrigin & vbCrLf)
        AccountString.Append(AccountNumber & vbCrLf)
        AccountString.Append(AccountOwner & vbCrLf)
        AccountString.Append("Interest: " & InterestRate.ToString("N1") & "%" & vbCrLf)
        AccountString.Append(BankBalance & vbCrLf)

        Return AccountString.ToString()
    End Function

    Public Function Deposit(Amount As Double) As Double
        Me.BankBalance += Amount

        Return Me.BankBalance
    End Function

    Public Function Withdrawl(Amount As Double) As Double

        If Amount > Me.BankBalance Then
            Throw New Exception("Insufficent Funds")
        End If
        Me.BankBalance -= Amount

        Return Me.BankBalance
    End Function
End Class
