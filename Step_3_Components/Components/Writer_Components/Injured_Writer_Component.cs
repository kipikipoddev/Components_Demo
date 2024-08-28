namespace Step_3_Components;

public class Injured_Writer_Component : Writer_Component
{
    public override void Write_Action(string action)
    {
        var extra = Parent.Is_Injured() ? " painfully" : string.Empty;
        Console.WriteLine($"{Parent.Name()} is {action}{extra}");
    }
}