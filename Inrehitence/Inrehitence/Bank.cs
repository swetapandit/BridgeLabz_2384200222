/*using System;

class BankAccount
{
    protected string accountNumber;
    protected double balance;

    public BankAccount(string accountNumber, double balance)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    public virtual void DisplayAccountType()
    {
        Console.WriteLine("General Bank Account");
    }
}

class SavingsAccount : BankAccount
{
    private double interestRate;

    public SavingsAccount(string accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        this.interestRate = interestRate;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("This is a Savings Account.");
    }
}

class CheckingAccount : BankAccount
{
    private double withdrawalLimit;

    public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        this.withdrawalLimit = withdrawalLimit;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("This is a Checking Account.");
    }
}

class FixedDepositAccount : BankAccount
{
    private int duration;

    public FixedDepositAccount(string accountNumber, double balance, int duration)
        : base(accountNumber, balance)
    {
        this.duration = duration;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("This is a Fixed Deposit Account.");
    }
}

class HelloWorld
{
    static void Main()
    {
        SavingsAccount savings = new SavingsAccount("SAV123", 5000, 5);
        CheckingAccount checking = new CheckingAccount("CHK456", 3000, 1000);
        FixedDepositAccount fixedDeposit = new FixedDepositAccount("FD789", 10000, 12);

        savings.DisplayAccountType();
        checking.DisplayAccountType();
        fixedDeposit.DisplayAccountType();
        Console.ReadLine();
    }
}*/