using Step_5_Files.Commands;
using Step_5_Files.Core;
using Step_5_Files.Resources;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Step_5_Files;

public class Program
{
    private static Regex File_Name_Regex = new Regex(@"(?<=\\)[^\\]+(?=\.json)");

    private static void Main(string[] args)
    {
        var resources = Get_Resources(".\\Files\\Entities").ToList();
        var entities = resources.Select(r => r.Map().Validate().Map());

        foreach (var entity in entities)
            Walk_And_Sound(entity);
    }

    private static IEnumerable<Entity_Resource> Get_Resources(string path)
    {
        var file_paths = Directory.GetFiles(path);
        foreach (var file_path in file_paths)
        {
            var content = File.ReadAllText(file_path);
            var resource = JsonSerializer.Deserialize<Entity_Resource>(content)!;
            resource.Set_Name(file_path);
            yield return resource;
        }
    }

    private static void Walk_And_Sound(IComponents components)
    {
        new Walk_Command(components);
        new Sound_Command(components);
    }
}