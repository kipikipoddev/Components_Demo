

namespace Step_1_Objects;

public class Cat : Animal, ICat
{
    public Cat(IAction_Printer printer)
        : base(printer, "Cat")
    {
    }

    public void Meow()
    {
        if (Can_Meow())
            Printer.Print_Action(this, Actions.Meowing);
        else
            Printer.Print_Cant(this, Actions.Meow);
    }

    public void Walk()
    {
        if (Can_Walk())
            Printer.Print_Action(this, Actions.Walking);
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