namespace Step_1_OOP;

public class Console_Printer : Action_Printer
{
    protected override void Print(string message)
    {
        Console.WriteLine(message);
    }
}