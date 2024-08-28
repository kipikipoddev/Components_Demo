namespace Step_3_Components;

public class Robot_Sound_Component : Proxy_Component<ISound_Component>, ISound_Component
{
    public Robot_Sound_Component(ISound_Component component)
         : base(component)
    {
    }

    public void Make_Sound()
    {
        if (Parent.Is_Injured())
            Parent.Get<Robot_Injure_Component>().Repair();
        if (!Parent.Is_Recharged())
            Parent.Recharge();
        Component.Make_Sound();
    }
}