namespace Step_1_Copy_Paste_Approach;

public class Fish
{
    public void Swim(Speed speed = Speed.Normal)
    {
        Console.WriteLine($"Fish is swiming {Get_Speed(speed)}like a fish");
    }


    private string Get_Speed(Speed speed)
    {
        if (speed == Speed.Slow)
            return "slowly ";
        if (speed == Speed.Fast)
            return "Fast ";
        return string.Empty;
    }
}