
namespace Components_Solution;

public class Injure_Validator : Component, IValidator<Action_Command>
{
    public bool Is_Valid(Action_Command cmd)
    {
        var is_injured = Parent.Is_Injured();
        if (is_injured & cmd is not Heal_Command)
            return false;
        else if (!is_injured & cmd is Heal_Command)
            return false;
        return true;
    }
}