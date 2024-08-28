using Step_4_Commands.Commands;
using Step_4_Commands.Core;
using Step_4_Commands.Entities;

namespace Step_4_Commands;

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
        if (components.Can<Walk_Command>())
            new Walk_Command(components, Enums.Speed.Slow);

        if (components.Can<Make_Sound_Command>())
            new Make_Sound_Command(components);

        if (components.Can<Swim_Command>())
            new Swim_Command(components);
    }
}