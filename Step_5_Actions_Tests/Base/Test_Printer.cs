
using Step_5_Actions;

namespace Step_5_Actions_Tests;

public class Test_Printer : Print_Component
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
