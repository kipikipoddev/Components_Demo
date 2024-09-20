
namespace Step_6_Validation;

public record Print_Cant_Command(IComponents Components, Actions Action) : Command(Components)
{
}