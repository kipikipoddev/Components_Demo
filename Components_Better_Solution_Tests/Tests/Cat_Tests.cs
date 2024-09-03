using Components_Better_Solution;

namespace Components_Better_Solution_Tests;

public class Cat_Tests : UnitTest_Base
{
    [Test]
    public void Test_Actions()
    {
        Assert_True(new Meow_Command(Subject).Is_Valid());
    }

    [Test]
    public void Test_Meow()
    {
        new Meow_Command(Subject).Send();
        Assert_Was_Printed(Actions.Meowing);
    }

    protected override IComponents Get_Subject()
    {
        return Components_Factory.Create_Cat();
    }
}