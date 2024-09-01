using Components_Demo;

namespace Step_2_Components_Tests;

public class Cat_Tests : UnitTest_Base
{
    [Test]
    public void Test_Get_Actions()
    {
        var cmd = new Meow_Command(Subject);
        Test_Was_Action(cmd.Did);
    }

    protected override void Add()
    {
        Subject.Add(new Did_Handler<Meow_Command>())
            .Add(new Name_Component("cat"));
    }
}