using Step_5_Files.Commands;
using Step_5_Files.Core;
using Step_5_Files.Data;

namespace Step_5_Files;

public class Program
{
    private static void Main(string[] args)
    {
        var entities = Components_Data.Get_Components(".\\Files");
        foreach (var entity in entities)
            Do_Actions(entity);
    }

    private static void Do_Actions(IComponents components)
    {
        if (components.Can<Walk_Command>())
            new Walk_Command(components);

        if (components.Can<Make_Sound_Command>())
            new Make_Sound_Command(components);

        if (components.Can<Swim_Command>())
            new Swim_Command(components);
    }
}