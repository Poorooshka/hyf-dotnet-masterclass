var time = new JupiterTime(2, 20);
Console.WriteLine(time);


public class JupiterTime
{
    private int _hours, _minutes;

    public JupiterTime(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }
    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            if (value < 0) throw new Exception("hours can not be negative");
            _hours = value;
        }
    }
    public int Minutes
    {
        get
        {
            return _minutes;
        }
        set
        {
            if (value < 0 || value > 59) throw new Exception("Invaid minutes");
            _minutes = value;
        }
    }

    public override string ToString()
    {
        if (_minutes < 9)
            return _hours + ":0" + _minutes;
        return _hours + ":" + _minutes;
    }
}
