namespace Step_2_OOP;

public class Robot : Entity, IRobot
{
    public bool Is_Charged => Charges > 0;
    public int Charges { get; protected set; }
    public int Max_Charges { get; }

    public override bool Can_Swim => false;
    public override bool Can_Walk => Is_Charged;

    public Robot(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
    }

    public override void Walk()
    {
        if (Is_Charged)
            Charges--;
        base.Walk();
    }

    public override void Swim()
    {
        if (Is_Charged)
            Charges--;
        base.Swim();
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

    public override IEnumerable<Actions> Get_Actions()
    {
        yield return Actions.Charge;
        foreach (var action in base.Get_Actions())
            yield return action;
    }
}