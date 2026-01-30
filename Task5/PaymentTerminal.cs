namespace Task5;

public class PaymentTerminal
{
   decimal _cashRegister;
   public void CashPayment(decimal cash)
   {
        _cashRegister += cash;
   } 
   public void CardPayment(PaymentCard card, decimal price)
    {
        card.TakeMoney(price);
    }


}
