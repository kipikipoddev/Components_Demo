using Step_2_OOP;

namespace Step_2_OOP_Tests;

public class UnitTest_Base
{
    protected Test_Priner Priner;

    [SetUp]
    public void Setup()
    {
        Priner = new Test_Priner();
    }

    protected void Can(bool expected)
    {
        Assert.That(expected, Is.True);
    }

    protected void Cannot(bool expected)
    {
        Assert.That(expected, Is.False);
    }

    protected void Test_Message(string message)
    {
        Assert.That(Priner.Messages.Last(), Is.EqualTo(message));
    }
}