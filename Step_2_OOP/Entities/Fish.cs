namespace Step_2_OOP;

public class Fish : Animal, IFish
{
    public bool Can_Swim => !Is_Injured;

    public Fish(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
    }

    public virtual void Swim()
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
                return [Actions.Swim];
            return base.Actions_Possible;
        }
    }
}