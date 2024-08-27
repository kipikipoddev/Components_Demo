namespace Step_1_Copy_Paste_Approach;

public class Robot_Cat_Dog
{
    private bool is_charged;

    protected void Recharge()
    {
        if (is_charged)
            return;
        Console.WriteLine("Robot_Cat_Dog is recharging");
        is_charged = true;
        Console.WriteLine("Robot_Cat_Dog is recharged");
    }

    public void Walk()
    {
        Recharge();
        Console.WriteLine("Robot_Cat_Dog is walking like a robot");
    }

    public void Make_Sound()
    {
        Recharge();
        Console.WriteLine("Robot_Cat_Dog is meowing");
        Console.WriteLine("Robot_Cat_Dog is barking");
    }
}