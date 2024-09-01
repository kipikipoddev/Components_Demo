using Components_Demo;

namespace Step_1_OOP_Tests;

public class UnitTest_Base<T>
    where T : class, IEntity
{
    protected T Subject;

    [SetUp]
    public virtual void Setup()
    {
        Subject = Creator.Create<T>();
    }

    protected void Test_Actions(params Actions[] actions)
    {
        var entity_actions = Subject.Get_Actions().ToArray();
        Assert.That(entity_actions.Length, Is.EqualTo(actions.Length));
        foreach (var entity_action in entity_actions)
            Assert.True(actions.Contains(entity_action));
    }

    protected void Test_Action_Message(Actions action)
    {
        var actual = Creator.Printer.Messages.Last();
        Test_Was_Action(actual, action);
    }

    protected void Test_Cannot_Action(Actions action)
    {
        var actual = Creator.Printer.Messages.Last();
        Test_Cannot_Action(actual, action);
    }

    protected void Test_Was_Action(string actual, Actions action)
    {
        Test_Action(actual, action, "was");
    }

    protected void Test_Cannot_Action(string actual, Actions action)
    {
        Test_Action(actual, action, "cannot");
    }

    protected void Test_Action(string actual, Actions action, string middle)
    {
        var action_str = action.ToString().ToLower();
        var expected = $"{Subject.Name} {middle} {action_str}";
        Assert.That(actual, Is.EqualTo(expected));
    }
}