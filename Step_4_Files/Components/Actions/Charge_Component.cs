
namespace Step_4_Files;

public class Charge_Component
 : Action_Component<Charge_Command>, ICharged_Component, IValidator<Action_Command>
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