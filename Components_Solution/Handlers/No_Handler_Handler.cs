
namespace Components_Solution;

public class No_Handler_Handler : Component, IHandler<No_Handler_Command>
{
    public void Handle(No_Handler_Command cmd)
    {
        if (cmd.Command is Action_Command action)
            new Print_Command(action, false);
    }
}