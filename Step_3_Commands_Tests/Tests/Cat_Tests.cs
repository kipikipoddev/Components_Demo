using Step_3_Commands;

namespace Step_3_Commands_Tests;

public class Cat_Tests : UnitTest_Base
{
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

    protected override IComponents Get_Subject()
    {
        return Components_Factory.Create_Cat();
    }
}