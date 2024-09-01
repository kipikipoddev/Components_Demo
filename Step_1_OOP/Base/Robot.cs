
namespace Components_Demo;

public class Robot : Entity, IRobot
{
    public bool Is_Charged { get; private set; }

    public Robot(IAction_Printer printer)
        : base(printer)
    {
    }

    public void Charge()
    {
        if (Is_Charged)
            Printer.Print_Cannot(this, Actions.Charge);
        else
            Printer.Print_Action(this, Actions.Charged);
        Is_Charged = true;
    }

    public override IEnumerable<Actions> Get_Actions()
    {
        if (!Is_Charged)
            yield return Actions.Charge;
    }
}