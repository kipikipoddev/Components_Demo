
namespace Components_Better_Solution;

public class Charged_Walk_Component : Walk_Component
{
    public override bool Can_Walk()
    {
        return Parent.Get<ICharged_Component>().Is_Charged;
    }
}