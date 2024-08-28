namespace Step_1_Copy_Paste;

public class Fish
{
    private bool is_injured;
    private Speed speed;

    public bool Can_Walk => false;
    public bool Can_Make_Sound => false;
    public bool Can_Swim => true;

    public Fish(Speed speed)
    {
        this.speed = speed;
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
        Console.WriteLine($"Fish is swiming {Get_Speed()}like a fish");
    }

    public void Injure()
    {
        Console.WriteLine("Fish is injured");
        is_injured = true;
        speed = Speed.Slow;
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