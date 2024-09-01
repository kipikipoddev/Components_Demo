
namespace Components_Demo;

public interface IComponent
{
    IComponents Parent { get; }

    void Set_Parent(IComponents components);
}