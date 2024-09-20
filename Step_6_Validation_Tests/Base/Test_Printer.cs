
using Step_6_Validation;

namespace Step_6_Validation_Tests;

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
