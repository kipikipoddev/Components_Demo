
namespace Step_4_Files;

public interface IComponent
{
    IComponents Parent { get; }

    void Set_Parent(IComponents components);
}