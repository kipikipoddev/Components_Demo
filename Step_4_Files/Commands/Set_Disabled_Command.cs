
namespace Step_4_Files;

public record Set_Disabled_Command(IComponents Components, bool Value) : Command(Components)
{
}