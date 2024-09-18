
namespace Step_3_Commands;

public record Heal_Command(IComponents components) : Action_Command(components)
{
    public override Actions Name => Actions.Heal;
    public override Actions_Description Action => Actions_Description.Healed;
}