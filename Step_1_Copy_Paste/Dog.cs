namespace Step_1_Copy_Paste;

public class Dog
{
    private bool is_injured;
    private Speed speed;

    public bool Can_Walk => true;
    public bool Can_Make_Sound => true;
    public bool Can_Swim => true;

    public Dog(Speed speed)
    {
        this.speed = speed;
    }

    public void Make_Sound()
    {
        Console.WriteLine("Dog is barking" + (is_injured ? " painfully" : string.Empty));
    }

    public void Walk()
    {
        Console.WriteLine($"Dog is walking {Get_Speed()}like a dog");
    }

    public void Swim()
    {
        Console.WriteLine($"Dog is swiming {Get_Speed()}like a dog");
    }

    public void Injure()
    {
        Console.WriteLine("Dog is injured");
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