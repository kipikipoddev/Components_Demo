
namespace Step_5_Complex;

public class Charge_Component
 : Action_Component<Charge_Command>, IValidator<Action_Command>
{
    public bool Is_Charged { get; private set; }

    public override void Handle(Charge_Command cmd)
    {
        base.Handle(cmd);
        Is_Charged = true;
    }

    public bool Is_Valid(Action_Command cmd)
    {
        if (cmd is Charge_Command)
            return !Is_Charged;
        else
            return Is_Charged;
    }
}