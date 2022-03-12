using System;

var time = new JupiterTime(2, 20);
PrintTime(time);

var timeIn20Minutes = time.AddMinutes(150);
PrintTime(timeIn20Minutes);

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
            else if (value >= 10)
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
            if (value < 0 || value > 59) throw new Exception("The value for minutes is not valid");
        }
    }

    public JupiterTime AddMinutes(int number)
    {
        // BONUS for larger number like 80 (assuming number is only positive)
        int sum = number + _minutes;

        if (number >= 0 && sum > 60)
        {
            _hours = _hours + (sum / 60);
            _minutes = (sum % 60);

        }
        else if (number > 0)
        {
            _minutes = sum;
        }

        return this;
    }
}