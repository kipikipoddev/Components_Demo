namespace Step_1_Copy_Paste_Approach;

public class Robot_Dog
{
    public void Walk(Speed speed = Speed.Normal)
    {
        Recharge();
        Console.WriteLine($"Robot_Dog is walking {Get_Speed(speed)}like a dog");
    }

    public void Swim(Speed speed = Speed.Normal)
    {
        Recharge();
        Console.WriteLine($"Robot_Dog is swiming {Get_Speed(speed)}like a dog");
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


    private string Get_Speed(Speed speed)
    {
        if (speed == Speed.Slow)
            return "slowly ";
        if (speed == Speed.Fast)
            return "Fast ";
        return string.Empty;
    }
}