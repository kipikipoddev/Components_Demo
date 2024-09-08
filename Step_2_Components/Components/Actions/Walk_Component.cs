
namespace Step_2_Components;

public class Walk_Component : Component, IWalk_Component
{
    public void Walk()
    {
        if (Can_Walk())
            Parent.Get<IPrint_Component>().Print_Was(Actions.Walking);
        else
            Parent.Get<IPrint_Component>().Print_Cant(Actions.Walk);
    }

    public virtual bool Can_Walk()
    {
        return true;
    }
}