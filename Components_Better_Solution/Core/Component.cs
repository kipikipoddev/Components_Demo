
namespace Components_Better_Solution;

public interface IComponent
{
    IComponents Parent { get; }

    void Set_Parent(IComponents components);
}