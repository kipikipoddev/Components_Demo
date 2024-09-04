
namespace Step_3_Commands;

public interface IComponent
{
    IComponents Parent { get; }

    void Set_Parent(IComponents components);
}