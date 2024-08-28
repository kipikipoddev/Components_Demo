using Step_4_Commands.Commands;
using Step_4_Commands.Enums;

namespace Step_4_Commands;

public class Program
{
    private static void Main(string[] args)
    {
        var entities = new IComponents[]
        {
            new Cat(Speed_Type.Fast),
            new Dog(Speed_Type.Normal),
            new Fish(Speed_Type.Fast),
            new Robot(Speed_Type.Slow),
            new Robot_Dog(Speed_Type.Normal),
            new Fish_Robot(Speed_Type.Fast),
        };

        foreach (var entity in entities)
            Do_All(entity);
    }

    private static void Do_All(IComponents entity)
    {
        Console.WriteLine($" -- {entity.Name()} -- ");
        entity.Write_Actions();
        Do_Actions(entity);
        new Injure_Command(entity);
        Do_Actions(entity);
        Console.WriteLine();
    }

    private static void Do_Actions(IComponents entity)
    {
        new Walk_Command(entity);
        new Make_Sound_Command(entity);
        new Swim_Command(entity);
    }
}