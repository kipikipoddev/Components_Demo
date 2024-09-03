
namespace Components_Basic_Solution;

public class Injured_Swim_Component : Swim_Component
{
    public override bool Can_Swim()
    {
        return !Parent.Get<IInjure_Component>().Is_Injured;
    }
}