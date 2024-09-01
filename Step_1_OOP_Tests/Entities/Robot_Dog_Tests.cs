using Components_Demo;

namespace Step_1_OOP_Tests;

public class Robot_Dog_Tests : UnitTest_Base<IRobot_Dog>
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
        Test_Actions(Actions.Walk, Actions.Swim, Actions.Bark);
    }

    [Test]
    public void Test_Bark()
    {
        Subject.Charge();
        Subject.Bark();
        Test_Action_Message(Actions.Barked);
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
        Test_Action_Message(Actions.Walked);
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
        Test_Action_Message(Actions.Swam);
    }

    [Test]
    public void Test_Cannot_Swim()
    {
        Subject.Swim();
        Test_Cannot_Action(Actions.Swim);
    }
}