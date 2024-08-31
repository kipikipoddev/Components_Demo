
namespace Step_1_OOP;

public class Cat : Animal, ICat
{
    public override bool Can_Swim => false;
    public override bool Can_Walk => !Is_Injured;
    public bool Can_Meow => !Is_Injured;

    public Cat(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
    }

    public void Meow()
    {
        if (Can_Meow)
            Printer.Print_Action(this, Actions.Meowing);
        else
            Printer.Print_Cannot(this, Actions.Meow);
    }

    public override IEnumerable<Actions> Get_Actions()
    {
        if (!Is_Injured)
            yield return Actions.Meow;
        foreach (var action in base.Get_Actions())
            yield return action;
    }
}