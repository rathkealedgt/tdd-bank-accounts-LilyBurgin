Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms

Public Class BankAccountsForm
    Private Accounts(4) As BankAccount
    Private NumAccounts As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.NumAccounts = 0

    End Sub

    Private Sub BtnInterestRate_Click(sender As Object, e As EventArgs) Handles BtnInterestRate.Click
        For Each BA As BankAccount In Me.Accounts
            If BA Is Nothing Then Exit For
            BA.AddInterest()

        Next
    End Sub


    'Print All Accounts Btn
    Private Sub BtnPrintAccounts_Click(sender As Object, e As EventArgs) Handles BtnPrintAccounts.Click
        Dim AllAccounts As New StringBuilder()

        For Each BA As BankAccount In Me.Accounts
            If BA Is Nothing Then Exit For

            AllAccounts.Append(BA.ToString())
            AllAccounts.Append(vbCrLf)

        Next

        txtAccountsList.Text = AllAccounts.ToString()
    End Sub

    'Add Account Btn
    Private Sub BtnAddAccount_Click(sender As Object, e As EventArgs) Handles BtnAddAccount.Click
        'Housekeeping
        Dim FeedBack As String = "Account Added"
        Dim ExtraInfo As String = "Success"

        'Creates an account based on information from the form
        'throws out an error message when a set of criteria is not met
        Try
            Me.CreateAccount()

        Catch ex As Exception
            ExtraInfo = ex.Message()

            If ex.Message = "No Account Owner Has Been Entered" Then
                FeedBack = "Please enter an Account Owner."
                txtAccountOwner.Focus()

            ElseIf ex.Message = "No Account Number Has Been Entered" Then
                FeedBack = "Please enter an Account Number."
                txtAccountNo.Focus()

            ElseIf ex.Message = "No Interest Rate Has Been Entered" Then
                FeedBack = "Please enter an Interest Rate."
                TxtIntRate.Focus()

            ElseIf ex.Message = "No Balance Has Been Entered" Then
                FeedBack = "Please enter an Bank Balance."
                TxtBalance.Focus()

            ElseIf ex.Message = "No Country Has Been Entered" Then
                FeedBack = "Please enter an Country Of Origin."
                txtCOO.Focus()

            ElseIf ex.Message = "You Cannot Add a Sixth Account" Then
                FeedBack = "You have reached the maximum number of accounts."

            Else ExtraInfo = "An Error has Occured."
                FeedBack = ex.Message
            End If
        End Try

        MsgBox(FeedBack, vbOKOnly, ExtraInfo)

        'Clear textboxes
        txtAccountOwner.Clear()
        txtAccountNo.Clear()
        txtCOO.Clear()
        TxtBalance.Clear()
        TxtIntRate.Clear()

    End Sub

    'Exit Button
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

    Public Function CreateAccount()

        'Guard Clauses
        If txtAccountOwner.Text = "" Then Throw New Exception("No Account Owner Has Been Entered")
        If txtAccountNo.Text = "" Then Throw New Exception("No Account Number Has Been Entered")
        If TxtIntRate.Text = "" Then Throw New Exception("No Interest Rate Has Been Entered")
        If TxtBalance.Text = "" Then Throw New Exception("No Balance Has Been Entered")
        If txtCOO.Text = "" Then Throw New Exception("No Country Has Been Entered")
        If Me.NumAccounts > 4 Then Throw New Exception("You Cannot Add a Sixth Account")

        'Housekeeping - declares each varible and initialises them as the
        'text from the textboxs on the BankAccount.Form
        Dim AccountOwner As String = txtAccountOwner.Text
        Dim AccountNumber As String = txtAccountNo.Text
        Dim Interest As String = CDbl(TxtIntRate.Text)
        Dim Balance As String = CDbl(TxtBalance.Text)
        Dim Country As String = txtCOO.Text

        'Creates a New BankAccount
        Dim NewAccount As New BankAccount(AccountOwner, AccountNumber, Interest, Balance, Country)
        Me.Accounts(Me.NumAccounts) = NewAccount
        Me.NumAccounts += 1

        Return Nothing
    End Function

    'Methods to help with testing
    Public Function SetTestforTesting(accountowner As String, accountnumber As String, interestrate As String, bankbalance As String, countryoforigin As String)
        txtAccountOwner.Text = accountowner
        txtAccountNo.Text = accountnumber
        TxtIntRate.Text = interestrate
        TxtBalance.Text = bankbalance
        txtCOO.Text = countryoforigin

        Return Nothing
    End Function

    ' Method to Call BackAccounts
    Public Function GetAccounts() As BankAccount()
        Return Me.Accounts
    End Function

End Class