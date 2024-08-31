using Step_1_OOP;

namespace OOP_Unit_Tests;

public class Robot_Tests : UnitTest_Base<IRobot>
{
    private int Max_Charges => Creator.Max_Charges;

    [Test]
    public void Test_Actions()
    {
        Cannot(Subject.Can_Walk);
        Cannot(Subject.Can_Swim);
        Can(Subject.Can_Recharge);
        Assert.That(Subject.Max_Charges, Is.EqualTo(Max_Charges));
        Assert.That(Subject.Charges, Is.Zero);
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
        Test_Actions(Actions.Walk, Actions.Swim);
    }

    [Test]
    public void Test_Charge()
    {
        Subject = Creator.Create<IRobot>(Speed.Fast);
        Subject.Recharge();
        Test_Action_Message(Actions.Recharging, Speed.Fast);
        Assert.That(Subject.Charges, Is.EqualTo(Subject.Max_Charges));
    }

    [Test]
    public void Test_Actions_After_Charge()
    {
        Subject.Recharge();
        Can(Subject.Can_Walk);
        Can(Subject.Can_Swim);
        Cannot(Subject.Can_Recharge);
    }

    [Test]
    public void Test_Charge_Go_Down_After_Action()
    {
        Subject.Recharge();
        Subject.Walk();
        Assert.That(Subject.Charges, Is.EqualTo(Max_Charges - 1));
    }

    [Test]
    public void Test_Actions_Action()
    {
        Subject.Recharge();
        Subject.Walk();
        Can(Subject.Can_Walk);
        Can(Subject.Can_Swim);
        Can(Subject.Can_Recharge);
    }

    [Test]
    public void Test_Actions_After_Max_Charges_Action()
    {
        Subject.Recharge();
        for (int i = 0; i < Max_Charges; i++)
            Subject.Walk();
        Cannot(Subject.Can_Walk);
        Cannot(Subject.Can_Swim);
        Can(Subject.Can_Recharge);
    }

    [Test]
    public void Test_Max_Charges_Zero()
    {
        Assert.Throws<ArgumentException>(() => Creator.Create<IRobot>(Speed.Slow, 0));
    }
}