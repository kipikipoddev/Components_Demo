﻿namespace Step_2_OOP;

public class Robot_Dog : Robot
{
    private readonly Dog dog;

    public Robot_Dog()
    {
        dog = new Dog { Name = Name };
    }

    public override void Make_Sound()
    {
        Recharge_If_Need();
        dog.Make_Sound();
    }
}