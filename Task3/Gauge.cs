namespace Task3;

public class Gauge
{
    public int Value {get; set;}
    public Gauge(){}
    public Gauge(int value = 0)
    {
        Value = value;
    }
    public void Enhance()
    {
        if(Value < 6)
        {
            Value++;
        }
        else
        {
            System.Console.WriteLine("I can't");
        }

    }
    public void Decrease()
    {
        if(Value > 0)
        {
            Value --;
        }
    }
    public bool Full()
    {
        if(Value == 5)
        {
            return true;
        }
        return false;
    }
}
