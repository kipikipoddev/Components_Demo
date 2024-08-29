using Step_5_Files.Commands;
using Step_5_Files.Data;
using Step_5_Files.Enums;

namespace Step_5_Files;

public class Program
{
    private static void Main(string[] args)
    {
        var entities = Components_Data.Get_Components(".\\Files");
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