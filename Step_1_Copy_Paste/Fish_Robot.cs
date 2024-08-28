namespace Step_1_Copy_Paste;

public class Fish_Robot
{
    private bool is_broken;
    private bool is_recharged;
    private readonly Speed speed;

    public bool Can_Walk => false;
    public bool Can_Make_Sound => true;
    public bool Can_Swim => true;

    public Fish_Robot(Speed speed)
    {
        this.speed = speed;
    }

    public void Walk()
    {
        Console.WriteLine("Fish_Robot cannot walk");
    }

    public void Make_Sound()
    {
        Console.WriteLine("Fish_Robot is beeping");
    }

    public void Swim()
    {
        if (!is_recharged)
            Recharge();
        if (is_broken)
            Repair();
        Console.WriteLine($"Fish_Robot is swiming {Get_Speed()}like a fish");
    }

    public void Injure()
    {
        Console.WriteLine("Fish_Robot is broken");
        is_broken = true;
    }

    private void Repair()
    {
        Console.WriteLine("Fish_Robot is repairing...");
        is_broken = false;
        Console.WriteLine("Fish_Robot is repaired");
    }

    private void Recharge()
    {
        Console.WriteLine("Fish_Robot is recharging...");
        is_recharged = true;
        Console.WriteLine("Fish_Robot is recharged");
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