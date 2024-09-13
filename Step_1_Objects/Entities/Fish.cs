
namespace Step_1_Objects;

public class Fish : Animal, IFish
{
    public Fish(IAction_Printer printer)
        : base(printer, "Fish")
    {
    }

    public override IEnumerable<Actions> Available_Actions
    {
        get
        {
            yield return Actions.Swim;
            foreach (var action in base.Available_Actions)
                yield return action;
        }
    }

    public bool Can_Swim()
    {
        return !Is_Injured;
    }

    public void Swim()
    {
        if (Can_Swim())
            Printer.Print_Action(this, Actions_Description.Swiming);
        else
            Printer.Print_Cant(this, Actions.Swim);
    }
}