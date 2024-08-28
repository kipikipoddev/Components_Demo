namespace Step_1_Copy_Paste_Approach;

public class Cat
{
    public void Make_Sound()
    {
        Console.WriteLine("Cat is meowing");
    }

    public void Walk(Speed speed)
    {
        Console.WriteLine($"Cat is walking {Get_Speed(speed)}like a cat");
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