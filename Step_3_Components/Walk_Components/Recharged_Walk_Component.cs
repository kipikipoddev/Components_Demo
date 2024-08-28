using Step_3_Components.Enums;

namespace Step_3_Components;

public class Recharged_Walk_Component : Component, IWalk_Component
{
    private readonly IWalk_Component component;

    public Recharged_Walk_Component(IWalk_Component component)
    {
        this.component = component;
    }

    protected override void Parent_Set()
    {
        component.Parent = Parent;
    }

    public void Walk(Speed speed)
    {
        Parent.Recharge();
        component.Walk(speed);
    }
}