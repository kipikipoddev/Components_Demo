namespace Step_1_Copy_Paste_Approach;

public class Robot_Dog
{
    public void Walk()
    {
        Recharge();
        Console.WriteLine("Robot_Dog is walking like a dog");
    }

    public void Swim()
    {
        Recharge();
        Console.WriteLine("Robot_Dog is swiming like a dog");
    }

    public void Make_Sound()
    {
        Recharge();
        Console.WriteLine("Robot_Dog is barking");
    }

    private void Recharge()
    {
        Console.WriteLine("Robot_Dog is recharging");
    }
}