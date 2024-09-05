
namespace Step_5_Complex;

public interface IInjure_Component : IComponent
{
    bool Is_Alive { get; }
    bool Is_Injured { get; }
    int Hp { get; }
    int Max_Hp { get; }
}