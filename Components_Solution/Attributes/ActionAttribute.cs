namespace Components_Solution;

public class ActionAttribute : Attribute
{
    public Actions Name { get; }
    public Actions Did { get; }
    public ActionAttribute(Actions name, Actions did)
    {
        Name = name;
        Did = did;
    }
}
