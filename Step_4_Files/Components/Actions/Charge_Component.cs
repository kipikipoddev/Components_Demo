
namespace Step_4_Files;

public class Charge_Component : Action_Component, ICharged_Component
{
    public bool Is_Charged { get; private set; }

    protected override void Parent_Set()
    {
        new Set_Disabled_Command(Parent, true);
    }

    public bool Can_Charge()
    {
        return !Is_Charged;
    }

    public void Charge()
    {
        if (Can_Charge())
        {
            Is_Charged = true;
            new Set_Disabled_Command(Parent, false);
            Print_Was(Actions_Description.Charged);
        }
        else
            Print_Cant(Actions.Charge);
    }
}