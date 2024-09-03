using Components_Basic_Solution;

namespace Components_Solution_Tests;

public abstract class UnitTest_Base
{
    protected IComponents Subject;

    [SetUp]
    public virtual void Setup()
    {
        Test_Printer.Reset();
        Subject = Get_Subject();
        Subject.Add(new Test_Printer());
    }

    protected abstract IComponents Get_Subject();

    protected static void Assert_True(bool actual)
    {
        Assert.That(actual, Is.True);
    }

    protected static void Assert_False(bool actual)
    {
        Assert.That(actual, Is.False);
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
        var expected = $"{Subject.Get<IName_Component>().Name} {middle} {action_str}";
        var actual = Test_Printer.Message;
        Assert.That(actual, Is.EqualTo(expected));
    }
}