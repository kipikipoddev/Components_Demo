namespace Step_1_Copy_Paste_Approach;

public class Robot
{
    public void Make_Sound()
    {
        Recharge();
        Console.WriteLine("Robot is beeping");
    }

    public void Walk(Speed speed = Speed.Normal)
    {
        Recharge();
        Console.WriteLine($"Robot is walking {Get_Speed(speed)}like a robot");
    }

    private void Recharge()
    {
        Console.WriteLine("Robot is recharging");
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