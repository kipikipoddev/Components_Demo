
namespace Objects_Solution;

public class Robot_Dog : Robot, IRobot_Dog
{
    public Robot_Dog(IAction_Printer printer)
        : base(printer)
    {
    }

    public void Bark()
    {
        if (Can_Bark())
            Printer.Print_Action(this, Actions.Barking);
        else
            Printer.Print_Cannot(this, Actions.Bark);
    }

    public void Walk()
    {
        if (Can_Walk())
            Printer.Print_Action(this, Actions.Walking);
        else
            Printer.Print_Cannot(this, Actions.Walk);

    }

    public void Swim()
    {
        if (Can_Swim())
            Printer.Print_Action(this, Actions.Swiming);
        else
            Printer.Print_Cannot(this, Actions.Swim);
    }

    public bool Can_Bark()
    {
        return Is_Charged;
    }

    public bool Can_Walk()
    {
        return Is_Charged;
    }

    public bool Can_Swim()
    {
        return Is_Charged;
    }
}