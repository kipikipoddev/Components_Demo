using Step_1_Objects;

namespace Step_1_Objects_Tests;

public class Dog_Tests : UnitTest_Base<IDog>
{
    [Test]
    public void Test_Available_Actions()
    {
        Assert_Equivalent(Subject.Available_Actions, Actions.Bark, Actions.Walk, Actions.Swim, Actions.Injure, Actions.Heal);
    }

    [Test]
    public void Test_Actions()
    {
        Assert_True(Subject.Can_Bark);
        Assert_True(Subject.Can_Walk);
        Assert_True(Subject.Can_Swim);
        Assert_True(Subject.Can_Injure);
        Assert_False(Subject.Can_Heal);
    }

    [Test]
    public void Test_Actions_After_Injure()
    {
        Subject.Injure();

        Assert_False(Subject.Can_Bark);
        Assert_False(Subject.Can_Walk);
        Assert_False(Subject.Can_Swim);
        Assert_False(Subject.Can_Injure);
        Assert_True(Subject.Can_Heal);
    }

    [Test]
    public void Test_Bark()
    {
        Subject.Bark();
        Assert_Was_Printed(Actions_Description.Barking);
    }

    [Test]
    public void Test_Bark_When_Injured()
    {
        Subject.Injure();

        Subject.Bark();

        Assert_Cant_Printed(Actions.Bark);
    }

    [Test]
    public void Test_Walk()
    {
        Subject.Walk();

        Assert_Was_Printed(Actions_Description.Walking);
    }

    [Test]
    public void Test_Walk_When_Injured()
    {
        Subject.Injure();

        Subject.Walk();

        Assert_Cant_Printed(Actions.Walk);
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