
namespace Components_Demo;

public class Robot_Dog : Robot, IRobot_Dog
{
    public Robot_Dog(IAction_Printer printer)
        : base(printer)
    {
    }

    public void Bark()
    {
        if (Is_Charged)
            Printer.Print_Action(this, Actions.Barked);
        else
            Printer.Print_Cannot(this, Actions.Bark);
    }

    public void Walk()
    {
        if (Is_Charged)
            Printer.Print_Action(this, Actions.Walked);
        else
            Printer.Print_Cannot(this, Actions.Walk);
    }

    public void Swim()
    {
        if (Is_Charged)
            Printer.Print_Action(this, Actions.Swam);
        else
            Printer.Print_Cannot(this, Actions.Swim);
    }

    public override IEnumerable<Actions> Get_Actions()
    {
        if (Is_Charged)
        {
            yield return Actions.Bark;
            yield return Actions.Walk;
            yield return Actions.Swim;
        }
        else
            yield return Actions.Charge;
    }
}