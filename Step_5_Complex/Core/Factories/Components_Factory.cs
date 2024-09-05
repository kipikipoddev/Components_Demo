namespace Step_5_Complex;

public static class Components_Factory
{
    private static Dictionary<string, Type> name_to_type;

    public static IComponents Create(string file_name)
    {
        Init();
        var file = Components_Resource_Factory.Get_Resource(file_name);
        var components = new Components();
        foreach (var component_name in file.Keys)
        {
            var type = name_to_type[component_name];
            var ctor_args = Get_Ctor_Args(file, component_name, type);
            var component = (IComponent)Activator.CreateInstance(type, ctor_args)!;
            components.Add(component);
        }
        components.Add(new Name_Component(file_name));
        return components;
    }

    private static object[] Get_Ctor_Args(Dictionary<string, object[]> file, string component_name, Type type)
    {
        var ctor_args_type = Get_Ctor_Args_Type(type);
        var ctor_args = new object[ctor_args_type.Length];
        for (int i = 0; i < ctor_args.Length; i++)
            ctor_args[i] = Convert.ChangeType(file[component_name][i].ToString(), ctor_args_type[i])!;
        return ctor_args;
    }

    private static Type[] Get_Ctor_Args_Type(Type type)
    {
        return type.GetConstructors().First().GetParameters().Select(p => p.ParameterType).ToArray();
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