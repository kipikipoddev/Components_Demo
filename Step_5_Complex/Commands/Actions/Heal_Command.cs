
namespace Step_5_Complex;

public class Heal_Command(IComponents components) 
    : Action_Command(components)
{
    public override Actions Action => Actions.Heal;
}