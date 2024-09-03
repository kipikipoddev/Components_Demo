
namespace Components_Basic_Solution;

public class Charged_Walk_Component : Walk_Component
{
    public override bool Can_Walk()
    {
        return Parent.Get<Charged_Component>().Is_Charged;
    }
}