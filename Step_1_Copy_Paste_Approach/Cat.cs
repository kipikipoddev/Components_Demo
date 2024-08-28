namespace Step_1_Copy_Paste_Approach;

public class Cat
{
    private bool is_injured;
    private Speed speed;

    public bool Can_Walk => true;
    public bool Can_Make_Sound => true;
    public bool Can_Swim => false;

    public Cat(Speed speed)
    {
        this.speed = speed;
    }

    public void Make_Sound()
    {
        Console.WriteLine("Cat is meowing" + (is_injured ? " painfully" : string.Empty));
    }

    public void Walk()
    {
        Console.WriteLine($"Cat is walking {Get_Speed()}like a cat");
    }

    public void Swim()
    {
        Console.WriteLine("Cat cannot swim");
    }

    public void Injure()
    {
        Console.WriteLine("Cat is injured");
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