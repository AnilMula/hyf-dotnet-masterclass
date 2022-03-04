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
    if(jt.Minutes < 9)
        Console.WriteLine($"{jt.Hours}:0{jt.Minutes}");
    else
        Console.WriteLine($"{jt.Hours}:{jt.Minutes}");
}
public class JupiterTime
{   
    private int _hours, _minutes;
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
            if(value < 0 || value > 60) throw new Exception("Invaid minutes");
            _minutes = value;
        } 
    }
}