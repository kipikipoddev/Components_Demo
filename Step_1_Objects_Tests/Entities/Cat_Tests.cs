using Step_1_Objects;

namespace Step_1_Objects_Tests;

public class Cat_Tests : UnitTest_Base<ICat>
{
    [Test]
    public void Test_Available_Actions()
    {
        Assert_Equivalent(Subject.Available_Actions, Actions.Meow, Actions.Walk, Actions.Injure, Actions.Heal);
    }

    [Test]
    public void Test_Actions()
    {
        Assert_True(Subject.Can_Meow);
        Assert_True(Subject.Can_Walk);
        Assert_True(Subject.Can_Injure);
        Assert_False(Subject.Can_Heal);
    }

    [Test]
    public void Test_Actions_After_Injure()
    {
        Subject.Injure();

        Assert_False(Subject.Can_Meow);
        Assert_False(Subject.Can_Walk);
        Assert_False(Subject.Can_Injure);
        Assert_True(Subject.Can_Heal);
    }

    [Test]
    public void Test_Meow()
    {
        Subject.Meow();

        Assert_Was_Printed(Actions_Description.Meowing);
    }

    [Test]
    public void Test_Meow_When_Injure()
    {
        Subject.Injure();

        Subject.Meow();

        Assert_Cant_Printed(Actions.Meow);
    }

    [Test]
    public void Test_Not_Meow_When_Injure()
    {
        Subject.Injure();

        Subject.Injure();

        Assert_Cant_Printed(Actions.Injure);
    }

    [Test]
    public void Test_Cant_Meow()
    {
        Subject.Injure();

        Subject.Meow();

        Assert_Cant_Printed(Actions.Meow);
    }

    [Test]
    public void Test_Walk()
    {
        Subject.Walk();

        Assert_Was_Printed(Actions_Description.Walking);
    }

    [Test]
    public void Test_cant_Walk()
    {
        Subject.Injure();

        Subject.Walk();

        Assert_Cant_Printed(Actions.Walk);
    }
}