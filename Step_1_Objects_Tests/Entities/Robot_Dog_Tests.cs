using Step_1_Objects;

namespace Step_1_Objects_Tests;

public class Robot_Dog_Tests : UnitTest_Base<IRobot_Dog>
{
    [Test]
    public void Test_Available_Actions()
    {
        Assert_Equivalent(Subject.Available_Actions, Actions.Walk, Actions.Bark, Actions.Charge);
    }

    [Test]
    public void Test_Actions()
    {
        Assert_False(Subject.Can_Walk);
        Assert_False(Subject.Can_Bark);
        Assert_True(Subject.Can_Charge);
    }

    [Test]
    public void Test_Actions_After_Charge()
    {
        Subject.Charge();

        Assert_True(Subject.Can_Walk);
        Assert_True(Subject.Can_Bark);
        Assert_False(Subject.Can_Charge);
    }

    [Test]
    public void Test_Bark()
    {
        Subject.Bark();

        Assert_Cant_Printed(Actions.Bark);
    }

    [Test]
    public void Test_Bark_After_Charge()
    {
        Subject.Charge();

        Subject.Bark();

        Assert_Was_Printed(Actions_Description.Barking);
    }

    [Test]
    public void Test_Walk_After_Charge()
    {
        Subject.Charge();

        Subject.Walk();

        Assert_Was_Printed(Actions_Description.Walking);
    }

    [Test]
    public void Test_Walk()
    {
        Subject.Walk();

        Assert_Cant_Printed(Actions.Walk);
    }
}