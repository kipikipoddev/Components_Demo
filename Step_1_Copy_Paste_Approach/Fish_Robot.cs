﻿namespace Step_1_Copy_Paste_Approach;

public class Fish_Robot
{
    public void Make_Sound()
    {
        Recharge();
        Console.WriteLine("Fish_Robot is beeping");
    }

    public void Swim()
    {
        Recharge();
        Console.WriteLine("Fish_Robot is swiming");
    }

    private void Recharge()
    {
        Console.WriteLine("Robot is recharged");
    }
}