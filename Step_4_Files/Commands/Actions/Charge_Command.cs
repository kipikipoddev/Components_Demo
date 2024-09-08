
namespace Step_4_Files;

public class Charge_Command(IComponents components)
    : Action_Command(components)
{
    public override Actions Action => Actions.Charge;
}