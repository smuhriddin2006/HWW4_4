using Task4;

Counter counter = new(0);
counter.Increase();
counter.Increase(2);
counter.Decrease();
counter.Decrease(1);
System.Console.WriteLine(counter.StartValue);