using Components_Demo;

namespace Step_2_Components_Tests;

public class Test_Printer : Printer_Component
{
    private readonly List<string> messages = new();

    public IEnumerable<string> Messages => messages;

    protected override void Print(string message)
    {
        messages.Add(message);
    }
}
