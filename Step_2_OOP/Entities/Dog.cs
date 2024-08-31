namespace Step_2_OOP;

public class Dog : Animal, IDog
{
    public bool Can_Swim => !Is_Injured;
    public bool Can_Walk => !Is_Injured;
    public bool Can_Bark => !Is_Injured;

    public Dog(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
    }

    public virtual void Bark()
    {
        if (Can_Bark)
            Printer.Print_Action(this, Actions.Barking, Speed);
        else
            Printer.Print_Cannot(this, Actions.Bark);
    }

    public void Walk()
    {
        if (Can_Walk)
            Printer.Print_Action(this, Actions.Walking, Speed);
        else
            Printer.Print_Cannot(this, Actions.Walk);
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
            if (!Is_Injured)
                return [Actions.Bark, Actions.Walk, Actions.Swim];
            return base.Actions_Possible;
        }
    }
}