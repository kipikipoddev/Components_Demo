using Components_Solution;

namespace Components_Solution_Tests;

public class Charge_Command_Tests : UnitTest_Base
{
    [SetUp]
    public override void Setup()
    {
        base.Setup();
        Subject.Add(new Charged_Component())
            .Add(new Charged_Component())
            .Add(new Did_Handler<Charge_Command>())
            .Add(new Did_Handler<Meow_Command>());
    }

    [Test]
    public void Test_cant_Meow_If_Not_Charged()
    {
        Test_Cant_Action<Meow_Command>();
    }

    [Test]
    public void Test_Can_Meow_If_Charged()
    {
        new Charge_Command(Subject);
        Test_Was_Action<Meow_Command>();
    }

    [Test]
    public void Test_cant_Charge_If_Charged()
    {
        new Charge_Command(Subject);
        Test_Cant_Action<Charge_Command>();
    }
}