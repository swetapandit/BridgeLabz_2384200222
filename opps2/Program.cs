/*using System;

class BankAccount
{
    // Static variable (Shared across all instances)
    private static string bankName = "National Bank";
    private static int totalAccounts = 0;

    // Readonly variable (Cannot be changed after initialization)
    private readonly int accountNumber;

    // Private instance variables
    private string accountHolderName;
    private double balance;

    // Constructor
    public BankAccount(int accountNumber, string accountHolderName, double initialBalance)
    {
        this.accountNumber = accountNumber;
        SetAccountHolderName(accountHolderName);
        SetBalance(initialBalance);

        totalAccounts++; // Increment account count
    }

    // ----------- User-Defined Getter & Setter Methods -----------

    public static string GetBankName()
    {
        return bankName;
    }
    public static void SetBankName(string newName)
    {
        if (!string.IsNullOrEmpty(newName))
            bankName = newName;
    }

    public static int GetTotalAccounts()
    {
        return totalAccounts;
    }

    public int GetAccountNumber()
    {
        return accountNumber;
    }

    public string GetAccountHolderName()
    {
        return accountHolderName;
    }
    public void SetAccountHolderName(string name)
    {
        if (!string.IsNullOrWhiteSpace(name))
            accountHolderName = name;
        else
            Console.WriteLine("Invalid Name!");
    }

    public double GetBalance()
    {
       return balance;
    }
    public void SetBalance(double amount)
    {
        if (amount >= 0)
            balance = amount;
        else
            Console.WriteLine("Balance cannot be negative!");
    }

    // ----------- Transaction Methods -----------

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"₹{amount} deposited successfully!");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount!");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"₹{amount} withdrawn successfully!");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount!");
        }
    }

    public void DisplayAccountDetails()
    {
        if (this is BankAccount) // Ensuring it's a valid account object
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"Bank: {GetBankName()}");
            Console.WriteLine($"Account Holder: {GetAccountHolderName()}");
            Console.WriteLine($"Account Number: {GetAccountNumber()}");
            Console.WriteLine($"Balance: ₹{GetBalance()}");
            Console.WriteLine("---------------------------\n");
        }
        else Console.WriteLine("Invalid Account!");
    }
}

// --------------------------- Main Program ---------------------------
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Bank System!");

        // Taking user input for account creation
        Console.Write("\nEnter Account Number: ");
        int accNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Account Holder Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Initial Balance: ₹");
        double balance = Convert.ToDouble(Console.ReadLine());

        // Creating account
        BankAccount userAccount = new BankAccount(accNum, name, balance);

        // Interactive Menu Loop
        while (true)
        {
            Console.WriteLine("\n------ BANK MENU ------");
            Console.WriteLine("1. Deposit Money");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. View Account Details");
            Console.WriteLine("5. Change Bank Name");
            Console.WriteLine("6. View Total Accounts");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter deposit amount: ₹");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    userAccount.Deposit(depositAmount);
                    break;

                case 2:
                    Console.Write("Enter withdrawal amount: ₹");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    userAccount.Withdraw(withdrawAmount);
                    break;

                case 3:
                    Console.WriteLine($"\nCurrent Balance: ₹{userAccount.GetBalance()}\n");
                    break;

                case 4:
                    userAccount.DisplayAccountDetails();
                    break;

                case 5:
                    Console.Write("Enter new bank name: ");
                    string newBankName = Console.ReadLine();
                    BankAccount.SetBankName(newBankName);
                    Console.WriteLine($"Bank name changed successfully to {BankAccount.GetBankName()}");
                    break;

                case 6:
                    Console.WriteLine($"\nTotal Bank Accounts: {BankAccount.GetTotalAccounts()}\n");
                    break;

                case 7:
                    Console.WriteLine("Thank you for using the Bank System. Goodbye!");
                    return; // Exit the program

                default:
                    Console.WriteLine("Invalid option! Please try again.");
                    break;
            }
        }
    }
}
*/