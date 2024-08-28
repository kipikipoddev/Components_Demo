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
        Speed = Speed.Slow;
    }

    protected override void Write_Action(string action)
    {
        var extra = Is_Injured ? " painfully" : string.Empty;
        Console.WriteLine($"{Name} is {action}{extra}");
    }
}