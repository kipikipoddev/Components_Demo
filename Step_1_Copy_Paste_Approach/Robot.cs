namespace Step_1_Copy_Paste_Approach;

public class Robot
{
    public void Make_Sound()
    {
        Recharge();
        Console.WriteLine("Robot is beeping");
    }

    public void Walk()
    {
        Recharge();
        Console.WriteLine("Robot is walking like a robot");
    }

    private void Recharge()
    {
        Console.WriteLine("Robot is recharging");
    }
}