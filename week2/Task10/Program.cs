
var now = new JupiterTime().SetTime(1, 30);
Console.WriteLine(now);
JupiterTime later = now.AddHours(1);
Console.WriteLine(later);
public abstract class AlienTime<T>
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    /// What type should be here?
    public T SetTime(int hours, int minutes)
    {
        return Create(hours, minutes);
    }
    public T AddHours(int hours)
    {
        return Create(Hours + hours, Minutes);
    }

    protected abstract T Create(int hours, int minutes);
}
public class JupiterTime : AlienTime<JupiterTime>
{
    protected override JupiterTime Create(int hours, int minutes)
    {
        return new JupiterTime { Hours = hours, Minutes = minutes };
    }

    public override String ToString()
    {
        return Hours + ":" + Minutes;
    }
}