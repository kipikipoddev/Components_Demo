using Step_5_Actions;

namespace Step_5_Actions_Tests;

public abstract class UnitTest_Base
{
    protected IComponents Subject { get; private set; }

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

    protected static void Assert_Equivalent<T>(IEnumerable<T> list, params T[] objects)
    {
        Assert.That(list, Is.EquivalentTo(objects));
    }

    protected static void Assert_False(bool actual)
    {
        Assert.That(actual, Is.False);
    }

    protected static void Assert_Printed(string message)
    {
        Assert.That(Test_Printer.Message, Is.EqualTo(message));
    }
}