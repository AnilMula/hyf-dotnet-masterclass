var time = new JupiterTime(14, 88);
try
{
    Console.WriteLine(time);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
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

    public override string ToString()
    {
        if (_minutes < 9)
            return _hours + ":0" + _minutes;
        return _hours + ":" + _minutes;
    }
}

