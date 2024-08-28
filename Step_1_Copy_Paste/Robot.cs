namespace Step_1_Copy_Paste;

public class Robot
{
    private bool is_broken;
    private bool is_recharged;
    private readonly Speed speed;

    public bool Can_Walk => true;
    public bool Can_Make_Sound => true;
    public bool Can_Swim => false;

    public Robot(Speed speed)
    {
        this.speed = speed;
    }

    public void Make_Sound()
    {
        if (!is_recharged)
            Recharge();
        if (is_broken)
            Repair();
        Console.WriteLine("Robot is beeping");
    }

    public void Walk()
    {
        if (!is_recharged)
            Recharge();
        if (is_broken)
            Repair();
        Console.WriteLine($"Robot is walking {Get_Speed()}like a robot");
    }

    public void Swim()
    {
        Console.WriteLine("Robot cannot swim");
    }

    public void Injure()
    {
        Console.WriteLine("Robot is broken");
        is_broken = true;
    }

    private void Repair()
    {
        Console.WriteLine("Robot is repairing...");
        is_broken = false;
        Console.WriteLine("Robot is repaired");
    }

    private void Recharge()
    {
        Console.WriteLine("Robot is recharging...");
        is_recharged = true;
        Console.WriteLine("Robot is recharged");
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