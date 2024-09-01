
namespace Components_Demo;

public class Injure_Handler : Component, IHandler<Action_Command>
{
    public void Handle(Action_Command cmd, Action next)
    {
        if (Parent.Is_Injured() & cmd is not Heal_Command)
            Parent.Print_Cannot(cmd.Name);
        else if (!Parent.Is_Injured() & cmd is Heal_Command)
            Parent.Print_Cannot(cmd.Name);
        else
            next();
    }
}