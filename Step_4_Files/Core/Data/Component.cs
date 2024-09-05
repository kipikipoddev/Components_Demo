
namespace Step_4_Files;

public class Component : IComponent
{
    public IComponents Parent { get; private set; }

    public virtual void Set_Parent(IComponents parent)
    {
        Parent = parent;
    }
}