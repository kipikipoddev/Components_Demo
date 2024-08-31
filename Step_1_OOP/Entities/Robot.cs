namespace Step_1_OOP;

public class Robot : Entity, IRobot
{
    public bool Is_Charged => Charges > 0;
    public int Charges { get; protected set; }
    public int Max_Charges { get; }
    public bool Can_Recharge => Charges < Max_Charges;

    public override bool Can_Swim => Is_Charged;
    public override bool Can_Walk => Is_Charged;


    public Robot(IAction_Printer printer, int max_charges, Speed speed)
        : base(printer, speed)
    {
        if (max_charges <= 0)
            throw new ArgumentException("max_charges <= 0");
        Max_Charges = max_charges;
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

    public void Recharge()
    {
        if (Can_Recharge)
        {
            Printer.Print_Action(this, Actions.Recharging, Speed);
            Charges = Max_Charges;
        }
        else
            Printer.Print_Cannot(this, Actions.Recharge);
    }

    public override IEnumerable<Actions> Get_Actions()
    {
        if (Can_Recharge)
            yield return Actions.Recharge;
        foreach (var action in base.Get_Actions())
            yield return action;
    }
}