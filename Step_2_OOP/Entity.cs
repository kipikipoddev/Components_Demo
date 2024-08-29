namespace Step_2_OOP;

public abstract class Entity : IEntity
{
    protected Speed Speed { get; set; }
    protected bool Is_Injured { get; set; }
    protected string Type { get; set; }

    public string Name { get; set; }
    public bool Can_Swim { get; protected set; }
    public bool Can_Make_Sound { get; protected set; }
    public bool Can_Walk { get; protected set; }

    public Entity(Speed speed)
    {
        Name = GetType().Name;
        Speed = speed;
        Type = GetType().Name.ToLower();
    }

    public virtual void Make_Sound()
    {
        Write_Cannot("make sound");
    }

    public virtual void Swim()
    {
        if (Can_Swim)
            Write_Action_Like("swiming");
        else
            Write_Cannot("swim");
    }

    public virtual void Walk()
    {
        if (Can_Walk)
            Write_Action_Like("walking");
        else
            Write_Cannot("walk");
    }

    public virtual void Injure()
    {
        Is_Injured = true;
    }

    public void Write_Actions()
    {
        var actions = (Can_Walk ? "Walk, " : string.Empty) +
                    (Can_Make_Sound ? "Make sound, " : string.Empty) +
                    (Can_Swim ? "Swim, " : string.Empty);
        if (actions.Length == 0)
            Console.WriteLine(Name + " cannot do anything");
        else
        {
            actions = actions.Remove(actions.Length - 2, 2);
            Console.WriteLine(Name + " can: " + actions);
        }
    }

    protected virtual void Write_Action(string action)
    {
        Console.WriteLine($"{Name} is {action}");
    }

    protected void Write_Action_Like(string action)
    {
        Console.WriteLine($"{Name} is {action}{Get_Speed()} like a {Type}");
    }

    protected void Write_Cannot(string action)
    {
        Console.WriteLine(Name + " cannot " + action);
    }

    protected string Get_Speed()
    {
        return Speed switch
        {
            Speed.Slow => " slowly",
            Speed.Fast => " fast",
            _ => string.Empty,
        };
    }
}