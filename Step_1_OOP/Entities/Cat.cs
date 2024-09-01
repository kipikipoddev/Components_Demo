

namespace Components_Demo;

public class Cat : Animal, ICat
{
    public Cat(IAction_Printer printer)
        : base(printer)
    {
    }

    public void Meow()
    {
        if (Is_Injured)
            Printer.Print_Cannot(this, Actions.Meow);
        else
            Printer.Print_Action(this, Actions.Meowed);
    }

    public void Walk()
    {
        if (Is_Injured)
            Printer.Print_Cannot(this, Actions.Walk);
        else
            Printer.Print_Action(this, Actions.Walked);
    }

    public override IEnumerable<Actions> Get_Actions()
    {
        if (!Is_Injured)
        {
            yield return Actions.Meow;
            yield return Actions.Walk;
        }
        foreach (var action in base.Get_Actions())
            yield return action;
    }
}