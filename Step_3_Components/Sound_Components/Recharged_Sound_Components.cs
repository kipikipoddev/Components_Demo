namespace Step_3_Components;

public class Recharged_Sound_Components : Component, ISound_Component
{
    private readonly ISound_Component[] components;

    public Recharged_Sound_Components(params ISound_Component[] components)
    {
        this.components = components;
    }

    protected override void Parent_Set()
    {
        foreach (var component in components)
            component.Parent = Parent;
    }

    public void Make_Sound()
    {
        Parent.Recharge();
        foreach (var component in components)
            component.Make_Sound();
    }
}