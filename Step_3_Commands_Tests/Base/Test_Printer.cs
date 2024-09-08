using Step_3_Commands;

namespace Step_3_Commands_Tests;

public class Test_Printer : Print_Component
{
    public static string Last_Message { get; private set; }

    public static void Reset()
    {
        Last_Message = null;
    }

    protected override void Print(string message)
    {
        Last_Message = message;
    }
}
