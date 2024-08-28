namespace Step_1_Copy_Paste_Approach;

public class Dog
{
    public void Make_Sound()
    {
        Console.WriteLine("Dog is barking");
    }

    public void Walk(Speed speed = Speed.Normal)
    {
        Console.WriteLine($"Dog is walking {Get_Speed(speed)}like a dog");
    }

    public void Swim(Speed speed = Speed.Normal)
    {
        Console.WriteLine($"Dog is swiming {Get_Speed(speed)}like a dog");
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