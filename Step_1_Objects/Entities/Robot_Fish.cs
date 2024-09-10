
namespace Step_1_Objects;

public class Robot_Fish : Robot, IRobot_Fish
{
    public Robot_Fish(IAction_Printer printer)
        : base(printer, "Robot_Fish")
    {
    }

    public override IEnumerable<Actions> Available_Actions
    {
        get
        {
            yield return Actions.Charge;
            yield return Actions.Swim;
        }
    }

    public bool Can_Swim()
    {
        return Is_Charged;
    }

    public void Swim()
    {
        if (Can_Swim())
            Printer.Print_Action(this, Actions_Description.Swiming);
        else
            Printer.Print_Cant(this, Actions.Swim);
    }
}