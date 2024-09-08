
namespace Step_1_Objects;

public class Fish : Animal, IFIsh
{
    public Fish(IAction_Printer printer)
        : base(printer, "Fish")
    {
    }

    public bool Can_Swim()
    {
        return !Is_Injured;
    }

    public void Swim()
    {
        if (Can_Swim())
            Printer.Print_Action(this, Actions.Swiming);
        else
            Printer.Print_Cant(this, Actions.Swim);
    }
}