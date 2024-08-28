namespace Step_1_Copy_Paste_Approach;

public class Robot_Dog
{
    private bool is_broken;
    private bool is_recharged;
    private readonly Speed speed;

    public bool Can_Walk => true;
    public bool Can_Make_Sound => true;
    public bool Can_Swim => true;

    public Robot_Dog(Speed speed)
    {
        this.speed = speed;
    }

    public void Walk()
    {
        if (!is_recharged)
            Recharge();
        if (is_broken)
            Repair();
        Console.WriteLine($"Robot_Dog is walking {Get_Speed()}like a dog");
    }

    public void Swim()
    {
        if (!is_recharged)
            Recharge();
        if (is_broken)
            Repair();
        Console.WriteLine($"Robot_Dog is swiming {Get_Speed()}like a dog");
    }

    public void Make_Sound()
    {
        if (!is_recharged)
            Recharge();
        if (is_broken)
            Repair();
        Console.WriteLine("Robot_Dog is barking");
    }

    public void Injure()
    {
        Console.WriteLine("Robot_Dog is broken");
        is_broken = true;
    }

    private void Repair()
    {
        Console.WriteLine("Robot_Dog is repairing...");
        is_broken = false;
        Console.WriteLine("Robot_Dog is repaired");
    }

    private void Recharge()
    {
        Console.WriteLine("Robot_Dog is recharging...");
        is_recharged = true;
        Console.WriteLine("Robot_Dog is recharged");
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