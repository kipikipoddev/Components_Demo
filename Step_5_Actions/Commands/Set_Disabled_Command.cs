
namespace Step_5_Actions;

public record Set_Disabled_Command(IComponents Components, bool Value) : Command(Components)
{
}