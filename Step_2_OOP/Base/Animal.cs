namespace Step_2_OOP;

public abstract class Animal : Entity, IAnimal
{
    public bool Is_Injured { get; private set; }

    public override bool Can_Walk => base.Can_Walk & !Is_Injured;
    public override bool Can_Make_Sound => base.Can_Make_Sound & !Is_Injured;
    public override bool Can_Swim => base.Can_Swim & !Is_Injured;

    protected Animal(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
    }

    public override void Make_Sound()
    {
        if (Can_Make_Sound)
        {
            var extra = Is_Injured ? " painfully" : null;
            Printer.Print_Action(this, Sound, false, extra);
        }
        else
            base.Make_Sound();
    }

    public void Heal()
    {
        if (Is_Injured)
        {
            Printer.Print_Action(this, Actions.Healing);
            Is_Injured = false;
            Printer.Print_Action(this, Actions.Healed);
        }
        else
            Printer.Print_Cannot(this, Actions.Heal);
    }

    public void Injure()
    {
        if (Is_Injured)
            Printer.Print_Cannot(this, Actions.Injure);
        else
        {
            Printer.Print_Action(this, Actions.Injured);
            Is_Injured = true;
        }
    }
}