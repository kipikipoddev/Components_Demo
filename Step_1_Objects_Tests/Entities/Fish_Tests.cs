using Step_1_Objects;

namespace Step_1_Objects_Tests;

public class Fish_Tests : UnitTest_Base<IFish>
{
    [Test]
    public void Test_Available_Actions()
    {
        Assert_Equivalent(Subject.Available_Actions, Actions.Swim, Actions.Injure, Actions.Heal);
    }

    [Test]
    public void Test_Actions()
    {
        Assert_True(Subject.Can_Swim);
        Assert_True(Subject.Can_Injure);
        Assert_False(Subject.Can_Heal);
    }

    [Test]
    public void Test_Actions_After_Injure()
    {
        Subject.Injure();

        Assert_False(Subject.Can_Swim);
        Assert_False(Subject.Can_Injure);
        Assert_True(Subject.Can_Heal);
    }

    [Test]
    public void Test_Swim()
    {
        Subject.Swim();

        Assert_Was_Printed(Actions_Description.Swiming);
    }

    [Test]
    public void Test_Swim_When_Injured()
    {
        Subject.Injure();

        Subject.Swim();

        Assert_Cant_Printed(Actions.Swim);
    }
}