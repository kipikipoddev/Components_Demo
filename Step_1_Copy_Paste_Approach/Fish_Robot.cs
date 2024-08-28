namespace Step_1_Copy_Paste_Approach;

public class Fish_Robot
{
    public void Make_Sound()
    {
        Recharge();
        Console.WriteLine("Fish_Robot is beeping");
    }

    public void Swim(Speed speed = Speed.Normal)
    {
        Recharge();
        Console.WriteLine($"Fish_Robot is walking {Get_Speed(speed)}like a fish");
    }

    private void Recharge()
    {
        Console.WriteLine("Fish_Robot is recharging");
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