
namespace Step_5_Complex;

public class Charge_Component
 : Component, IHandler<Action_Command>, ICharged_Component, IValidator<Action_Command>
{
    public bool Has_Charge => Charges > 0;
    
    public int Charges { get; private set; }
    public int Max_Charges { get; private set; }

    public Charge_Component(int max_charges)
    {
        Max_Charges = max_charges;
    }

    public void Handle(Action_Command cmd)
    {
        if (cmd is Charge_Command)
            Charges = Max_Charges;
        else
            Charges--;
    }

    public bool Is_Valid(Action_Command cmd)
    {
        if (cmd is Charge_Command)
            return !Has_Charge;
        else
            return Has_Charge;
    }
}