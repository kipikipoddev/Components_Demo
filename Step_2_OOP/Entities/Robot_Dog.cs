namespace Step_2_OOP;

public class Robot_Dog : Robot, IDog
{
    private readonly Dog dog;

    public override bool Can_Swim => Is_Charged;
    public bool Can_Bark => Is_Charged;
    public bool Is_Injured => false;
    public bool Can_Injure => false;
    public bool Can_Heal => false;

    public Robot_Dog(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
        dog = new Dog(printer, speed);
    }

    public void Bark()
    {
        if (Is_Charged)
            Charges--;
        dog.Bark();
    }

    public override IEnumerable<Actions> Get_Actions()
    {
        if (Is_Charged)
            yield return Actions.Bark;
        foreach (var action in base.Get_Actions())
            yield return action;
    }

    public void Injure()
    {
        dog.Injure();
    }

    public void Heal()
    {
        dog.Heal();
    }
}