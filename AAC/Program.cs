/*using System;
using System.Collections.Generic;

// Bank class
class Bank
{
    public string name;
    private List<Customer> customers = new List<Customer>();

    public Bank(string bankName)
    {
        name = bankName;
    }

    public void OpenAccount(string customerName, int accountNumber, double initialBalance)
    {
        Customer customer = FindCustomer(customerName);
        if (customer == null)
        {
            customer = new Customer(customerName, this);
            customers.Add(customer);
        }
        customer.AddAccount(accountNumber, initialBalance);
        Console.WriteLine("Account " + accountNumber + " opened for " + customerName + " in " + name + " Bank.");
    }

    private Customer FindCustomer(string customerName)
    {
        foreach (var c in customers)
        {
            if (c.name == customerName)
                return c;
        }
        return null;
    }

    public void ShowCustomers()
    {
        Console.WriteLine("Customers of " + name + " Bank:");
        foreach (var customer in customers)
        {
            Console.WriteLine("- " + customer.name);
        }
    }
}

// Customer class
class Customer
{
    public string name;
    private Bank bank;
    private List<BankAccount> accounts = new List<BankAccount>();

    public Customer(string customerName, Bank customerBank)
    {
        name = customerName;
        bank = customerBank;
    }

    public void AddAccount(int accountNumber, double initialBalance)
    {
        BankAccount newAccount = new BankAccount(accountNumber, initialBalance);
        accounts.Add(newAccount);
    }

    public void ViewBalance(int accountNumber)
    {
        foreach (var account in accounts)
        {
            if (account.accountNumber == accountNumber)
            {
                Console.WriteLine("Balance in account " + accountNumber + ": " + account.balance);
                return;
            }
        }
        Console.WriteLine("Account not found.");
    }
}

// BankAccount class
class BankAccount
{
    public int accountNumber;
    public double balance;

    public BankAccount(int accNumber, double initialBalance)
    {
        accountNumber = accNumber;
        balance = initialBalance;
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Bank myBank = new Bank("National Bank");

        myBank.OpenAccount("Alice", 101, 5000);
        myBank.OpenAccount("Bob", 102, 3000);
        myBank.OpenAccount("Alice", 103, 7000); // Alice opens another account

        myBank.ShowCustomers();

        Customer alice = new Customer("Alice", myBank);
        alice.ViewBalance(101); // Checking balance for Alice

        Console.ReadLine();
    }
}
*/