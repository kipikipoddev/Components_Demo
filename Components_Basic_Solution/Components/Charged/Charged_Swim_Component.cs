
namespace Components_Basic_Solution;

public class Charged_Swim_Component : Swim_Component
{
    public override bool Can_Swim()
    {
        return Parent.Get<ICharged_Component>().Is_Charged;
    }
}