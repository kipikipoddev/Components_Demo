namespace Step_3_Components;

public class Recharged_Sound_Component : Component, ISound_Component
{
    private readonly ISound_Component sound;

    public Recharged_Sound_Component(ISound_Component sound)
    {
        this.sound = sound;
    }

    public void Make_Sound()
    {
        Parent.Charge().Recharge_If_Need();
        sound.Make_Sound();
    }

    protected override void Parent_Set()
    {
        sound.Parent = Parent;
    }
}