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

    protected void Test_Was_Action(Actions action)
    {
        Test_Action("was", action);
    }

    protected void Test_Cannot_Action(Actions action)
    {
        Test_Action("cannot", action);
    }

    private void Test_Action(string middle, Actions action)
    {
        var action_str = action.ToString().ToLower();
        var expected = $"{Subject.Name} {middle} {action_str}";
        var actual = Creator.Printer.Messages.Last();
        Assert.That(actual, Is.EqualTo(expected));
    }
}