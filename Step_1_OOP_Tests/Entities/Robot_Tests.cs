using Components_Demo;

namespace Step_1_OOP_Tests;

public class Robot_Tests : UnitTest_Base<IRobot>
{
    [Test]
    public void Test_Charged()
    {
        Subject.Charge();
        Test_Action_Message(Actions.Charged);
    }

    [Test]
    public void Test_Charged_Again()
    {
        Subject.Charge();
        Subject.Charge();
        Test_Cannot_Action(Actions.Charge);
    }
}