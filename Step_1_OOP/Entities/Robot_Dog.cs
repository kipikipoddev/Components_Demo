namespace Components_Demo;

public class Robot_Dog : Robot, IRobot_Dog
{
    public bool Can_Bark => Is_Charged;
    public bool Is_Injured => false;
    public bool Can_Injure => false;
    public bool Can_Heal => false;

    public Robot_Dog(IAction_Printer printer, int max_charges, Speed speed)
        : base(printer, max_charges, speed)
    {
    }

    public void Bark()
    {
        if (Can_Bark)
        {
            Charges--;
            Printer.Print_Action(this, Actions.Barking, Speed);
        }
        else
            Printer.Print_Cannot(this, Actions.Bark);
    }

    public override IEnumerable<Actions> Get_Actions()
    {
        if (Is_Charged)
            yield return Actions.Bark;
        foreach (var action in base.Get_Actions())
            yield return action;
    }

    public void Injure()
    {
        Printer.Print_Cannot(this, Actions.Injure);
    }

    public void Heal()
    {
        Printer.Print_Cannot(this, Actions.Heal);
    }
}