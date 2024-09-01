
namespace Components_Demo;

public class Injure_Handler : Component, IHandler<Action_Command>
{
    public void Handle(Action_Command cmd, Action next)
    {
        var is_injured = Parent.Is_Injured();
        if (is_injured & cmd is not Heal_Command)
            Parent.Print_Cannot(cmd.Name);
        else if (!is_injured & cmd is Heal_Command)
            Parent.Print_Cannot(cmd.Name);
        else
            next();
    }
}