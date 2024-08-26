namespace Step_2_OOP;

public class Program
{
    private static void Main(string[] args)
    {
        var entities = new Entity[]
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

    private static void Walk_And_Sound(Entity entity)
    {
        entity.Walk();
        entity.Make_Sound();
    }
}