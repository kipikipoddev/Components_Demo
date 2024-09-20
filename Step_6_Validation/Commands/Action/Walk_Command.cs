

namespace Step_6_Validation;

public record Walk_Command(IComponents Components) : Action_Command(Components, Actions.Walk)
{
}