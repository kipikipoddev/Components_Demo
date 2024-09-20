
namespace Step_6_Validation;

public interface IWalk_Component : IAction_Component
{
    bool Can_Walk();
    void Walk();
}