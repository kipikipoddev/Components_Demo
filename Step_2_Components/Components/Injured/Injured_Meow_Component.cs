
namespace Step_2_Components;

public class Injured_Meow_Component : Meow_Component
{
    public override bool Can_Meow()
    {
        return !Parent.Get<IInjure_Component>().Is_Injured;
    }
}