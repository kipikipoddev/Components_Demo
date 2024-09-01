namespace Components_Demo;

public class Heal_Command(IComponents components)
    : Action_Command(components)
{
    public override Actions Name => Actions.Heal;
}
