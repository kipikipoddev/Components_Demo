namespace Step_2_OOP;

public class Animal : Entity, IAnimal
{
    public bool Is_Injured { get; private set; }

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
             Printer.Print_Cannot(this, Actions.Healed);
        }
        else
            Printer.Print_Cannot(this, Actions.Heal);
    }
}