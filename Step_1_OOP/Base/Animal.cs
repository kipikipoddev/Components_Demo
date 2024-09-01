
namespace Components_Demo;

public abstract class Animal : Entity, IAnimal
{
    public bool Is_Injured { get; private set; }

    public Animal(IAction_Printer printer)
        : base(printer)
    {
    }

    public void Injure()
    {
        if (Is_Injured)
            Printer.Print_Cannot(this, Actions.Injure);
        else
            Printer.Print_Action(this, Actions.Injured);
        Is_Injured = true;
    }

    public void Heal()
    {
        if (Is_Injured)
            Printer.Print_Action(this, Actions.Healed);
        else
            Printer.Print_Cannot(this, Actions.Heal);
        Is_Injured = false;
    }

    public override IEnumerable<Actions> Get_Actions()
    {
        if (Is_Injured)
            yield return Actions.Heal;
        else
            yield return Actions.Injure;
    }
}