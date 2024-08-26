namespace Step_3_Components;

public class Program
{
    private static void Main(string[] args)
    {
        var entities = new IComponents[]
        {
            new Cat(),
            new Dog(),
            new Robot(),
            new Robot_Dog(),
            new Robot_Cat_Dog()
        };

        foreach (var entity in entities)
            Walk_And_Sound(entity);
    }

    private static void Walk_And_Sound(IComponents components)
    {
        components.Walk();
        components.Make_Sound();
    }
}