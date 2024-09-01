using Components_Demo;

namespace Step_1_OOP_Tests;

public class Robot_Fish_Tests : UnitTest_Base<IRobot_Fish>
{
    [Test]
    public void Test_Get_Actions()
    {
        Test_Actions(Actions.Charge);
    }

    [Test]
    public void Test_Get_Charged_Actions()
    {
        Subject.Charge();
        Test_Actions(Actions.Swim);
    }

    [Test]
    public void Test_Swim()
    {
        Subject.Charge();
        Subject.Swim();
        Test_Was_Action(Actions.Swam);
    }

    [Test]
    public void Test_Cannot_Swim()
    {
        Subject.Swim();
        Test_Cannot_Action(Actions.Swim);
    }
}