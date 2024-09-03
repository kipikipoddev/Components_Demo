using Objects_Solution;

namespace Objects_Solution_Tests;

public class Cat_Tests : UnitTest_Base<ICat>
{
    [Test]
    public void Test_Meow()
    {
        Subject.Meow();
        Test_Was_Action(Actions.Meowing);
    }

    [Test]
    public void Test_Meow_When_Injure()
    {
        Subject.Injure();
        Subject.Meow();
        Test_Cant_Action(Actions.Meow);
    }

    [Test]
    public void Test_Not_Meow_When_Injure()
    {
        Subject.Injure();
        Subject.Injure();
        Test_Cant_Action(Actions.Injure);
    }

    [Test]
    public void Test_cant_Meow()
    {
        Subject.Injure();
        Subject.Meow();
        Test_Cant_Action(Actions.Meow);
    }

    [Test]
    public void Test_Walk()
    {
        Subject.Walk();
        Test_Was_Action(Actions.Walking);
    }

    [Test]
    public void Test_cant_Walk()
    {
        Subject.Injure();
        Subject.Walk();
        Test_Cant_Action(Actions.Walk);
    }
}