namespace Step_1_Copy_Paste;

public class Dog
{
    private bool is_injured;
    private Speed speed;

    public bool Can_Walk { get; private set; }
    public bool Can_Make_Sound => true;
    public bool Can_Swim { get; private set; }

    public Dog(Speed speed)
    {
        this.speed = speed;
        Can_Walk = true;
        Can_Swim = true;
    }

    public void Make_Sound()
    {
        Console.WriteLine("Dog is barking" + (is_injured ? " painfully" : string.Empty));
    }

    public void Walk()
    {
        if (Can_Walk)
            Console.WriteLine($"Dog is walking {Get_Speed()}like a dog");
        else
            Console.WriteLine("Dog cannot walk");
    }

    public void Swim()
    {
        if (Can_Swim)
            Console.WriteLine($"Dog is swiming {Get_Speed()}like a dog");
        else
            Console.WriteLine("Dog cannot swim");
    }

    public void Injure()
    {
        Console.WriteLine("Dog is injured");
        is_injured = true;
        Can_Swim = false;
        Can_Walk = false;
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