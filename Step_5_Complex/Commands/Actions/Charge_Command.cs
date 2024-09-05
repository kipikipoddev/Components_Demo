
namespace Step_5_Complex;

public class Charge_Command(IComponents components)
    : Action_Command(components)
{
    public override Actions Name => Actions.Charge;
}