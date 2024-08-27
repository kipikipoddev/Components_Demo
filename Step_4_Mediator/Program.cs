using Step_4_Mediator.Commands;
using Step_4_Mediator.Core;
using Step_4_Mediator.Entities;

namespace Step_4_Mediator;

public class Program
{
    private static void Main(string[] args)
    {
        var entities = new IComponents[]
        {
            new Cat(),
            new Dog(),
            new Fish(),
            new Robot(),
            new Robot_Dog(),
            new Fish_Robot()
        };

        foreach (var entity in entities)
            Do_Actions(entity);
    }

    private static void Do_Actions(IComponents components)
    {
        new Walk_Command(components);
        new Make_Sound_Command(components);
        new Swim_Command(components);
    }
}