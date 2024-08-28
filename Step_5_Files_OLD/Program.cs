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
        new Walk_Command(components);
        new Sound_Command(components);
        new Swim_Command(components);
    }
}