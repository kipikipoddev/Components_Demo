using Step_3_Commands;

namespace Step_3_Commands_Tests;

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
