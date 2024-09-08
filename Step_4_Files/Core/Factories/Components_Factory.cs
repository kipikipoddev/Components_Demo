namespace Step_4_Files;

public static class Components_Factory
{
    private static Dictionary<string, Type> name_to_type;

    public static IComponents Create(string file_name)
    {
        Init();
        var resource = Components_Resource_Factory.Get_Resource(file_name);
        var components = new Components();
        foreach (var component_name in resource)
        {
            var type = name_to_type[component_name];
            var component = (IComponent)Activator.CreateInstance(type, []);
            components.Add(component);
        }
        components.Add(new Name_Component(file_name));
        return components;
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