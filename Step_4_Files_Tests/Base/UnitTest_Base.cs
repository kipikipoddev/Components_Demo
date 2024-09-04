
using Step_4_Files;

namespace Step_4_Files_Tests;

public abstract class UnitTest_Base
{
    protected IComponents Subject;

    [SetUp]
    public virtual void Setup()
    {
        Test_Printer.Reset();
        Subject = Components_Factory.Create(File_Name);
        Subject.Add(new Test_Printer());
    }

    protected abstract string File_Name { get; }

    protected void Assert_Valid<T>(bool is_valid)
        where T : Command
    {
        var command = (Command)Activator.CreateInstance(typeof(T), [Subject]);
        Assert.That(command.Is_Valid(), Is.EqualTo(is_valid)); ;
    }

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
        var expected = $"{File_Name} {middle} {action_str}";
        var actual = Test_Printer.Message;
        Assert.That(actual, Is.EqualTo(expected));
    }
}