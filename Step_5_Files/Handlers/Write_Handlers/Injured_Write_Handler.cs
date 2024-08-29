namespace Step_5_Files.Sound_Handlers;

public class Injured_Write_Handler : Write_Handler
{
    protected override void Write_Action(string action)
    {
        if (Parent.Is_Injured())
            Console.WriteLine($"{Parent.Name()} is {action} painfully");
        else
            base.Write_Action(action);
    }
}