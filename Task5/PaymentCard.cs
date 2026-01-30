namespace Task5;

public class PaymentCard
{
    decimal _balance;
    public void ShowBalance()
    {
        System.Console.WriteLine($"Balance: {_balance}");
    }
    public void Deposit(decimal amount)
    {
        if(amount > 0)
        {
            _balance += amount;
        }
    }
    public void TakeMoney(decimal amount)
    {
        if(amount <= _balance)
        {
            _balance -= amount;
        }
    }
    
}
