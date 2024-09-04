
namespace Step_5_Complex;

public interface IComponent
{
    IComponents Parent { get; }

    void Set_Parent(IComponents components);
}