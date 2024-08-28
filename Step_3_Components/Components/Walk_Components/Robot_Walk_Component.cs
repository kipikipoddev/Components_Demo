namespace Step_3_Components;

public class Robot_Walk_Component : Proxy_Component<IWalk_Component>, IWalk_Component
{
    public Robot_Walk_Component(IWalk_Component component)
         : base(component)
    {
    }

    public void Walk()
    {
        if (Parent.Is_Injured())
            Parent.Get<Robot_Injure_Component>().Repair();
        if (!Parent.Is_Recharged())
            Parent.Recharge();
        Component.Walk();
    }
}