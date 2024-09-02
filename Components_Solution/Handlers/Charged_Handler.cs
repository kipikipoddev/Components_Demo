

namespace Components_Solution;

public class Charged_Handler : Component, IHandler<Action_Command>
{
    public void Handle(Action_Command cmd, Action next)
    {
        var is_charged = Parent.Is_Charged();
        if ((!is_charged & cmd is not Charge_Command) |
            (is_charged & cmd is Charge_Command))
            new Print_Command(cmd, false);
        else
            next();
    }
}