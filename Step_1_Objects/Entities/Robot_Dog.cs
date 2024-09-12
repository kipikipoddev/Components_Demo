
namespace Step_1_Objects;

public class Robot_Dog : Robot, IRobot_Dog
{
    public Robot_Dog(IAction_Printer printer)
        : base(printer, "Robot_Dog")
    {
    }

    public override IEnumerable<Actions> Available_Actions
    {
        get
        {
            yield return Actions.Charge;
            yield return Actions.Bark;
            yield return Actions.Walk;
        }
    }

    public void Bark()
    {
        if (Can_Bark())
            Printer.Print_Action(this, Actions_Description.Barking);
        else
            Printer.Print_Cant(this, Actions.Bark);
    }

    public void Walk()
    {
        if (Can_Walk())
            Printer.Print_Action(this, Actions_Description.Walking);
        else
            Printer.Print_Cant(this, Actions.Walk);
    }

    public bool Can_Bark()
    {
        return Is_Charged;
    }

    public bool Can_Walk()
    {
        return Is_Charged;
    }
}