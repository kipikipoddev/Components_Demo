﻿
namespace Components_Demo;

public class Charged_Handler : Component, IHandler<Action_Command>
{
    public void Handle(Action_Command cmd, Cancel_Token token)
    {
        if (!Parent.Is_Charged() & cmd is not Charge_Command)
        {
            Parent.Print_Cannot(cmd.Name);
            token.Cancel();
        }
    }
}