namespace Step_2_OOP;

public abstract class Entity : IEntity
{
    public string Name { get; set; }

    public Entity()
    {
        Name = GetType().Name;
    }

    public virtual bool Can_Swim => false;
    public virtual bool Can_Make_Sound => false;
    public virtual bool Can_Walk => false;

    public virtual void Swim(Speed speed)
    {
        throw new NotImplementedException();
    }

    public virtual void Make_Sound()
    {
        throw new NotImplementedException();
    }

    public virtual void Walk(Speed speed)
    {
        throw new NotImplementedException();
    }

    protected void Write(string message)
    {
        Console.WriteLine(Name + " is " + message);
    }

    protected string Get_Speed(Speed speed)
    {
        return speed switch
        {
            Speed.Slow => "slowly ",
            Speed.Fast => "fast ",
            _ => string.Empty,
        };
    }
}