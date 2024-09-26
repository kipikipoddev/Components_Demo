
namespace Step_2_Components;

public class Meow_Component : Component, IMeow_Component
{
    public void Meow()
    {
        if (Can_Meow())
            Parent.Get<IPrint_Component>().Print_Was(Actions_Description.Meowing);
        else
            Parent.Get<IPrint_Component>().Print_Cant(Actions.Meow);
    }

    public virtual bool Can_Meow()
    {
        return !Parent.Get<IDisabled_Component>().Is_Disabled;
    }
}