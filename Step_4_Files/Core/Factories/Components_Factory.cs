using System.Text.Json;

namespace Step_4_Files;

public static class Components_Factory
{
    private const string Path = ".\\Data\\{0}.json";
    private static Dictionary<string, Type> name_to_type;

    public static IComponents Create(object file_name)
    {
        Init();
        var components_name = Get_Resource(string.Format(Path, file_name));
        var components = new Components();
        foreach (var component_name in components_name)
            components.Add(Get_Component(component_name));
        components.Add(new Name_Component(file_name.ToString()));
        return components;
    }

    private static IComponent Get_Component(string name)
    {
        return (IComponent)Activator.CreateInstance(name_to_type[name], []);
    }

    public static string[] Get_Resource(string file_path)
    {
        var content = File.ReadAllText(file_path);
        return JsonSerializer.Deserialize<string[]>(content)!;
    }

    private static void Init()
    {
        if (name_to_type == null)
            name_to_type = typeof(Components_Factory).Assembly.GetTypes()
                .Where(t => t.IsAssignableTo(typeof(IComponent)))
                .ToDictionary(t => t.Name, t => t);
    }
}