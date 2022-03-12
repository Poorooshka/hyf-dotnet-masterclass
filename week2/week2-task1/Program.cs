using System;

var time = new JupiterTime(8, 40);

void PrintTime(JupiterTime time)
{
    Console.WriteLine($"It is {time.Hours:00}: {time.Minutes:00} ");
}

PrintTime(time);

public class JupiterTime
{
    //instance variables
    private int _hours, _minutes;

    //constructor
    public JupiterTime(int hours, int minutes)
    {
        _hours = hours;
        _minutes = minutes;
    }

    //get and set methods
    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            if (value < 0) throw new Exception("Hours can not be a negative number");
            else
            {
                _hours = value;
            }
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
            if (value > 60) throw new Exception("invalid value ");
            _minutes = value;
        }
    }
}