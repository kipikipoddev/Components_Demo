using System.Text.Json;

namespace Step_4_Files;

public static class Components_Factory
{
    private static Dictionary<string, Type> name_to_type;

    public static IComponents Create(string file_path)
    {
        Init();
        var file = Get_Resource(file_path);
        var components = new Components();
        foreach (var component_name in file.Keys)
        {
            var type = name_to_type[component_name];
            var ctor_args = Get_Ctor_Args(file[component_name], type).ToArray();
            var component = (IComponent)Activator.CreateInstance(type, ctor_args)!;
            components.Add(component);
        }
        return components;
    }

    public static Components_Resource Get_Resource(string file_path)
    {
        var content = File.ReadAllText(file_path);
        return JsonSerializer.Deserialize<Components_Resource>(content)!;
    }

    private static IEnumerable<object> Get_Ctor_Args(JsonElement[] args, Type type)
    {
        var index = 0;
        foreach (var ctor_type in Get_Ctor_Args_Type(type))
        {
            var value = args[index++].ToString();
            yield return Convert.ChangeType(value, ctor_type)!;
        }
    }

    private static IEnumerable<Type> Get_Ctor_Args_Type(Type type)
    {
        return type.GetConstructors().First()
            .GetParameters()
            .Select(p => p.ParameterType);
    }

    private static void Init()
    {
        if (name_to_type == null)
            name_to_type = typeof(Components_Factory)
                .Assembly.GetTypes()
                .Where(t => t.IsAssignableTo(typeof(IComponent)))
                .ToDictionary(t => t.Name, t => t);
    }
}