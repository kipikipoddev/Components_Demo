
namespace Step_3_Commands;

public class Heal_Command(IComponents components) 
    : Action_Command(components)
{
    public override Actions Name => Actions.Heal;
    public override Actions Was => Actions.Healed;
}