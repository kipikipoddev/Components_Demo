namespace Step_3_Components;

public class Recharged_Swim_Component : Component, ISwim_Component
{
    private readonly ISwim_Component component;

    public Recharged_Swim_Component(ISwim_Component component)
    {
        this.component = component;
    }

    protected override void Parent_Set()
    {
        component.Parent = Parent;
    }

    public void Swim()
    {
        Parent.Recharge();
        component.Swim();
    }
}