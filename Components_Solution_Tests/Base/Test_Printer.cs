using Components_Solution;

namespace Components_Solution_Tests;

public class Test_Printer : Printer_Handler
{
    public static string Message { get; private set; }

    public static void Reset()
    {
        Message = null;
    }

    protected override void Print(string message)
    {
        Message = message;
    }
}
