namespace Step_2_Components;

public class Name_Model : IName_Model
{
    public string Name { get; }

    public Name_Model(string name)
    {
        Name = name;
    }
}