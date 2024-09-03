
namespace Components_Basic_Solution;

public class Charged_Bark_Component : Bark_Component
{
    public override bool Can_Bark()
    {
        return Parent.Get<Charged_Component>().Is_Charged;
    }
}