using Step_5_Files.Attributes;
using Step_5_Files.Core;
using System.Reflection;

namespace Step_5_Files.Data;

public record Component_Data(string Name, string[] Components)
{
    private static Dictionary<string, Type> name_to_type = [];

    public Components Map()
    {
        Init();
        var components = new Components();
        components.Add(new Name_Component(Name));
        foreach (var component in Components)
        {
            var comp = Activator.CreateInstance(name_to_type[component]);
            components.Add((IComponent)comp!);
        }

        return components;
    }

    private void Init()
    {
        if (name_to_type.Any())
            return;
        var types = GetType().Assembly.GetTypes();
        foreach (var type in types)
        {
            Add_Name(type);
            Add_Generic(type);
        }
    }

    private static void Add_Name(Type type)
    {
        var attribute = type.GetCustomAttribute<Component_NameAttribute>();
        if (attribute != null)
            name_to_type[attribute.Name] = type;
    }

    private static void Add_Generic(Type type)
    {
        var attributes = type.GetCustomAttributes<Generic_Component_NameAttribute>();
        foreach (var attribute in attributes)
            name_to_type[attribute.Name] = type.MakeGenericType(attribute.Type);
    }
}