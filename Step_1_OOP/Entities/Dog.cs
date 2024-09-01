namespace Components_Demo;

public class Dog : Animal, IDog
{
    public Dog(IAction_Printer printer)
        : base(printer)
    {
    }

    public void Bark()
    {
        if (Is_Injured)
            Printer.Print_Cannot(this, Actions.Bark);
        else
            Printer.Print_Action(this, Actions.Barking);
    }

    public void Walk()
    {
        if (Is_Injured)
            Printer.Print_Cannot(this, Actions.Walk);
        else
            Printer.Print_Action(this, Actions.Walking);
    }

    public void Swim()
    {
        if (Is_Injured)
            Printer.Print_Cannot(this, Actions.Swim);
        else
            Printer.Print_Action(this, Actions.Swiming);
    }

    public override void Injure()
    {
        var is_injured = Is_Injured;
        base.Injure();
        if (!is_injured)
            Printer.Print_Action(this, Actions.Barking);
    }

    public override IEnumerable<Actions> Get_Actions()
    {
        if (!Is_Injured)
        {
            yield return Actions.Bark;
            yield return Actions.Walk;
            yield return Actions.Swim;
        }
        foreach (var action in base.Get_Actions())
            yield return action;
    }
}