
namespace Objects_Solution;

public class Robot : Entity, IRobot
{
    public bool Is_Charged { get; private set; }

    public Robot(IAction_Printer printer, string name)
        : base(printer, name)
    {
    }

    public virtual void Charge()
    {
        if (Can_Charge())
            Printer.Print_Action(this, Actions.Charged);
        else
            Printer.Print_Cant(this, Actions.Charge);
        Is_Charged = true;
    }

    public bool Can_Charge()
    {
        return !Is_Charged;
    }
}