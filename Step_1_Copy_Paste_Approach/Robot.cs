namespace Step_1_Copy_Paste_Approach;

public class Robot
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
        Console.WriteLine("Robot Recharging");
        is_charged = true;
        Console.WriteLine("Robot Recharged");
    }

    public void Walk()
    {
        if (!is_charged)
            Recharge();
        Console.WriteLine("Robot Walking like a robot");
    }
}