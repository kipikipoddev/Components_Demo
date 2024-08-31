namespace Step_1_OOP;

public abstract class Robot : Entity, IRobot
{
    public bool Is_Charged { get; private set; }

    public override bool Can_Walk => base.Can_Walk & Is_Charged;
    public override bool Can_Make_Sound => base.Can_Make_Sound & Is_Charged;
    public override bool Can_Swim => base.Can_Swim & Is_Charged;

    public Robot(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
    }

    public void Charge()
    {
        if (Is_Charged)
            Printer.Print_Cannot(this, Actions.Charge);
        else
        {
            Printer.Print_Action(this, Actions.Charging);
            Is_Charged = true;
            Printer.Print_Action(this, Actions.Charged);
        }
    }
}