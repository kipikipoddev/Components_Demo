using Step_3_Components.Enums;

namespace Step_3_Components;

public class Program
{
    private static void Main(string[] args)
    {
        var entities = new IComponents[]
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

    private static void Do_All(IComponents entity)
    {
        Console.WriteLine($" -- {entity.Name()} -- ");
        entity.Write_Actions();
        Do_Actions(entity);
        entity.Injure();
        Do_Actions(entity);
        Console.WriteLine();
    }

    private static void Do_Actions(IComponents entity)
    {
        entity.Walk();
        entity.Make_Sound();
        entity.Swim();
    }
}