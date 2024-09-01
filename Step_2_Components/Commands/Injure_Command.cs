namespace Components_Demo;

public class Injure_Command(IComponents components) 
    : Action_Command(components)
{
    public override Actions Name => Actions.Injure;
}
