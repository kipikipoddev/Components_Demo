

namespace Objects_Solution;

public class Cat : Animal, ICat
{
    public Cat(IAction_Printer printer)
        : base(printer)
    {
    }

    public void Meow()
    {
        if (Can_Meow())
            Printer.Print_Action(this, Actions.Meowing);
        else
            Printer.Print_Cannot(this, Actions.Meow);
    }

    public void Walk()
    {
        if (Can_Walk())
            Printer.Print_Action(this, Actions.Walking);
        else
            Printer.Print_Cannot(this, Actions.Walk);
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