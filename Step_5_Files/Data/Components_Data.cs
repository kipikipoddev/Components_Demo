using Step_5_Files.Core;
using System.Text.Json;

namespace Step_5_Files.Data;

public static class Components_Data
{
    public static IEnumerable<Components> Get_Components(string path)
    {
        return Get_Components_Data(path).Select(r => r.Map());
    }

    private static IEnumerable<Component_Data> Get_Components_Data(string path)
    {
        var file_paths = Directory.GetFiles(path);
        foreach (var file_path in file_paths)
        {
            var content = File.ReadAllText(file_path);
            var Components = JsonSerializer.Deserialize<string[]>(content)!;
            yield return new Component_Data(Get_Name(file_path), Components);
        }
    }

    private static string Get_Name(string path)
    {
        var index = path.LastIndexOf('\\') + 1;
        return path.Substring(index, path.Length - index - 5);
    }
}
