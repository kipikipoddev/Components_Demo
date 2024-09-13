

namespace Step_1_Objects;

public class Cat : Animal, ICat
{
    public Cat(IAction_Printer printer)
        : base(printer, "Cat")
    {
    }

    public override IEnumerable<Actions> Available_Actions
    {
        get
        {
            yield return Actions.Meow;
            yield return Actions.Walk;
            foreach (var action in base.Available_Actions)
                yield return action;
        }
    }

    public void Meow()
    {
        if (Can_Meow())
            Printer.Print_Action(this, Actions_Description.Meowing);
        else
            Printer.Print_Cant(this, Actions.Meow);
    }

    public void Walk()
    {
        if (Can_Walk())
            Printer.Print_Action(this, Actions_Description.Walking);
        else
            Printer.Print_Cant(this, Actions.Walk);
    }

    public bool Can_Walk()
    {
        return !Is_Injured;
    }

    public bool Can_Meow()
    {
        return !Is_Injured;
    }
}