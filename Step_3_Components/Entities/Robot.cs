﻿namespace Step_3_Components;

public class Robot : Components
{
    public Robot()
    {
        Add(new Name_Component());
        Add(new Charge_Component());
        Add(new Recharged_Walk_Component(new Robot_Walk_Component()));
        Add(new Recharged_Sound_Components(new Beep_Component()));
    }
}