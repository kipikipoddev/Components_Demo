
namespace Step_5_Complex;

public class Injure_Command(IComponents components) 
    : Action_Command(components)
{
    public override Actions Name => Actions.Injure;
    public override Actions Was => Actions.Injured;
}