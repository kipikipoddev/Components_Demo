
namespace Components_Basic_Solution;

public class Injured_Bark_Component : Bark_Component
{
    public override bool Can_Bark()
    {
        return !Parent.Get<Injure_Component>().Is_Injured;
    }
}