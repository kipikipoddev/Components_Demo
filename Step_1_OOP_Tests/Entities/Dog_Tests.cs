using Components_Demo;

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
        Test_Action_Message(Actions.Barked);
    }

    [Test]
    public void Test_Cannot_Bark()
    {
        Subject.Injure();
        Subject.Bark();
        Test_Cannot_Action(Actions.Bark);
    }

    [Test]
    public void Test_Walk()
    {
        Subject.Walk();
        Test_Action_Message(Actions.Walked);
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
        Test_Action_Message(Actions.Swam);
    }

    [Test]
    public void Test_Cannot_Swim()
    {
        Subject.Injure();
        Subject.Swim();
        Test_Cannot_Action(Actions.Swim);
    }
}