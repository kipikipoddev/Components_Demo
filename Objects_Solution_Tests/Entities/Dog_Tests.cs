using Objects_Solution;

namespace Step_1_OOP_Tests;

public class Dog_Tests : UnitTest_Base<IDog>
{
    [Test]
    public void Test_Get_Actions()
    {
        Test_Actions(Actions.Bark, Actions.Swim, Actions.Walk, Actions.Injure);
    }

    [Test]
    public void Test_Get_Injured_Actions()
    {
        Subject.Injure();
        Test_Actions(Actions.Heal);
    }

    [Test]
    public void Test_Bark()
    {
        Subject.Bark();
        Test_Was_Action(Actions.Barking);
    }

    [Test]
    public void Test_Cannot_Bark()
    {
        Subject.Injure();
        Subject.Bark();
        Test_Cannot_Action(Actions.Bark);
    }

    [Test]
    public void Test_Bark_When_Injure()
    {
        Subject.Injure();
        Test_Was_Action(Actions.Barking);
    }

    [Test]
    public void Test_Not_Bark_When_Injure()
    {
        Subject.Injure();
        Subject.Injure();
        Test_Cannot_Action(Actions.Injure);
    }

    [Test]
    public void Test_Walk()
    {
        Subject.Walk();
        Test_Was_Action(Actions.Walking);
    }

    [Test]
    public void Test_Cannot_Walk()
    {
        Subject.Injure();
        Subject.Walk();
        Test_Cannot_Action(Actions.Walk);
    }

    [Test]
    public void Test_Swim()
    {
        Subject.Swim();
        Test_Was_Action(Actions.Swiming);
    }

    [Test]
    public void Test_Cannot_Swim()
    {
        Subject.Injure();
        Subject.Swim();
        Test_Cannot_Action(Actions.Swim);
    }
}