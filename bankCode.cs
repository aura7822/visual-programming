using System;

public class BankAccount
{
    
    private decimal balance;
    
    public string AccountName { get; set; }
    public string AccountNumber { get; set; }

    // Const init
    public BankAccount(string name, string number, decimal initialBalance)
    {
        AccountName = name;
        AccountNumber = number;
        balance = initialBalance;
    }

    
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Cannot deposit negative or zero amount!");
            return;
        }

        balance += amount;
        Console.WriteLine($"Deposited: ${amount}, New Balance: ${balance}");
    }

    
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Cannot withdraw negative or zero amount!");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine($"Insufficient funds! Available balance: ${balance}");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Withdrew: ${amount}, New Balance: ${balance}");
    }

    
    public string GetAccountSummary()
    {
        return $"Account: {AccountName}, Number: {AccountNumber}, Balance: ${balance}";
    }

    
    public decimal GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
        
        BankAccount account = new BankAccount("Aura .j", "ACC1456783", 1000);
        Console.WriteLine("Your account has successfully been created");
        Console.WriteLine(account.GetAccountSummary());
        Console.WriteLine();

        
        Console.WriteLine("===== Simulating 5 Transactions====");

        // Transaction 1:   
        account.Deposit(500);

        // Transaction 2: Withdraw 200
        account.Withdraw(200);

        // Transaction 3: Try to withdraw too much
        account.Withdraw(2000);

        // Transaction 4: Try to deposit negative 
        account.Deposit(-50);

        // Transaction 5: Withdraw 300
        account.Withdraw(300);

        Console.WriteLine();
        Console.WriteLine("====Final Account Status=====");
        Console.WriteLine(account.GetAccountSummary());
    }
}