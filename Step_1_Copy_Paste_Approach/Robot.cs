namespace Step_1_Copy_Paste_Approach;

public class Robot
{
    private bool is_charged;

    public void Make_Sound()
    {
        Recharge();
        Console.WriteLine("Robot is beeping");
    }

    protected void Recharge()
    {
        if (is_charged)
            return;
        Console.WriteLine("Robot is recharging");
        is_charged = true;
        Console.WriteLine("Robot is recharged");
    }

    public void Walk()
    {
        Recharge();
        Console.WriteLine("Robot is walking like a robot");
    }
}