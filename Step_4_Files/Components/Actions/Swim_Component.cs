﻿namespace Step_4_Files;

public class Swim_Component : Action_Component, ISwim_Component
{
    public void Swim()
    {
        if (Can_Swim())
            Print_Was(Actions_Description.Swiming);
        else
            Print_Cant(Actions.Swim);
    }

    public bool Can_Swim()
    {
        return !Is_Disabled;
    }
}