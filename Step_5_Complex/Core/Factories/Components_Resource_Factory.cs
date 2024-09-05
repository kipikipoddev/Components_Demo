using System.Text.Json;

namespace Step_5_Complex;

public static class Components_Resource_Factory
{
    private const string Path = ".\\Data\\";

    public static IEnumerable<Components_Resource> Get_All_Resources()
    {
        foreach (var file_path in Directory.GetFiles(Path))
            yield return Get_Resource_By_Path(file_path);
    }

    public static Components_Resource Get_Resource(string name)
    {
        return Get_Resource_By_Path(Path + name + ".json");
    }

    private static Components_Resource Get_Resource_By_Path(string file_path)
    {
        var content = File.ReadAllText(file_path);
        return JsonSerializer.Deserialize<Components_Resource>(content)!;
    }
}