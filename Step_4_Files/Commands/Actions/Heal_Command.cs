
namespace Step_4_Files;

public class Heal_Command(IComponents components) 
    : Action_Command(components)
{
    public override Actions Name => Actions.Heal;
    public override Actions Was => Actions.Healed;
}