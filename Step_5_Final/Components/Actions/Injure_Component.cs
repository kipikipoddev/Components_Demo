
namespace Step_5_Final;

public class Injure_Component : Action_Component, IInjure_Component
{
    public bool Is_Injured { get; private set; }

    public bool Can_Heal()
    {
        return Is_Injured;
    }

    public bool Can_Injure()
    {
        return !Is_Injured;
    }

    public void Heal()
    {
        if (Can_Heal())
        {
            Is_Injured = false;
            new Set_Disabled_Command(Parent, false);
            Print_Was(Actions_Description.Healed);
        }
        else
            Print_Cant(Actions.Heal);
    }

    public void Injure()
    {
        if (Can_Injure())
        {
            Is_Injured = true;
            new Set_Disabled_Command(Parent, true);
            Print_Was(Actions_Description.Injured);
        }
        else
            Print_Cant(Actions.Injure);
    }
}