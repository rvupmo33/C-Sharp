namespace AccountApp_SEC402;

public class Account
{
    private const int TRANSIT_NUMBER = 314;
    private static int nextAccountNumber;
    public readonly string Number;
    public double Balance { get; private set; }
    public List<string> Names { get; private set; } = new List<string>();
    
    static Account()
    {
        nextAccountNumber = 10_000;
    }
    
    private Account(string number, string name, double balance)
    {
        Number = number;
        Balance = balance;
        Names = new List<string>{name};
    }

    public static Account CreateAccount (string name, double balance = 500)
    {
        string accountNumber = $"[AC - {TRANSIT_NUMBER.ToString()} - {nextAccountNumber}]";
        nextAccountNumber++;
        Account newAccount = new Account(accountNumber, name, balance);
        return newAccount;
    }

    public void AddName(string name)
    {
        Names.Add(name);
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }
    
    public void Withdraw(double amount)
    {
        Balance -= amount;
    }

    public override string ToString()
    {
        string namesString = string.Join(", ", Names);
        return $"{Number} {namesString} {Balance:C}";
    }
    
}