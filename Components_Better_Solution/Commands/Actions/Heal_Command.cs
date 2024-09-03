
namespace Components_Better_Solution;

public class Heal_Command(IComponents components) 
    : Action_Command(components)
{
    public override Actions Name => Actions.Heal;
    public override Actions Was => Actions.Healed;
}