using Components_Demo;

namespace Step_2_Components_Tests;

public class Cat_Tests : UnitTest_Base
{
    [Test]
    public void Test_Meow_Command()
    {
        Test_Was_Action<Meow_Command>();
    }

    [Test]
    public void Test_Meow_Injured_Command()
    {
        new Injure_Command(Subject);
        Test_Cannot_Action<Meow_Command>();
    }

    protected override void Add()
    {
        Subject.Add(new Injure_Component());
        Subject.Add(new Injure_Handler());
        Subject.Add(new Did_Handler<Walk_Command>());
        Subject.Add(new Did_Handler<Meow_Command>());
    }

    private Action Get(Action action)
    {
        for (int i = 0; i < 10; i++)
            action = () =>
            {
                System.Console.WriteLine(i);
                action();
            };
        action();
    }
}