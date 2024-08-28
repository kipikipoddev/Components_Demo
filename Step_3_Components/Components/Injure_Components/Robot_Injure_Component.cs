namespace Step_3_Components;

public class Robot_Injure_Component : Component, IInjure_Component
{
    public bool Is_Injured { get; set; }

    public void Injure()
    {
        Parent.Write_Action("broken");
        Is_Injured = true;
    }

    public void Repair()
    {
        Parent.Write_Action("repairing...");
        Is_Injured = false;
        Parent.Write_Action("repaired");
    }
}