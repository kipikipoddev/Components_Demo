namespace Step_3_Components;

public class Robot_Injure_Component : Component, IInjure_Component
{
    private bool is_injured;

    public bool Is_Injured
    {
        get => is_injured;
        set
        {
            if (value & !is_injured)
            {
                Parent.Write_Action("broken");
                Parent.Add(new Repiar_Component());
            }
            is_injured = value;
        }
    }
}