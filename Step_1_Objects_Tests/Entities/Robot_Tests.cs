using Step_1_Objects;

namespace Step_1_Objects_Tests;

public class Robot_Tests : UnitTest_Base<IRobot>
{
    [Test]
    public void Test_Actions()
    {
        Assert_True(Subject.Can_Charge);
    }

    [Test]
    public void Test_Actions_After_Charge()
    {
        Subject.Charge();

        Assert_False(Subject.Can_Charge);
    }

    [Test]
    public void Test_Charged()
    {
        Subject.Charge();

        Assert_Was_Printed(Actions_Description.Charged);
    }

    [Test]
    public void Test_Charged_Again()
    {
        Subject.Charge();

        Subject.Charge();

        Assert_Cant_Printed(Actions.Charge);
    }
}