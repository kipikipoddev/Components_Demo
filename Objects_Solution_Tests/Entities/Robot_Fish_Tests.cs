using Objects_Solution;

namespace Objects_Solution_Tests;

public class Robot_Fish_Tests : UnitTest_Base<IRobot_Fish>
{
    [Test]
    public void Test_Swim()
    {
        Subject.Charge();
        Subject.Swim();
        Test_Was_Action(Actions.Swiming);
    }

    [Test]
    public void Test_cant_Swim()
    {
        Subject.Swim();
        Test_Cant_Action(Actions.Swim);
    }
}