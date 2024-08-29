using System.Text.Json;

namespace Step_5_Files.Data;

public static class Components_Data
{
    public static IEnumerable<Components> Get_Components(string path)
    {
        return Directory.GetFiles(path)
            .Select(Get_Data)
            .Select(r => r.Map());
    }

    private static Component_Data Get_Data(string file_path)
    {
        var name = Get_Name(file_path);
        var content = File.ReadAllText(file_path);
        var properties = JsonSerializer.Deserialize<Dictionary<string, object>>(content)!;
        return new Component_Data(name, properties);
    }

    private static string Get_Name(string path)
    {
        var index = path.LastIndexOf('\\') + 1;
        return path.Substring(index, path.Length - index - 5);
    }
}
