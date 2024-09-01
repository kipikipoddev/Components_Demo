using Components_Demo;

namespace Step_2_Components_Tests;

public abstract class UnitTest_Base
{
    protected IComponents Subject;

    [SetUp]
    public virtual void Setup()
    {
        Subject = new Components()
            .Add(new Test_Printer());
        Add();
    }

    protected abstract void Add();

    protected void Test_Was_Action(string action)
    {
        Test_Action(action, "was");
    }

    protected void Test_Cannot_Action(string action)
    {
        Test_Action(action, "cannot");
    }

    protected void Test_Action(string action, string middle)
    {
        var action_str = action.ToString().ToLower();
        var expected = $"{Subject.Name()} {middle} {action_str}";
        var actual = Subject.Get<Test_Printer>().Messages.LastOrDefault();
        Assert.That(actual, Is.EqualTo(expected));
    }
}