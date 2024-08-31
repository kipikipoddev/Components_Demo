namespace Step_2_OOP;

public class Robot : Entity, IRobot
{
    public bool Is_Charged => Charges > 0;
    public int Charges { get; protected set; }
    public int Max_Charges { get; }

    public bool Can_Walk => Is_Charged;

    public Robot(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
    }

    public void Charge(int charges)
    {
        if (Is_Charged)
            Printer.Print_Cannot(this, Actions.Charge);
        else
        {
            Printer.Print_Action(this, Actions.Charging);
            Charges = Math.Min(Max_Charges, Charges + charges);
            Printer.Print_Action(this, Actions.Charged);
        }
    }

    public void Walk()
    {
        if (Can_Walk)
            Printer.Print_Action(this, Actions.Walking, Speed);
        else
            Printer.Print_Cannot(this, Actions.Walk);
    }

    public override IEnumerable<Actions> Actions_Possible
    {
        get
        {
            if (Is_Charged)
                return [Actions.Walk, Actions.Charge];
            return [Actions.Charge];
        }
    }
}