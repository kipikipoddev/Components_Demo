using Step_1_Objects;

namespace Step_1_Objects_Tests;

public class Robot_Fish_Tests : UnitTest_Base<IRobot_Fish>
{
    [Test]
    public void Test_Available_Actions()
    {
        Assert_Equivalent(Subject.Available_Actions, Actions.Swim, Actions.Charge);
    }

    [Test]
    public void Test_Actions()
    {
        Assert_False(Subject.Can_Swim);
        Assert_True(Subject.Can_Charge);
    }

    [Test]
    public void Test_Actions_After_Charge()
    {
        Subject.Charge();

        Assert_True(Subject.Can_Swim);
        Assert_False(Subject.Can_Charge);
    }

    [Test]
    public void Test_Swim()
    {
        Subject.Charge();

        Subject.Swim();

        Assert_Was_Printed(Actions_Description.Swiming);
    }

    [Test]
    public void Test_Cant_Swim()
    {
        Subject.Swim();

        Assert_Cant_Printed(Actions.Swim);
    }
}