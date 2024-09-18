
namespace Step_3_Commands;

public record Set_Disabled_Command(IComponents Components, bool Value) : Command(Components)
{
}