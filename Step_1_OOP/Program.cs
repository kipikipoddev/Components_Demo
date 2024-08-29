namespace Step_1_OOP;

public class Program
{
    private static IAction_Printer printer;

    private static void Main(string[] args)
    {
        printer = new Console_Printer();
        var entities = new IEntity[]
        {
            new Cat(printer,Speed.Fast),
            new Dog(printer,Speed.Normaly),
            new Fish(printer,Speed.Fast),
            new Human_Robot(printer,Speed.Slowly),
            new Robot_Dog(printer,Speed.Normaly),
            new Fish_Robot(printer,Speed.Fast),
        };

        foreach (var entity in entities)
            Do_All(entity);
    }

    private static void Do_All(IEntity entity)
    {
        Console.WriteLine($" -- {entity.Name} -- ");
        printer.Print_Actions(entity);
        Do_Actions(entity);

        if (entity is IAnimal animal)
        {
            animal.Injure();
            animal.Injure();
            printer.Print_Actions(entity);
            animal.Heal();
            printer.Print_Actions(entity);
        }
        else if (entity is IRobot robot)
        {
            robot.Charge();
            printer.Print_Actions(entity);
            Do_Actions(entity);
        }

        Console.WriteLine();
    }

    private static void Do_Actions(IEntity entity)
    {
        entity.Walk();
        entity.Make_Sound();
        entity.Swim();
    }
}