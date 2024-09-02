using Objects_Solution;

namespace Objects_Solution_Tests;

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
