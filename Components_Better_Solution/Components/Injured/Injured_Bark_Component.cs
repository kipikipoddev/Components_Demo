
namespace Components_Better_Solution;

public class Injured_Bark_Component : Bark_Component
{
    public override bool Can_Bark()
    {
        return !Parent.Get<IInjure_Component>().Is_Injured;
    }
}