using Step_1_Objects;

namespace Step_1_Objects_Tests;

public class Test_Printer : Action_Printer
{
    public string Message { get; private set; }

    public void Clear()
    {
        Message = null;
    }

    protected override void Print(string message)
    {
        Message = message;
    }
}
