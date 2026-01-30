using System.Xml.Serialization;

namespace Task4;

public class Counter
{
    public int StartValue {get; set;}
    public Counter(int startValue)
    {
        StartValue = startValue;
    }
    public void Increase()
    {
        StartValue++;
    }
    public void Decrease()
    {
        StartValue--;
    }
    public void Increase(int increaseBy)
    {
        if(increaseBy > 0)
        {
            StartValue +=increaseBy;
        }
        else
        {
            System.Console.WriteLine("I can't");
        }
    }
    public void Decrease(int decreaseBy)
    {
        if(decreaseBy > 0)
        {
            StartValue -= decreaseBy;
        }
    }
}
