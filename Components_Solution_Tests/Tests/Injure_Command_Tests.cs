using Components_Solution;

namespace Components_Solution_Tests;

public class Injure_Command_Tests : UnitTest_Base
{
    [SetUp]
    public override void Setup()
    {
        base.Setup();
        Subject.Add(new Injure_Component())
            .Add(new Injure_Validator())
            .Add(new Did_Handler<Injure_Command>())
            .Add(new Did_Handler<Heal_Command>())
            .Add(new Did_Handler<Meow_Command>());
    }

    [Test]
    public void Test_Can_Injure()
    {
        Test_Was_Action<Injure_Command>();
    }

    [Test]
    public void Test_Cannot_Meow_If_Injured()
    {
        new Injure_Command(Subject);
        Test_Cannot_Action<Meow_Command>();
    }

    [Test]
    public void Test_Cannot_Injure_If_Injured()
    {
        new Injure_Command(Subject);
        Test_Cannot_Action<Injure_Command>();
    }

    [Test]
    public void Test_Heal()
    {
        new Injure_Command(Subject);
        Test_Was_Action<Heal_Command>();
    }

    [Test]
    public void Test_Cannot_Heal()
    {
        Test_Cannot_Action<Heal_Command>();
    }

    [Test]
    public void Test_Cannot_Heal_Again()
    {
        new Injure_Command(Subject);
        new Heal_Command(Subject);
        Test_Cannot_Action<Heal_Command>();
    }
}