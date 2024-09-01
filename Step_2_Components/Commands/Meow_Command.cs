namespace Components_Demo;

public class Meow_Command(IComponents components)
    : Action_Command(components)
{
    public override Actions Name => Actions.Meow;
}
