var time = new JupiterTime(2,20);
try
{
    var timeIn2Hours = time.AddHours(-3);
    PrintTime(timeIn2Hours);   
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

void PrintTime(JupiterTime jt)
{
    if(jt.Minutes < 9)
        Console.WriteLine($"{jt.Hours}:0{jt.Minutes}");
    else
        Console.WriteLine($"{jt.Hours}:{jt.Minutes}");
}
public class JupiterTime
{   
    private int _hours, _minutes;

    public JupiterTime( int hours, int minutes)    
    { 
        Hours = hours;
        Minutes = minutes;
    }
    public int Hours { 
        get
        {
            return _hours;
         } 
        set
        {
            if(value < 0) throw new Exception("hours can not be negative");
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
            if(value < 0) throw new Exception("Invaid minutes");
            else if (value > 59)
            {
                _minutes = value % 60;
                _hours = _hours + value / 60;
                if( _hours > 10 )
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
        if( num > 0 && num + _hours > 10) // BONUS for larger number like 11
            _hours = (num + _hours) % 10 ;
        else if (num >= 0)
            _hours = _hours + num;
        else                              // Bonus for negative numbers
            _hours = 10 + _hours + num % 10;
        return this;
    }
}