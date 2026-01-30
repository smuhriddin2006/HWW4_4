using Task5;

PaymentCard paymentCard1 = new();
paymentCard1.Deposit(100);
paymentCard1.ShowBalance();
paymentCard1.TakeMoney(50);
paymentCard1.ShowBalance();
PaymentTerminal paymentTerminal1 = new();
paymentTerminal1.CardPayment(paymentCard1,123);
