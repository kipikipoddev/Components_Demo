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

    private static void Do_All(IComponents component)
    {
        Console.WriteLine($" -- {component.Name()} -- ");
        component.Write_Actions();
        Do_Actions(component);
        component.Injure();
        Do_Actions(component);
        Console.WriteLine();
    }

    private static void Do_Actions(IComponents component)
    {
        component.Walk();
        component.Make_Sound();
        component.Swim();
    }
}