
namespace Step_1_Objects;

public abstract class Animal : Entity, IAnimal
{
    public bool Is_Injured { get; private set; }

    public Animal(IAction_Printer printer, string name)
        : base(printer, name)
    {
    }

    public override IEnumerable<Actions> Available_Actions
    {
        get
        {
            yield return Actions.Injure;
            yield return Actions.Heal;
        }
    }

    public virtual void Injure()
    {
        if (Can_Injure())
        {
            Is_Injured = true;
            Printer.Print_Action(this, Actions_Description.Injured);
        }
        else
            Printer.Print_Cant(this, Actions.Injure);
    }

    public void Heal()
    {
        if (Can_Heal())
        {
            Is_Injured = false;
            Printer.Print_Action(this, Actions_Description.Healed);
        }
        else
            Printer.Print_Cant(this, Actions.Heal);
    }

    public bool Can_Injure()
    {
        return !Is_Injured;
    }

    public bool Can_Heal()
    {
        return Is_Injured;
    }
}