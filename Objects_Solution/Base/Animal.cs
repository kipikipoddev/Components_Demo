
namespace Objects_Solution;

public abstract class Animal : Entity, IAnimal
{
    public bool Is_Injured { get; private set; }

    public Animal(IAction_Printer printer)
        : base(printer)
    {
    }

    public virtual void Injure()
    {
        if (Can_Injure())
            Printer.Print_Action(this, Actions.Injured);
        else
            Printer.Print_Cannot(this, Actions.Injure);
        Is_Injured = true;
    }

    public void Heal()
    {
        if (Can_Heal())
            Printer.Print_Action(this, Actions.Healed);
        else
            Printer.Print_Cannot(this, Actions.Heal);
        Is_Injured = false;
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