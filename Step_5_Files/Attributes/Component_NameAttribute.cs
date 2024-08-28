namespace Step_5_Files.Attributes;

public class Component_NameAttribute : Attribute
{
    public string Action { get; }
    public string Name { get; }

    public Component_NameAttribute(string action, string name)
    {
        Action = action;
        Name = name;
    }
}