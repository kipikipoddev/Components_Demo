
namespace Step_2_Components;

public class Bark_Component : Component, IBark_Component
{
    public void Bark()
    {
        if (Can_Bark())
            Parent.Get<IPrint_Component>().Print_Was(Actions_Description.Barking);
        else
            Parent.Get<IPrint_Component>().Print_Cant(Actions.Bark);
    }

    public virtual bool Can_Bark()
    {
        return !Parent.Get<IDisabled_Component>().Is_Disabled;
    }
}