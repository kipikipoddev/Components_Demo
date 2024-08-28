namespace Step_5_Files.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class Generic_Component_NameAttribute : Attribute
{
    public string Name { get; }
    public Type Type { get; }

    public Generic_Component_NameAttribute(string name, Type type)
    {
        Name = name;
        Type = type;
    }
}