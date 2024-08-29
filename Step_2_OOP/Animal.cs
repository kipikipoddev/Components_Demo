namespace Step_2_OOP;

public abstract class Animal : Entity
{
    public Animal(Speed speed)
        : base(speed)
    {
    }

    public override void Injure()
    {
        base.Injure();
        base.Write_Action("injured");
        Can_Walk = false;
        Can_Swim = false;
    }

    protected override void Write_Action(string action)
    {
        var extra = Is_Injured ? " painfully" : string.Empty;
        Console.WriteLine($"{Name} is {action}{extra}");
    }
}