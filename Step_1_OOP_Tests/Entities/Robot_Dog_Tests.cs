using Step_1_OOP;

namespace Step_1_OOP_Tests;

public class Robot_Dog_Tests : UnitTest_Base<IRobot_Dog>
{
    private const int Max_Charges = 2;

    [Test]
    public void Test_Actions()
    {
        Cannot(Subject.Can_Walk);
        Cannot(Subject.Can_Swim);
        Cannot(Subject.Can_Bark);
        Cannot(Subject.Can_Injure);
        Cannot(Subject.Can_Heal);
        Can(Subject.Can_Recharge);
    }

    [Test]
    public void Test_Get_Actions()
    {
        Test_Actions(Actions.Recharge);
    }

    [Test]
    public void Test_Get_Actions_After_Charge()
    {
        Subject.Recharge();
        Test_Actions(Actions.Walk, Actions.Swim, Actions.Bark);
    }

    [Test]
    public void Test_Actions_After_Charge()
    {
        Subject.Recharge();
        Can(Subject.Can_Walk);
        Can(Subject.Can_Swim);
        Can(Subject.Can_Bark);
        Cannot(Subject.Can_Injure);
        Cannot(Subject.Can_Heal);
        Cannot(Subject.Can_Recharge);
    }

    [Test]
    public void Test_Bark()
    {
        Subject.Recharge();
        Subject.Bark();
        Test_Action_Message(Actions.Barking, Speed.Fast);
    }

    [Test]
    public void Test_Heal_And_Injure()
    {
        Subject.Heal();
        Test_Cannot_Action(Actions.Heal);
        Subject.Injure();
        Test_Cannot_Action(Actions.Injure);
    }

    protected override IRobot_Dog Get_Subject()
    {
        return new Robot_Dog(Priner, Max_Charges, Speed.Fast);
    }
}