/*using System;

class BankAccount
{
    public string accountNumber;
    protected string accountHolder;
    private double balance;

    // Constructor to initialize account details
    public BankAccount(string accountNumber, string accountHolder, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = initialBalance;
    }

    // Public method to get the current balance
    public double GetBalance()
    {
        return balance;
    }

    // Public method to modify the balance (deposit or withdrawal)
    public void ModifyBalance(double amount)
    {
        balance += amount;
    }

    // Method to display account details
    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number: {accountNumber}, Account Holder: {accountHolder}, Balance: ₹{balance}");
    }
}

// Subclass SavingsAccount to access accountNumber and accountHolder, and demonstrate access modifiers
class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountNumber, string accountHolder, double initialBalance)
        : base(accountNumber, accountHolder, initialBalance) // Call to the base class constructor
    {
    }

    // Method to display Savings Account details (accessing protected and public members)
    public void DisplaySavingsAccountDetails()
    {
        Console.WriteLine($"Savings Account - Account Number: {accountNumber}, Account Holder: {accountHolder}");
    }
}

class Program
{
    static void Main()
    {
        // Creating a BankAccount object
        BankAccount account1 = new BankAccount("1234567890", "Alice", 5000.0);
        account1.DisplayAccountDetails();

        // Modifying the balance (depositing money)
        account1.ModifyBalance(1500.0);
        Console.WriteLine($"Updated Balance: ₹{account1.GetBalance()}");

        Console.WriteLine();

        // Creating a SavingsAccount object
        SavingsAccount savingsAccount1 = new SavingsAccount("0987654321", "Bob", 10000.0);
        savingsAccount1.DisplaySavingsAccountDetails();
        savingsAccount1.DisplayAccountDetails();  // Can access the protected accountHolder and public accountNumber
    }
}
*/