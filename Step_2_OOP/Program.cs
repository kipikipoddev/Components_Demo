namespace Step_2_OOP;

public class Program
{
    private static void Main(string[] args)
    {
        var entities = new IEntity[]
        {
            new Cat(Speed.Fast),
            new Dog(Speed.Normal),
            new Fish(Speed.Fast),
            new Robot(Speed.Slow),
            new Robot_Dog(Speed.Normal),
            new Fish_Robot(Speed.Fast),
        };

        foreach (var entity in entities)
            Do_All(entity);
    }

    private static void Do_All(IEntity entity)
    {
        Console.WriteLine($" -- {entity.Name} -- ");
        entity.Write_Actions();
        Do_Actions(entity);
        entity.Injure();
        entity.Write_Actions();
        Do_Actions(entity);
        Console.WriteLine();
    }

    private static void Do_Actions(IEntity entity)
    {
        entity.Walk();
        entity.Make_Sound();
        entity.Swim();
    }
}