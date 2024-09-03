using Components_Better_Solution;

namespace Components_Better_Solution_Tests;

public class Dog_Tests : UnitTest_Base
{
    [Test]
    public void Test_Actions()
    {
        Assert_Valid<Bark_Command>(false);
        Assert_Valid<Walk_Command>(false);
        Assert_Valid<Swim_Command>(false);
        Assert_Valid<Charge_Command>(true);
    }

    [Test]
    public void Test_Actions_After_Charge()
    {
        new Charge_Command(Subject).Send();

        Assert_Valid<Bark_Command>(true);
        Assert_Valid<Walk_Command>(true);
        Assert_Valid<Swim_Command>(true);
        Assert_Valid<Charge_Command>(false);
    }

    [Test]
    public void Test_Bark()
    {
        new Bark_Command(Subject).Send();

        Assert_Cant_Printed(Actions.Bark);
    }

    [Test]
    public void Test_Meow_When_Injure()
    {
        new Charge_Command(Subject).Send();

        new Bark_Command(Subject).Send();

        Assert_Was_Printed(Actions.Barking);
    }

    protected override IComponents Get_Subject()
    {
        return Components_Factory.Create_Robot_Dog();
    }
}