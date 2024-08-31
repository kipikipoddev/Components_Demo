namespace Step_2_OOP;

public class Robot_Dog : Robot, IRobot_Dog
{
    public bool Can_Swim => Is_Charged;
    public bool Can_Bark => Is_Charged;

    public Robot_Dog(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
    }

    public void Bark()
    {
        if (Can_Bark)
            Printer.Print_Action(this, Actions.Barking, Speed);
        else
            Printer.Print_Cannot(this, Actions.Bark);
    }

    public void Swim()
    {
        if (Can_Swim)
            Printer.Print_Action(this, Actions.Swiming, Speed);
        else
            Printer.Print_Cannot(this, Actions.Swim);
    }

    public override IEnumerable<Actions> Actions_Possible
    {
        get
        {
            if (Is_Charged)
                return [Actions.Walk, Actions.Bark, Actions.Swim, Actions.Charge];
            return [Actions.Charge];
        }
    }
}