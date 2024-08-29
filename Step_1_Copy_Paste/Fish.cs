namespace Step_1_Copy_Paste;

public class Fish
{
    private Speed speed;

    public bool Can_Walk => false;
    public bool Can_Make_Sound => false;
    public bool Can_Swim { get; private set; }

    public Fish(Speed speed)
    {
        this.speed = speed;
        Can_Swim = true;
    }

    public void Walk()
    {
        Console.WriteLine("Fish cannot walk");
    }

    public void Make_Sound()
    {
        Console.WriteLine("Fish cannot make sound");
    }

    public void Swim()
    {
        if (Can_Swim)
            Console.WriteLine($"Fish is swiming {Get_Speed()}like a fish");
        else
            Console.WriteLine("Fish cannot swim");
    }

    public void Injure()
    {
        Console.WriteLine("Fish is injured");
        Can_Swim = false;
    }

    private string Get_Speed()
    {
        if (speed == Speed.Slow)
            return "slowly ";
        if (speed == Speed.Fast)
            return "fast ";
        return string.Empty;
    }
}