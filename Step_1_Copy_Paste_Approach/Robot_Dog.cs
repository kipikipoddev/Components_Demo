namespace Step_1_Copy_Paste_Approach;

public class Robot_Dog
{
    private bool is_charged;

    public void Beep()
    {
        if (!is_charged)
            Recharge();
        Console.WriteLine("Robot Beeping");
    }

    public void Recharge()
    {
        Console.WriteLine("Robot Dog Recharging");
        is_charged = true;
        Console.WriteLine("Robot Dog Recharged");
    }

    public void Walk()
    {
        if (!is_charged)
            Recharge();
        Console.WriteLine("Robot Dog Walking like a robot");
    }

    public void Bark()
    {
        if (!is_charged)
            Recharge();
        Console.WriteLine("Robot Dog Barking");
    }
}