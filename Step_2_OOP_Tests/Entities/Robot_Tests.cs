using Step_2_OOP;

namespace Step_2_OOP_Tests;

public class Robot_Tests : UnitTest_Base
{
    private const int Max_Charges = 2;
    private Robot robot;

    [SetUp]
    public override void Setup()
    {
        base.Setup();
        robot = new Robot(Priner, Max_Charges, Speed.Fast);
    }

    [Test]
    public void Test_Actions()
    {
        Cannot(robot.Can_Walk);
        Cannot(robot.Can_Swim);
        Can(robot.Can_Recharge);
        Assert.That(robot.Max_Charges, Is.EqualTo(Max_Charges));
        Assert.That(robot.Charges, Is.Zero);
    }

    [Test]
    public void Test_Get_Actions()
    {
        Test_Actions(robot, Actions.Recharge);
    }

    [Test]
    public void Test_Get_Actions_After_Charge()
    {
        robot.Recharge();
        Test_Actions(robot, Actions.Walk, Actions.Swim);
    }

    [Test]
    public void Test_Charge()
    {
        robot.Recharge();
        Test_Action_Message("Robot is ", Actions.Recharging, Speed.Fast);
        Assert.That(robot.Charges, Is.EqualTo(robot.Max_Charges));
    }

    [Test]
    public void Test_Actions_After_Charge()
    {
        robot.Recharge();
        Can(robot.Can_Walk);
        Can(robot.Can_Swim);
        Cannot(robot.Can_Recharge);
    }

    [Test]
    public void Test_Charge_Go_Down_After_Action()
    {
        robot.Recharge();
        robot.Walk();
        Assert.That(robot.Charges, Is.EqualTo(Max_Charges - 1));
    }

    [Test]
    public void Test_Actions_Action()
    {
        robot.Recharge();
        robot.Walk();
        Can(robot.Can_Walk);
        Can(robot.Can_Swim);
        Can(robot.Can_Recharge);
    }

    [Test]
    public void Test_Actions_After_Max_Charges_Action()
    {
        robot.Recharge();
        for (int i = 0; i < Max_Charges; i++)
            robot.Walk();
        Cannot(robot.Can_Walk);
        Cannot(robot.Can_Swim);
        Can(robot.Can_Recharge);
    }

    [Test]
    public void Test_Max_Charges_Zero()
    {
        Assert.Throws<ArgumentException>(() => new Robot(Priner, 0, Speed.Slow));
    }
}