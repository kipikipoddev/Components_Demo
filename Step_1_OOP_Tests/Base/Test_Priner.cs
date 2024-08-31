using Step_1_OOP;

namespace Step_1_OOP_Tests;

public class Test_Priner : Action_Printer
{
    private readonly List<string> messages = new();

    public IEnumerable<string> Messages => messages;

    protected override void Print(string message)
    {
        messages.Add(message);
    }
}
