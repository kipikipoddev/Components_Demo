
namespace Components_Solution;

public class No_Handler : Component, IHandler<Action_Command>
{
    public void Handle(Action_Command cmd, Action next)
    {
        if (next == Command.Defualt_Action)
            Parent.Print_Cannot(cmd.Name);
        else
            next();
    }
}