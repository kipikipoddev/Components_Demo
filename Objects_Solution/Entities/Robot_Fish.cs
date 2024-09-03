
namespace Objects_Solution;

public class Robot_Fish : Robot, IRobot_Fish
{
    public Robot_Fish(IAction_Printer printer)
        : base(printer, "Robot_Fish")
    {
    }

    public bool Can_Swim()
    {
        return Is_Charged;
    }

    public void Swim()
    {
        if (Can_Swim())
            Printer.Print_Action(this, Actions.Swiming);
        else
            Printer.Print_Cant(this, Actions.Swim);
    }
}