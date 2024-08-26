namespace Step_1_Copy_Paste_Approach;

public class Robot
{
    private bool is_charged;

    public void Beep()
    {
        Recharge();
        Console.WriteLine("Robot Beeping");
    }

    protected void Recharge()
    {
        if (is_charged)
            return;
        Console.WriteLine("Robot Recharging");
        is_charged = true;
        Console.WriteLine("Robot Recharged");
    }

    public void Walk()
    {
        Recharge();
        Console.WriteLine("Robot Walking like a robot");
    }
}