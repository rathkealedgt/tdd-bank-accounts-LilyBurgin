<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankAccountsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.txtAccountOwner = New System.Windows.Forms.TextBox()
        Me.AccountO = New System.Windows.Forms.Label()
        Me.COO = New System.Windows.Forms.Label()
        Me.txtCOO = New System.Windows.Forms.TextBox()
        Me.AccountNumber = New System.Windows.Forms.Label()
        Me.txtAccountNo = New System.Windows.Forms.TextBox()
        Me.Balance = New System.Windows.Forms.Label()
        Me.TxtBalance = New System.Windows.Forms.TextBox()
        Me.InterestRate = New System.Windows.Forms.Label()
        Me.TxtIntRate = New System.Windows.Forms.TextBox()
        Me.BtnAddAccount = New System.Windows.Forms.Button()
        Me.BtnPrintAccounts = New System.Windows.Forms.Button()
        Me.BtnDepositOrWithdrawl = New System.Windows.Forms.Button()
        Me.BtnInterestRate = New System.Windows.Forms.Button()
        Me.AccountsList = New System.Windows.Forms.Label()
        Me.txtAccountsList = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.AccessibleName = ""
        Me.BtnExit.Location = New System.Drawing.Point(812, 842)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(120, 48)
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'txtAccountOwner
        '
        Me.txtAccountOwner.Location = New System.Drawing.Point(33, 83)
        Me.txtAccountOwner.Name = "txtAccountOwner"
        Me.txtAccountOwner.Size = New System.Drawing.Size(305, 31)
        Me.txtAccountOwner.TabIndex = 1
        '
        'AccountO
        '
        Me.AccountO.AutoSize = True
        Me.AccountO.Location = New System.Drawing.Point(48, 39)
        Me.AccountO.Name = "AccountO"
        Me.AccountO.Size = New System.Drawing.Size(226, 25)
        Me.AccountO.TabIndex = 2
        Me.AccountO.Text = "Account Owner Name:"
        '
        'COO
        '
        Me.COO.AutoSize = True
        Me.COO.Location = New System.Drawing.Point(48, 154)
        Me.COO.Name = "COO"
        Me.COO.Size = New System.Drawing.Size(178, 25)
        Me.COO.TabIndex = 3
        Me.COO.Text = "Country Of Origin"
        '
        'txtCOO
        '
        Me.txtCOO.Location = New System.Drawing.Point(33, 191)
        Me.txtCOO.Name = "txtCOO"
        Me.txtCOO.Size = New System.Drawing.Size(285, 31)
        Me.txtCOO.TabIndex = 4
        '
        'AccountNumber
        '
        Me.AccountNumber.AutoSize = True
        Me.AccountNumber.Location = New System.Drawing.Point(49, 298)
        Me.AccountNumber.Name = "AccountNumber"
        Me.AccountNumber.Size = New System.Drawing.Size(177, 25)
        Me.AccountNumber.TabIndex = 5
        Me.AccountNumber.Text = "Account Number:"
        '
        'txtAccountNo
        '
        Me.txtAccountNo.Location = New System.Drawing.Point(33, 341)
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.Size = New System.Drawing.Size(301, 31)
        Me.txtAccountNo.TabIndex = 6
        '
        'Balance
        '
        Me.Balance.AutoSize = True
        Me.Balance.Location = New System.Drawing.Point(40, 436)
        Me.Balance.Name = "Balance"
        Me.Balance.Size = New System.Drawing.Size(90, 25)
        Me.Balance.TabIndex = 7
        Me.Balance.Text = "Balance"
        '
        'TxtBalance
        '
        Me.TxtBalance.Location = New System.Drawing.Point(33, 476)
        Me.TxtBalance.Name = "TxtBalance"
        Me.TxtBalance.Size = New System.Drawing.Size(320, 31)
        Me.TxtBalance.TabIndex = 8
        '
        'InterestRate
        '
        Me.InterestRate.AutoSize = True
        Me.InterestRate.Location = New System.Drawing.Point(93, 533)
        Me.InterestRate.Name = "InterestRate"
        Me.InterestRate.Size = New System.Drawing.Size(140, 25)
        Me.InterestRate.TabIndex = 9
        Me.InterestRate.Text = "Interest Rate:"
        '
        'TxtIntRate
        '
        Me.TxtIntRate.Location = New System.Drawing.Point(239, 530)
        Me.TxtIntRate.Name = "TxtIntRate"
        Me.TxtIntRate.Size = New System.Drawing.Size(99, 31)
        Me.TxtIntRate.TabIndex = 10
        '
        'BtnAddAccount
        '
        Me.BtnAddAccount.Location = New System.Drawing.Point(570, 791)
        Me.BtnAddAccount.Name = "BtnAddAccount"
        Me.BtnAddAccount.Size = New System.Drawing.Size(155, 90)
        Me.BtnAddAccount.TabIndex = 11
        Me.BtnAddAccount.Text = "Add Account"
        Me.BtnAddAccount.UseVisualStyleBackColor = True
        '
        'BtnPrintAccounts
        '
        Me.BtnPrintAccounts.Location = New System.Drawing.Point(397, 791)
        Me.BtnPrintAccounts.Name = "BtnPrintAccounts"
        Me.BtnPrintAccounts.Size = New System.Drawing.Size(151, 90)
        Me.BtnPrintAccounts.TabIndex = 12
        Me.BtnPrintAccounts.Text = "Print Accounts"
        Me.BtnPrintAccounts.UseVisualStyleBackColor = True
        '
        'BtnDepositOrWithdrawl
        '
        Me.BtnDepositOrWithdrawl.Location = New System.Drawing.Point(12, 791)
        Me.BtnDepositOrWithdrawl.Name = "BtnDepositOrWithdrawl"
        Me.BtnDepositOrWithdrawl.Size = New System.Drawing.Size(170, 90)
        Me.BtnDepositOrWithdrawl.TabIndex = 14
        Me.BtnDepositOrWithdrawl.Text = "Deposit Or Withdrawl"
        Me.BtnDepositOrWithdrawl.UseVisualStyleBackColor = True
        '
        'BtnInterestRate
        '
        Me.BtnInterestRate.Location = New System.Drawing.Point(203, 791)
        Me.BtnInterestRate.Name = "BtnInterestRate"
        Me.BtnInterestRate.Size = New System.Drawing.Size(172, 90)
        Me.BtnInterestRate.TabIndex = 15
        Me.BtnInterestRate.Text = "Add Interest Rate"
        Me.BtnInterestRate.UseVisualStyleBackColor = True
        '
        'AccountsList
        '
        Me.AccountsList.AutoSize = True
        Me.AccountsList.Location = New System.Drawing.Point(547, 39)
        Me.AccountsList.Name = "AccountsList"
        Me.AccountsList.Size = New System.Drawing.Size(141, 25)
        Me.AccountsList.TabIndex = 16
        Me.AccountsList.Text = "Accounts List"
        '
        'txtAccountsList
        '
        Me.txtAccountsList.Location = New System.Drawing.Point(529, 83)
        Me.txtAccountsList.Multiline = True
        Me.txtAccountsList.Name = "txtAccountsList"
        Me.txtAccountsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAccountsList.Size = New System.Drawing.Size(403, 588)
        Me.txtAccountsList.TabIndex = 17
        '
        'BankAccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 902)
        Me.Controls.Add(Me.txtAccountsList)
        Me.Controls.Add(Me.AccountsList)
        Me.Controls.Add(Me.BtnInterestRate)
        Me.Controls.Add(Me.BtnDepositOrWithdrawl)
        Me.Controls.Add(Me.BtnPrintAccounts)
        Me.Controls.Add(Me.BtnAddAccount)
        Me.Controls.Add(Me.TxtIntRate)
        Me.Controls.Add(Me.InterestRate)
        Me.Controls.Add(Me.TxtBalance)
        Me.Controls.Add(Me.Balance)
        Me.Controls.Add(Me.txtAccountNo)
        Me.Controls.Add(Me.AccountNumber)
        Me.Controls.Add(Me.txtCOO)
        Me.Controls.Add(Me.COO)
        Me.Controls.Add(Me.AccountO)
        Me.Controls.Add(Me.txtAccountOwner)
        Me.Controls.Add(Me.BtnExit)
        Me.Name = "BankAccountsForm"
        Me.Text = "BankAccountsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExit As Windows.Forms.Button
    Friend WithEvents txtAccountOwner As Windows.Forms.TextBox
    Friend WithEvents AccountO As Windows.Forms.Label
    Friend WithEvents COO As Windows.Forms.Label
    Friend WithEvents txtCOO As Windows.Forms.TextBox
    Friend WithEvents AccountNumber As Windows.Forms.Label
    Friend WithEvents txtAccountNo As Windows.Forms.TextBox
    Friend WithEvents Balance As Windows.Forms.Label
    Friend WithEvents TxtBalance As Windows.Forms.TextBox
    Friend WithEvents InterestRate As Windows.Forms.Label
    Friend WithEvents TxtIntRate As Windows.Forms.TextBox
    Friend WithEvents BtnAddAccount As Windows.Forms.Button
    Friend WithEvents BtnPrintAccounts As Windows.Forms.Button
    Friend WithEvents BtnDepositOrWithdrawl As Windows.Forms.Button
    Friend WithEvents BtnInterestRate As Windows.Forms.Button
    Friend WithEvents AccountsList As Windows.Forms.Label
    Friend WithEvents txtAccountsList As Windows.Forms.TextBox
End Class
