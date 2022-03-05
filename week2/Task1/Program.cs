var time = new JupiterTime();
try
{
    time.Hours = 0;
    time.Minutes = 4;
    PrintTime(time);
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
            if (value < 0 || value >= 60) throw new Exception("Invaid minutes");
            _minutes = value;
        }
    }
}