using Step_5_Complex;

namespace Step_5_Complex_Tests;

public abstract class UnitTest_Base
{
    protected IComponents Subject;

    protected string Name => "Name";
    protected abstract string File_Name { get; }

    [SetUp]
    public virtual void Setup()
    {
        Test_Printer.Reset();
        Subject = Components_Factory.Create(File_Name);
        Subject.Add(new Name_Component(Name));
        Subject.Add(new Actions_Component());
        Subject.Add(new Test_Printer());
    }

    protected void Assert_Valid<T>(bool is_valid, params object[] args)
        where T : Command
    {
        args = Get_Args<T>(args);
        var command = (Command)Activator.CreateInstance(typeof(T), args);
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

    protected static void Assert_Printed(string message)
    {
        Assert.That(Test_Printer.Message, Is.EqualTo(message));
    }

    private object[] Get_Args<T>(object[] args) where T : Command
    {
        var ctor_params = typeof(T).GetConstructors().First().GetParameters();
        var ctor_args = new object[ctor_params.Length];
        ctor_args[0] = Subject;
        for (int i = 1; i < ctor_args.Length; i++)
        {
            if (args.Length > i)
                ctor_args[i] = Convert.ChangeType(args[i - 1], ctor_params[i].ParameterType);
            else
                ctor_args[i] = null;
        }
        return ctor_args;
    }
}