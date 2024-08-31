using Step_2_OOP;

namespace Step_2_OOP_Tests;

public class Robot_Dog_Tests : UnitTest_Base
{
    private const int Max_Charges = 2;
    private Robot_Dog robot_dog;

    [SetUp]
    public override void Setup()
    {
        base.Setup();
        robot_dog = new Robot_Dog(Priner, Max_Charges, Speed.Fast);
    }

    [Test]
    public void Test_Actions()
    {
        Cannot(robot_dog.Can_Walk);
        Cannot(robot_dog.Can_Swim);
        Cannot(robot_dog.Can_Bark);
        Cannot(robot_dog.Can_Injure);
        Cannot(robot_dog.Can_Heal);
        Can(robot_dog.Can_Recharge);
    }

    [Test]
    public void Test_Get_Actions()
    {
        Test_Actions(robot_dog, Actions.Recharge);
    }

    [Test]
    public void Test_Get_Actions_After_Charge()
    {
        robot_dog.Recharge();
        Test_Actions(robot_dog, Actions.Walk, Actions.Swim, Actions.Bark);
    }

    [Test]
    public void Test_Actions_After_Charge()
    {
        robot_dog.Recharge();
        Can(robot_dog.Can_Walk);
        Can(robot_dog.Can_Swim);
        Can(robot_dog.Can_Bark);
        Cannot(robot_dog.Can_Injure);
        Cannot(robot_dog.Can_Heal);
        Cannot(robot_dog.Can_Recharge);
    }

    [Test]
    public void Test_Bark()
    {
        robot_dog.Recharge();
        robot_dog.Bark();
        Test_Action_Message("Robot_Dog is ", Actions.Barking, Speed.Fast);
    }

    [Test]
    public void Test_Heal_And_Injure()
    {
        robot_dog.Heal();
        Test_Action_Message("Robot_Dog cannot ", Actions.Heal);
        robot_dog.Injure();
        Test_Action_Message("Robot_Dog cannot ", Actions.Injure);
    }
}