using Components_Demo;

namespace Step_2_Components_Tests;

public class Injure_Command_Tests : UnitTest_Base
{
    [SetUp]
    public override void Setup()
    {
        base.Setup();
        Subject.Add(new Injure_Component())
            .Add(new Injure_Handler())
            .Add(new Did_Handler<Meow_Command>());
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
        Subject.Add(new Injure_Component());
        Subject.Add(new Injure_Handler());
        Subject.Add(new Did_Handler<Walk_Command>());

        new Injure_Command(Subject);
        Test_Cannot_Action<Walk_Command>();
    }
}