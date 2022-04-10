var jt = new JupiterTime(5, 55);

Console.WriteLine(jt);

var tt = new TitanTime(955, 55);

Console.WriteLine(tt);

var gt = new GanymedeTime(55, 55);

Console.WriteLine(gt);
public abstract class AlienTime
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    private int HoursInDay;
    public AlienTime(int hours, int minutes, int hoursInDay)
    {
        if (hours > hoursInDay || minutes > 59) throw new Exception("Invalid hours or minutes");
        Hours = hours;
        Minutes = minutes;
        HoursInDay = hoursInDay;
    }
    public override string ToString()
    {

        if (Minutes < 10)
        {
            if (HoursInDay < 100)
            {
                if (Hours < 10) return "0" + Hours + ":0" + Minutes;
                else return Hours + ":0" + Minutes;
            }
            else if (HoursInDay < 1000)
            {
                if (Hours < 10) return "00" + Hours + ":0" + Minutes;
                else if (Hours < 100) return "0" + Hours + ":0" + Minutes;
                else return Hours + ":0" + Minutes;
            }
        }
        else
        {
            if (HoursInDay < 100)
            {
                if (Hours < 10) return "0" + Hours + ":" + Minutes;
                else return Hours + ":" + Minutes;
            }
            else if (HoursInDay < 1000)
            {
                if (Hours < 10) return "00" + Hours + ":" + Minutes;
                else if (Hours < 100) return "0" + Hours + ":" + Minutes;
                else return Hours + ":" + Minutes;
            }
        }
        return "No output";
    }
}
public class JupiterTime : AlienTime
{
    public JupiterTime(int hours, int minutes)
        : base(hours, minutes, 10)
    {

    }
}
public class TitanTime : AlienTime
{
    public TitanTime(int hours, int minutes)
        : base(hours, minutes, 900)
    { }
}
public class GanymedeTime : AlienTime
{
    public GanymedeTime(int hours, int minutes)
        : base(hours, minutes, 171)
    { }
}