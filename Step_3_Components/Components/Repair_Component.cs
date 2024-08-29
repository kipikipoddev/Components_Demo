namespace Step_3_Components;

public class Repiar_Component : Component, IWalk_Component, ISound_Component, ISwim_Component
{
    private readonly IWalk_Component? walk;
    private readonly ISound_Component? sound;
    private readonly ISwim_Component? swim;

    public Repiar_Component()
    {
        walk = Parent.Get_Or_Defualt<IWalk_Component>();
        sound = Parent.Get_Or_Defualt<ISound_Component>();
        swim = Parent.Get_Or_Defualt<ISwim_Component>();
    }

    public void Make_Sound()
    {
        if (sound != null)
        {
            Repiar();
            Parent.Make_Sound();
        }
    }

    public void Swim()
    {
        if (Parent.Can_Swim())
        {
            Repiar();
            Parent.Swim();
        }
    }

    public void Walk()
    {
        if (Parent.Can_Walk())
        {
            Repiar();
            Parent.Walk();
        }
    }

    private void Repiar()
    {
        Parent.Write_Action("repairing...");
        Parent.Get<IInjure_Component>().Is_Injured = false;
        Parent.Write_Action("repaired");
        Parent.Remove(this);
    }
}