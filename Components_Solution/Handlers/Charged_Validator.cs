

namespace Components_Solution;

public class Charged_Validator : Component, IValidator<Action_Command>
{
    public bool Is_Valid(Action_Command cmd)
    {
        var is_charged = Parent.Is_Charged();
        if (!is_charged & cmd is not Charge_Command)
            return false;
        if (is_charged & cmd is Charge_Command)
            return false;
        return true;
    }
}