var time = new JupiterTime(1, 21);
try
{
    var timeIn20Minutes = time.AddMinutes(-21);
    PrintTime(timeIn20Minutes);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

void PrintTime(JupiterTime jt)
{
    Console.WriteLine($"{jt.Hours:00}:{jt.Minutes:00}");
}
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
            if (value < 0) throw new Exception("Invaid minutes");
            else if (value > 59)
            {
                _minutes = value % 60;
                _hours = _hours + value / 60;
                if (_hours > 10)
                {
                    _hours = _hours % 10;
                }
            }
            else
                _minutes = value;
        }
    }

    public JupiterTime AddHours(int num)
    {
        if (num > 0 && num + _hours > 10) // BONUS for larger number like 11
            _hours = (num + _hours) % 10;
        else if (num >= 0)
            _hours = _hours + num;
        else                              // Bonus for negative numbers
            _hours = 10 + _hours + num % 10;
        return this;
    }
    public JupiterTime AddMinutes(int num)
    {
        if (num > 0 && num + _minutes > 59) // BONUS for larger number like 80
        {
            _hours = _hours + num / 60;
            _minutes = (_minutes + num % 60) % 60;
        }
        else if (num >= 0)
            _minutes = _minutes + num;
        else                              // Bonus for negative numbers
        {
            if (_minutes - num > 59)
            {
                _hours = _hours + num / 60;
                _minutes = (_minutes + num % 60) % 60;
                Console.WriteLine($"{_hours},{_minutes}");
            }
            else
            {
                _minutes = _minutes + num;
            }
        }
        return this;
    }
}