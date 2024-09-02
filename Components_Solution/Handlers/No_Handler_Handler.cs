
namespace Components_Solution;

public class No_Handler_Handler : Component, IHandler<Action_Command>
{
    public void Handle(Action_Command cmd, Action next)
    {
        if (next == Mediator.Defualt_Action)
            new Print_Command(cmd, false);
        else
            next();
    }
}