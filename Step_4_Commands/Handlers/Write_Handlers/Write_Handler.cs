using Step_4_Commands.Commands;
using Step_4_Commands.Enums;

namespace Step_4_Commands.Sound_Handlers;

public class Write_Handler : Handler<Write_Command>
{
    public override void Handle(Write_Command cmd)
    {
        switch (cmd.Type)
        {
            case Write_Commad_Types.Actions:
                Write_Actions();
                break;
            case Write_Commad_Types.Action:
                Write_Action(cmd.Action);
                break;
            case Write_Commad_Types.Action_Like:
                Write_Action_Like(cmd.Action);
                break;
            case Write_Commad_Types.Cannot:
                Write_Cannot(cmd.Action);
                break;
        }
    }

    private void Write_Actions()
    {
        var actions = (Parent.Can<Walk_Command>() ? "Walk, " : string.Empty) +
                    (Parent.Can<Make_Sound_Command>() ? "Make sound, " : string.Empty) +
                    (Parent.Can<Swim_Command>() ? "Swim, " : string.Empty);
        actions = actions.Remove(actions.Length - 2, 2);
        Console.WriteLine(Parent.Name() + " can: " + actions);
    }

    protected virtual void Write_Action(string action)
    {
        Console.WriteLine($"{Parent.Name()} is {action}");
    }

    private void Write_Action_Like(string action)
    {
        Console.WriteLine($"{Parent.Name()} is {action}{Get_Speed()} like a {Get_Type()}");
    }

    private void Write_Cannot(string action)
    {
        Console.WriteLine(Parent.Name() + " cannot " + action);
    }

    private string Get_Speed()
    {
        return Parent.Speed() switch
        {
            Speed_Type.Slow => " slowly",
            Speed_Type.Fast => " fast",
            _ => string.Empty,
        };
    }

    private string Get_Type()
    {
        return Parent.Type().ToString().ToLower();
    }
}