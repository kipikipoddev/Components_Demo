using Objects_Solution;

namespace Objects_Solution_Tests;

public class Dog_Tests : UnitTest_Base<IDog>
{
    [Test]
    public void Test_Actions()
    {
        Assert_True(Subject.Can_Bark());
        Assert_True(Subject.Can_Walk());
        Assert_True(Subject.Can_Swim());
        Assert_True(Subject.Can_Injure());
        Assert_False(Subject.Can_Heal());
    }

    [Test]
    public void Test_Actions_After_Injure()
    {
        Subject.Injure();

        Assert_False(Subject.Can_Bark());
        Assert_False(Subject.Can_Walk());
        Assert_False(Subject.Can_Swim());
        Assert_False(Subject.Can_Injure());
        Assert_True(Subject.Can_Heal());
    }

    [Test]
    public void Test_Bark()
    {
        Subject.Bark();
        Assert_Was_Printed(Actions.Barking);
    }

    [Test]
    public void Test_cant_Bark()
    {
        Subject.Injure();

        Subject.Bark();

        Assert_Cant_Printed(Actions.Bark);
    }

    [Test]
    public void Test_Bark_When_Injure()
    {
        Subject.Injure();

        Subject.Bark();

        Assert_Cant_Printed(Actions.Bark);
    }

    [Test]
    public void Test_Not_Bark_When_Injure()
    {
        Subject.Injure();

        Subject.Injure();

        Assert_Cant_Printed(Actions.Injure);
    }

    [Test]
    public void Test_Walk()
    {
        Subject.Walk();

        Assert_Was_Printed(Actions.Walking);
    }

    [Test]
    public void Test_cant_Walk()
    {
        Subject.Injure();

        Subject.Walk();

        Assert_Cant_Printed(Actions.Walk);
    }

    [Test]
    public void Test_Swim()
    {
        Subject.Swim();

        Assert_Was_Printed(Actions.Swiming);
    }

    [Test]
    public void Test_cant_Swim()
    {
        Subject.Injure();

        Subject.Swim();

        Assert_Cant_Printed(Actions.Swim);
    }
}