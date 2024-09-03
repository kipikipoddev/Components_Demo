
namespace Components_Solution;

public class No_Handler_Handler : Component, IHandler<Action_Command>
{
    public void Handle(Action_Command cmd)
    {
        if (!cmd.Is_Valid())
            new Print_Command(cmd, false);
    }
}