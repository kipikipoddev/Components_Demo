using Step_4_Files;

namespace Step_4_Files_Tests;

public class Cat_Tests : UnitTest_Base
{
    protected override string File_Name => "Cat";

    [Test]
    public void Test_Actions()
    {
        Assert_Valid<Meow_Command>(true);
        Assert_Valid<Walk_Command>(true);
        Assert_Valid<Injure_Command>(true);
        Assert_Valid<Heal_Command>(false);
    }

    [Test]
    public void Test_Actions_After_Injure()
    {
        new Injure_Command(Subject).Send();

        Assert_Valid<Meow_Command>(false);
        Assert_Valid<Walk_Command>(false);
        Assert_Valid<Injure_Command>(false);
        Assert_Valid<Heal_Command>(true);
    }

    [Test]
    public void Test_Meow()
    {
        new Meow_Command(Subject).Send();

        Assert_Was_Printed(Actions.Meowing);
    }

    [Test]
    public void Test_Meow_When_Injure()
    {
        new Injure_Command(Subject).Send();

        new Meow_Command(Subject).Send();

        Assert_Cant_Printed(Actions.Meow);
    }
}