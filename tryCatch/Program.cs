class BankAccount
{
    public int AccountNumber
    {
        get; set;
    }
    public decimal Balance
    {
        get; set;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (Balance - amount >= 0)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }
}

class Bank
{
    private Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
    private int nextAccountNumber = 1;

    public int CreateAccount()
    {
        var account = new BankAccount { AccountNumber = nextAccountNumber };
        accounts.Add(nextAccountNumber, account);
        nextAccountNumber++;
        return account.AccountNumber;
    }

    public BankAccount GetAccount(int accountNumber)
    {
        accounts.TryGetValue(accountNumber, out var account);
        return account;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var bank = new Bank();

        int accountNumber1 = bank.CreateAccount();
        int accountNumber2 = bank.CreateAccount();

        var account1 = bank.GetAccount(accountNumber1);
        var account2 = bank.GetAccount(accountNumber2);

        account1.Deposit(500);
        account2.Deposit(300);

        Console.WriteLine($"Account {accountNumber1} balance: {account1.Balance}");
        Console.WriteLine($"Account {accountNumber2} balance: {account2.Balance}");

        account1.Withdraw(200);
        account2.Withdraw(100);

        Console.WriteLine($"Account {accountNumber1} balance: {account1.Balance}");
        Console.WriteLine($"Account {accountNumber2} balance: {account2.Balance}");

        account1.Withdraw(400); // Insufficient funds
    }
}
