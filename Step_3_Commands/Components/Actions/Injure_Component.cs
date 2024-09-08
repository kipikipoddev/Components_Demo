
namespace Step_3_Commands;

public class Injure_Component :
    Action_Component<Injure_Command>,
    IInjure_Component,
    IHandler<Heal_Command>,
    IValidator<Action_Command>
{
    public bool Is_Injured { get; private set; }

    public Injure_Component()
    {
        Mediator.Add_Handler<Heal_Command>(this);
        Mediator.Add_Validator(this);
    }

    public override void Handle(Injure_Command cmd)
    {
        Print(cmd);
        Is_Injured = true;
    }

    public void Handle(Heal_Command cmd)
    {
        Print(cmd);
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