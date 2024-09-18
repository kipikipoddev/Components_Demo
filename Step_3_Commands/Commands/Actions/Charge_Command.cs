
namespace Step_3_Commands;

public record Charge_Command(IComponents components) : Action_Command(components)
{
    public override Actions Name => Actions.Charge;
    public override Actions_Description Action => Actions_Description.Charged;
}