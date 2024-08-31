namespace Components_Demo;

public class Dog : Animal, IDog
{
    public override bool Can_Walk => !Is_Injured;
    public override bool Can_Swim => !Is_Injured;
    public bool Can_Bark => !Is_Injured;

    public Dog(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
    }

    public void Bark()
    {
        if (Can_Bark)
            Printer.Print_Action(this, Actions.Barking, Speed);
        else
            Printer.Print_Cannot(this, Actions.Bark);
    }

    public override IEnumerable<Actions> Get_Actions()
    {
        if (!Is_Injured)
            yield return Actions.Bark;
        foreach (var action in base.Get_Actions())
            yield return action;
    }
}