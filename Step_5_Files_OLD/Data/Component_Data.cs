using Step_5_Files.Attributes;
using Step_5_Files.Core;
using System.Reflection;

namespace Step_5_Files.Data;

public record Component_Data(string Name, string[] Components)
{
    private static Dictionary<string, Type> name_to_type;

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
        if (name_to_type != null)
            return;
        name_to_type = new();
        var types = GetType().Assembly.GetTypes();
        foreach (var type in types)
        {
            var name_attribute = type.GetCustomAttribute<Component_NameAttribute>();
            if (name_attribute != null)
                name_to_type[name_attribute.Name] = type;
        }
    }
}