namespace Step_2_OOP;

public abstract class Entity
{
    public string Name { get; set; }
    
    public Entity()
    {
        Name = GetType().Name.Replace('_', ' ');
    }

    public abstract void Make_Sound();

    public virtual void Walk()
    {
        Write("Walking");
    }

    protected void Write(string message)
    {
        Console.WriteLine(Name + " " + message);
    }
}