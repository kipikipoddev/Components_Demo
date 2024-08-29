namespace Step_5_Files.Attributes;

public class Component_NameAttribute : Attribute
{
    public string Name { get; }

    public Component_NameAttribute(string name)
    {
        Name = name;
    }
}