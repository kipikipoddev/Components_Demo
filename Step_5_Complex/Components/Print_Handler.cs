﻿
namespace Step_5_Complex;

public abstract class Print_Handler : Component, IHandler<Print_Command>
{
    protected abstract void Print(string message);

    public void Handle(Print_Command cmd)
    {
        if (cmd.Is_Was)
            Print("was", cmd.Action);
        else
            Print("can't", cmd.Action);
    }

    private void Print(string middle, Actions action)
    {
        var name = Parent.Get<IName_Component>().Name;
        var action_str = action.ToString().ToLower();
        Print($"{name} {middle} {action_str}");
    }
}