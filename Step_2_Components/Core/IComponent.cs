
namespace Step_2_Components;

public interface IComponent
{
    IComponents Parent { get; }

    void Set_Parent(IComponents components);
}