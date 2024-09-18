

using Step_4_Files;

namespace Step_4_Files_Tests;

public abstract class UnitTest_Base
{
    private const string Path = ".\\Data\\{0}.json";

    protected IComponents Subject;

    protected abstract string File_Name { get; }

    [SetUp]
    public virtual void Setup()
    {
        Test_Printer.Reset();
        Subject = Components_Factory.Create(string.Format(Path, File_Name));
        Subject.Add(new Test_Printer());
    }

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