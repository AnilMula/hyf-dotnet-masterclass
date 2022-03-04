var titanTime = new TitanTime(11, 11);

Console.WriteLine(titanTime);
public class TitanTime 
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public TitanTime( int hours, int minutes)
    {
        if( hours < 0 || minutes < 0) throw new Exception(" hours or minutes is invalid");

        Hours = hours % 900;
        Minutes = minutes % 60;
        if ( minutes > 60)
        {
            Hours = Hours + minutes / 60;
        }
    }

    public override string ToString()
    {
        if(Minutes < 10)
        {
            if(Hours < 10) return "00"+Hours+":0"+Minutes;
            else if(Hours < 100) return "0"+Hours+":0"+Minutes;
            else return Hours+":0"+Minutes;
        }
        else
        {
            if(Hours < 10) return "00"+Hours+":"+Minutes;
            else if(Hours < 100) return "0"+Hours+":"+Minutes;
            else return Hours+":"+Minutes;
        }
    }
}