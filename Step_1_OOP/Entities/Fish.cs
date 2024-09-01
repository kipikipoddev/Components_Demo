
namespace Components_Demo;

public class Fish : Animal, IFIsh
{
    public Fish(IAction_Printer printer)
        : base(printer)
    {
    }

    public void Swim()
    {
        if (Is_Injured)
            Printer.Print_Cannot(this, Actions.Swim);
        else
            Printer.Print_Action(this, Actions.Swiming);
    }

    public override IEnumerable<Actions> Get_Actions()
    {
        if (!Is_Injured)
            yield return Actions.Swim;
        foreach (var action in base.Get_Actions())
            yield return action;
    }
}