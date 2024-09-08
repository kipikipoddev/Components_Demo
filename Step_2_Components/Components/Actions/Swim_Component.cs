
namespace Step_2_Components;

public class Swim_Component : Component, ISwim_Component
{
    public void Swim()
    {
        if (Can_Swim())
            Parent.Get<IPrint_Component>().Print_Was(Actions.Swiming);
        else
            Parent.Get<IPrint_Component>().Print_Cant(Actions.Swim);
    }

    public virtual bool Can_Swim()
    {
        return true;
    }
}