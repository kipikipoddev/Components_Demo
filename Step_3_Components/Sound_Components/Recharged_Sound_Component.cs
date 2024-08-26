namespace Step_3_Components;

public class Recharged_Sound_Component : 
    Proxy_Component<ISound_Component>, 
    ISound_Component
{
    public Recharged_Sound_Component(ISound_Component component) 
        : base(component)
    {
    }

    public void Make_Sound()
    {
        Parent.Recharge_If_Need();
        Component.Make_Sound();
    }
}