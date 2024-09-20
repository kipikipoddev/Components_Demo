

namespace Step_6_Validation;

public record Swim_Command(IComponents Components) : Action_Command(Components, Actions.Swim)
{
}