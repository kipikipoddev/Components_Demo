using Objects_Solution;

namespace Objects_Solution_Tests;

public class UnitTest_Base<T>
    where T : class, IEntity
{
    protected T Subject;

    [SetUp]
    public virtual void Setup()
    {
        Creator.Printer.Clear();
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
        Assert.That(Creator.Printer.Message, Is.EqualTo(expected));
    }
}