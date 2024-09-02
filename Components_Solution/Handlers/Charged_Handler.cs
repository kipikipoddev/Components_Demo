
namespace Components_Solution;

public class Charged_Handler : Component, IHandler<Action_Command>
{
    public void Handle(Action_Command cmd, Action next)
    {
        var is_charged = Parent.Is_Charged();
        if (!is_charged & cmd is not Charge_Command)
            Parent.Print_Cannot(cmd.Name);
        else if (is_charged & cmd is Charge_Command)
            Parent.Print_Cannot(cmd.Name);
        else
            next();
    }
}