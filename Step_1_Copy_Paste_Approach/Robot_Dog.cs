namespace Step_1_Copy_Paste_Approach;

public class Robot_Dog
{
    private bool is_charged;

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
        Console.WriteLine("Robot Dog Walking like a robot");
    }

    public void Bark()
    {
        Recharge();
        Console.WriteLine("Robot Dog Barking");
    }
}