
namespace Components_Demo;

public class Injure_Handler : Component, IHandler<Action_Command>
{
    public void Handle(Action_Command cmd, Cancel_Token token)
    {
        if (Parent.Is_Injured() & cmd is not Heal_Command)
        {
            Parent.Print_Cannot(cmd.Name);
            token.Cancel();
        }
    }
}