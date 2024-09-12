
namespace Step_5_Complex;

public class Charge_Component :
    Action_Component<Action_Command>,
    ICharged_Component,
    IValidator<Action_Command>
{
    public bool Has_Charge => Charges > 0;

    public int Charges { get; private set; }
    public int Max_Charges { get; private set; }

    public Charge_Component(int max_charges)
    {
        Max_Charges = max_charges;
    }

    public override IEnumerable<Actions> Actions_Handling
    {
        get
        {
            yield return Actions.Charge;
        }
    }

    public override void Handle(Action_Command cmd)
    {
        if (cmd is Charge_Command)
        {
            Charges = Max_Charges;
            base.Handle(cmd);
        }
        else
            Charges--;
    }

    public bool Is_Valid(Action_Command cmd)
    {
        if (cmd is Charge_Command)
            return Charges < Max_Charges;
        else
            return Has_Charge;
    }
}