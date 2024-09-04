
using Step_4_Files;

namespace Step_4_Files_Tests;

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
