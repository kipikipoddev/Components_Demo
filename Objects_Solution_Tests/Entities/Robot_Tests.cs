using Objects_Solution;

namespace Objects_Solution_Tests;

public class Robot_Tests : UnitTest_Base<IRobot>
{
    [Test]
    public void Test_Charged()
    {
        Subject.Charge();
        Test_Was_Action(Actions.Charged);
    }

    [Test]
    public void Test_Charged_Again()
    {
        Subject.Charge();
        Subject.Charge();
        Test_Cannot_Action(Actions.Charge);
    }
}