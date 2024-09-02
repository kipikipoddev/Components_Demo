
namespace Objects_Solution;

public class Fish : Animal, IFIsh
{
    public Fish(IAction_Printer printer)
        : base(printer)
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
            Printer.Print_Cannot(this, Actions.Swim);
    }
}