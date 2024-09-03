
namespace Components_Basic_Solution;

public class Injured_Walk_Component : Walk_Component
{
    public override bool Can_Walk()
    {
        return !Parent.Get<IInjure_Component>().Is_Injured;
    }
}