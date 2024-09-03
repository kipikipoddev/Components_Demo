using Components_Better_Solution;

namespace Components_Better_Solution_Tests;

public class Test_Printer : Print_Handler
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
