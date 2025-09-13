using System.Text.Json;

namespace Step_6_Validation;

public static class Components_Factory
{
    private const string Path = ".\\Data\\{0}.json";
    private const string Type_Format = "Step_6_Validation.{0}";

    public static IComponents Create(object file_name)
    {
        var components_name = Get_Components_Name(file_name);
        var components = new Components();
        foreach (var component_name in components_name)
            components.Add(Get_Component(component_name));
        return components;
    }

    private static IComponent Get_Component(string name)
    {
        var type = Type.GetType(string.Format(Type_Format, name));
        return (IComponent)Activator.CreateInstance(type);
    }

    public static string[] Get_Components_Name(object file_name)
    {
        var file_path = string.Format(Path, file_name);
        var content = File.ReadAllText(file_path);
        return JsonSerializer.Deserialize<string[]>(content)!;
    }
}
