using Components_Demo;

namespace Step_2_Components_Tests;

public abstract class UnitTest_Base
{
    protected const string Name = "Name";
    protected IComponents Subject;

    [SetUp]
    public virtual void Setup()
    {
        Test_Printer.Reset();
        Subject = new Components()
            .Add(new Test_Printer())
            .Add(new No_Handler())
            .Add(new Name_Component(Name));
    }

    protected void Test_Was_Action<T>()
        where T : Action_Command
    {
        var cmd = Get_Command<T>();
        Test_Action("was", cmd.Did);
    }

    protected void Test_Cannot_Action<T>()
            where T : Action_Command
    {
        var cmd = Get_Command<T>();
        Test_Action("cannot", cmd.Name);
    }

    private void Test_Action(string middle, string action)
    {
        var action_str = action.ToString().ToLower();
        var expected = $"{Subject.Name()} {middle} {action_str}";
        var actual = Test_Printer.Message;
        Assert.That(actual, Is.EqualTo(expected));
    }

    private T Get_Command<T>() where T : Action_Command
    {
        return (T)Activator.CreateInstance(typeof(T), [Subject])!;
    }
}