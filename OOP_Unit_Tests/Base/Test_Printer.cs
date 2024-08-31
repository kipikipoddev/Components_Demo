using Components_Demo;

namespace OOP_Unit_Tests;

public class Test_Printer : Action_Printer
{
    private readonly List<string> messages = new();

    public IEnumerable<string> Messages => messages;

    protected override void Print(string message)
    {
        messages.Add(message);
    }
}
