namespace Step_3_Components;

public class Recharged_Sound_Component : Component, ISound_Component
{
    private readonly ISound_Component component;

    public Recharged_Sound_Component(ISound_Component component)
    {
        this.component = component;
    }

    protected override void Parent_Set()
    {
        component.Parent = Parent;
    }

    public void Make_Sound()
    {
        Parent.Recharge();
        component.Make_Sound();
    }
}