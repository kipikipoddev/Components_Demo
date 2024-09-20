
namespace Step_5_Actions;

public record Print_Cant_Command(IComponents Components, Actions Action) : Command(Components)
{
}