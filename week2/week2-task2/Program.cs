// Task2: A simple tracker---task 2 is in fact task 1 :D

var time = new JupiterTime();
time.Hours = 8;
time.Minutes = 40;

void PrintTime(JupiterTime time)
{
    Console.WriteLine($"It is {time.Hours:00}: {time.Minutes:00}");
}

PrintTime(time);

public class JupiterTime
{
    private int _hours, _minutes;

    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            if (value < 0) throw new Exception("The number of hours can not be negative");
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
            if (value > 60) throw new Exception("minutes can not be bigger than 60");
            _minutes = value;
        }
    }

}
