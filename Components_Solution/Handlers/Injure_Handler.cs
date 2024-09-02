
namespace Components_Solution;

public class Injure_Handler : Component, IHandler<Action_Command>
{
    public void Handle(Action_Command cmd, Action next)
    {
        var is_injured = Parent.Is_Injured();
        if ((is_injured & cmd is not Heal_Command) |
            (!is_injured & cmd is Heal_Command))
            new Print_Command(cmd, false);
        else
            next();
    }
}