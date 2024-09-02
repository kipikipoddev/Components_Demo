
namespace Objects_Solution;

public class Robot_Fish : Robot, IRobot_Fish
{
    public Robot_Fish(IAction_Printer printer)
        : base(printer)
    {
    }

    public void Swim()
    {
        if (Is_Charged)
            Printer.Print_Action(this, Actions.Swiming);
        else
            Printer.Print_Cannot(this, Actions.Swim);
    }

    public override IEnumerable<Actions> Get_Actions()
    {
        if (Is_Charged)
            yield return Actions.Swim;
        else
            yield return Actions.Charge;
    }
}