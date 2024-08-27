﻿using Step_5_Files.Attributes;
using Step_5_Files.Commands;
using Step_5_Files.Sound_Handlers;

namespace Step_5_Files.Walk_Handlers;

[Component_Name("Cat_Walk")]
public class Cat_Walk_Handler : Handler<Walk_Command>
{
    public override void Handle(Walk_Command cmd)
    {
        Write("walking like a cat");
    }
}