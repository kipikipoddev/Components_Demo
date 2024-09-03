
namespace Components_Better_Solution;

public class Add_ComponentAttribute : Attribute
{
    public Type[] Types { get; }

    public Add_ComponentAttribute(params Type[] types)
    {
        Types = types;
    }
}