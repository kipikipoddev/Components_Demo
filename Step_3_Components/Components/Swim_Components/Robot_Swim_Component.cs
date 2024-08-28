namespace Step_3_Components;

public class Robot_Swim_Component : Proxy_Component<ISwim_Component>, ISwim_Component
{
    public Robot_Swim_Component(ISwim_Component component)
         : base(component)
    {
    }

    public void Swim()
    {
        if (Parent.Is_Injured())
            Parent.Get<Robot_Injure_Component>().Repair();
        if (!Parent.Is_Recharged())
            Parent.Recharge();
        Component.Swim();
    }
}