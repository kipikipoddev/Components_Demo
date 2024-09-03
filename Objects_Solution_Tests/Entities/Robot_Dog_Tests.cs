using Objects_Solution;

namespace Objects_Solution_Tests;

public class Robot_Dog_Tests : UnitTest_Base<IRobot_Dog>
{
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
        Subject.Charge();

        Subject.Bark();

        Assert_Was_Printed(Actions.Barking);
    }

    [Test]
    public void Test_Cant_Bark()
    {
        Subject.Bark();

        Assert_Cant_Printed(Actions.Bark);
    }

    [Test]
    public void Test_Walk()
    {
        Subject.Charge();

        Subject.Walk();

        Assert_Was_Printed(Actions.Walking);
    }

    [Test]
    public void Test_Cant_Walk()
    {
        Subject.Walk();

        Assert_Cant_Printed(Actions.Walk);
    }
}