using System.Text.Json;

namespace Step_4_Files;

public static class File_Factory
{
    private const string Path = ".\\Files\\";

    public static IEnumerable<Dictionary<string, object[]>> Get_All_Files()
    {
        foreach (var file_path in Directory.GetFiles(Path))
            yield return Get_File_Path(file_path);
    }

    public static Dictionary<string, object[]> Get_File(string name)
    {
        return Get_File_Path(Path + name + ".json");
    }

    private static Dictionary<string, object[]> Get_File_Path(string file_path)
    {
        var content = File.ReadAllText(file_path);
        return JsonSerializer.Deserialize<Dictionary<string, object[]>>(content)!;
    }
}