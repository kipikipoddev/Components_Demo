
namespace Components_Basic_Solution;

public class Component : IComponent
{
    public IComponents Parent { get; private set; }

    public virtual void Set_Parent(IComponents components)
    {
        Parent = components;
    }
}