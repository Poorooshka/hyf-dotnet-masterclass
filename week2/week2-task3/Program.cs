using System;

var time = new JupiterTime(2, 20);
var timeIn1Hour = time.AddHour(-2);
PrintTime(time);

void PrintTime(JupiterTime time)
{
    Console.WriteLine($"The time is {time.Hours:00} : {time.Minutes:00}");
}
public class JupiterTime
{


    private int _hours, _minutes;
    public JupiterTime(int hours, int minutes)
    {
        _hours = hours;
        _minutes = minutes;
    }

    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            if (value < 0) throw new Exception("We can not have negative value for the hours");
            else if (value > 11)
            {
                _hours = value % 10;
            }
            else { _hours = value; }

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
            if (value < 0 || value > 59) throw new Exception("The vlue for minutes is not valid");
        }
    }

    public JupiterTime AddHour(int number)
    {
        // BONUS for larger number like 11
        int sum = number + _hours;
        if (number > 0 && sum > 10) _hours = sum % 10;
        else if (sum <= 10)
        {
            _hours = sum;
        }
        else

        // Bonus for negative numbers
        if (number < 0)
        {
            _hours = (10 + _hours + number) % 10;
        }

        return this;
    }
}

