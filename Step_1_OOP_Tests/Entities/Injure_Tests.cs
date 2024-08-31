using Components_Demo;

namespace Step_1_OOP_Tests;

public class Injure_Tests : UnitTest_Base<ICat>
{
    [Test]
    public void Test_Injure()
    {
        Subject.Injure();
        Test_Action_Message(Actions.Injured);
    }

    [Test]
    public void Test_Heal()
    {
        Subject.Injure();
        Subject.Heal();
        Test_Action_Message(Actions.Healing);
    }


    [Test]
    public void Test_Cannot_Heal()
    {
        Subject.Heal();
        Test_Cannot_Action(Actions.Heal);
    }

    [Test]
    public void Test_Injure_Actions()
    {
        Subject.Injure();
        Cannot(Subject.Can_Walk);
        Cannot(Subject.Can_Meow);
        Cannot(Subject.Can_Injure);
        Cannot(Subject.Can_Swim);
        Can(Subject.Can_Heal);
    }

    [Test]
    public void Test_Heal_Actions()
    {
        Subject.Injure();
        Subject.Heal();
        Can(Subject.Can_Walk);
        Can(Subject.Can_Meow);
        Can(Subject.Can_Injure);
        Cannot(Subject.Can_Swim);
        Cannot(Subject.Can_Heal);
    }
}