using Task3;

Gauge gauge = new();
gauge.Enhance();
gauge.Decrease();
System.Console.WriteLine(gauge.Full());
System.Console.WriteLine(gauge.Value);