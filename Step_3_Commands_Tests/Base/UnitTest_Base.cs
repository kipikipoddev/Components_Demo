using Step_3_Commands;

namespace Step_3_Commands_Tests;

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

    protected static void Assert_Printed(string mesage)
    {
        Assert.That(Test_Printer.Last_Message, Is.EqualTo(mesage));
    }
}