﻿using Step_5_Files.Attributes;
using Step_5_Files.Commands;
using Step_5_Files.Sound_Handlers;

namespace Step_5_Files.Walk_Handlers;

[Component_Name("Dog_Walk")]
public class Dog_Walk_Handler : Handler<Walk_Command>
{
    public override void Handle(Walk_Command evnt)
    {
        Write("walking like a dog");
    }
}