namespace Step_1_Copy_Paste_Approach;

public class Robot_Cat_Dog
{
    private bool is_charged;

    protected void Recharge()
    {
        if (is_charged)
            return;
        Console.WriteLine("Robot_Cat_Dog Recharging");
        is_charged = true;
        Console.WriteLine("Robot_Cat_Dog Recharged");
    }

    public void Walk()
    {
        Recharge();
        Console.WriteLine("Robot_Cat_Dog Walking like a robot");
    }

    public void Make_Sound()
    {
        Recharge();
        Console.WriteLine("Robot_Cat_Dog Meowing");
        Console.WriteLine("Robot_Cat_Dog Barking");
    }
}