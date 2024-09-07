﻿namespace Step_3_Commands;

public abstract class Print_Component : Component, IHandler<Print_Command>
{
    protected abstract void Print(string message);


    public void Handle(Print_Command cmd)
    {
        if (cmd.Is_Was)
            Print("was", (Actions_Description)cmd.Actions);
        else
            Print("can't", cmd.Actions);
    }

    private void Print(string middle, object action)
    {
        var name = Parent.Get<IName_Component>().Name;
        var action_str = action.ToString()!.ToLower();
        Print($"{name} {middle} {action_str}");
    }

}