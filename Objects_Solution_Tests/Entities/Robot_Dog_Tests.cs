using Objects_Solution;

namespace Objects_Solution_Tests;

public class Robot_Dog_Tests : UnitTest_Base<IRobot_Dog>
{
    [Test]
    public void Test_Bark()
    {
        Subject.Charge();
        Subject.Bark();
        Test_Was_Action(Actions.Barking);
    }

    [Test]
    public void Test_Cannot_Bark()
    {
        Subject.Bark();
        Test_Cannot_Action(Actions.Bark);
    }

    [Test]
    public void Test_Walk()
    {
        Subject.Charge();
        Subject.Walk();
        Test_Was_Action(Actions.Walking);
    }

    [Test]
    public void Test_Cannot_Walk()
    {
        Subject.Walk();
        Test_Cannot_Action(Actions.Walk);
    }

    [Test]
    public void Test_Swim()
    {
        Subject.Charge();
        Subject.Swim();
        Test_Was_Action(Actions.Swiming);
    }

    [Test]
    public void Test_Cannot_Swim()
    {
        Subject.Swim();
        Test_Cannot_Action(Actions.Swim);
    }
}