namespace Step_3_Components;

public class Repiar_Component : Component
{
    public void Repiar()
    {
        Parent.Write_Action("repairing...");
        Parent.Get<IInjure_Component>().Is_Injured = false;
        Parent.Write_Action("repaired");
        Parent.Remove(this);
    }
}