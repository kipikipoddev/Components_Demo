
namespace Step_2_OOP;

public class Cat : Animal, ICat
{
    public bool Can_Meow => !Is_Injured;
    public bool Can_Walk => !Is_Injured;

    public Cat(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
    }

    public void Meow()
    {
        if (Can_Meow)
            Printer.Print_Action(this, Actions.Meowing);
        else
            Printer.Print_Cannot(this, Actions.Meow);
    }

    public virtual void Walk()
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
            if (!Is_Injured)
                return [Actions.Meow, Actions.Walk];
            return base.Actions_Possible;
        }
    }
}