
namespace Components_Solution;

public interface IAction_Component : IComponent
{
    Actions Name { get; }
    bool Is_Disabled { get; }
}