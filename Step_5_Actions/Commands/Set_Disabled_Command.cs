
namespace Step_5_Final;

public record Set_Disabled_Command(IComponents Components, bool Value) : Command(Components)
{
}