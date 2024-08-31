
namespace Components_Demo;

public abstract class Animal : Entity, IAnimal
{
    public bool Is_Injured { get; private set; }
    public bool Can_Injure => !Is_Injured;
    public bool Can_Heal => Is_Injured;

    public Animal(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
    }

    public void Injure()
    {
        if (Is_Injured)
            Printer.Print_Cannot(this, Actions.Injured);
        else
        {
            Printer.Print_Action(this, Actions.Injured);
            Is_Injured = true;
        }
    }

    public void Heal()
    {
        if (Is_Injured)
        {
            Printer.Print_Action(this, Actions.Healing);
            Is_Injured = false;
        }
        else
            Printer.Print_Cannot(this, Actions.Heal);
    }

    public override IEnumerable<Actions> Get_Actions()
    {
        if (Is_Injured)
            yield return Actions.Heal;
        else
            yield return Actions.Injure;
        foreach (var action in base.Get_Actions())
            yield return action;
    }
}