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

    protected static void Assert_True(bool action)
    {
        Assert.That(action, Is.True);
    }

    protected static void Assert_False(bool action)
    {
        Assert.That(action, Is.False);
    }

    protected void Assert_Was_Printed(Actions action)
    {
        Assert_Action_Printed("was", action);
    }

    protected void Assert_Cant_Printed(Actions action)
    {
        Assert_Action_Printed("can't", action);
    }

    private void Assert_Action_Printed(string middle, Actions action)
    {
        var action_str = action.ToString().ToLower();
        var expected = $"{Subject.Name} {middle} {action_str}";
        Assert.That(Creator.Printer.Message, Is.EqualTo(expected));
    }
}