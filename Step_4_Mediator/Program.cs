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
            new Robot(),
            new Robot_Dog(),
            new Robot_Cat_Dog()
        };

        foreach (var entity in entities)
            Walk_And_Sound(entity);
    }

    private static void Walk_And_Sound(IComponents components)
    {
        new Walk_Command(components);
        new Sound_Command(components);
    }
}