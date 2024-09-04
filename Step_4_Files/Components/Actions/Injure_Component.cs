
namespace Step_4_Files;

public class Injure_Component
    : Action_Component<Injure_Command>, IInjure_Component, IHandler<Heal_Command>, IValidator<Action_Command>
{
    public bool Is_Injured { get; private set; }

    public override void Handle(Injure_Command cmd)
    {
        base.Handle(cmd);
        Is_Injured = true;
    }

    public void Handle(Heal_Command cmd)
    {
        base.Handle(cmd);
        Is_Injured = false;
    }

    public bool Is_Valid(Action_Command cmd)
    {
        if (cmd is Heal_Command)
            return Is_Injured;
        else
            return !Is_Injured;
    }
}