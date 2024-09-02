using Components_Solution;

namespace Components_Solution_Tests;

public class Action_Command_Tests : UnitTest_Base
{
    [Test]
    public void Test_Meow_Command()
    {
        Subject.Add(new Did_Handler<Meow_Command>());
        Test_Was_Action<Meow_Command>();
    }

    [Test]
    public void Test_Walk_Command()
    {
        Subject.Add(new Did_Handler<Walk_Command>());
        Test_Was_Action<Walk_Command>();
    }

    [Test]
    public void Test_Bark_Command()
    {
        Subject.Add(new Did_Handler<Bark_Command>());
        Test_Was_Action<Bark_Command>();
    }

    [Test]
    public void Test_No_Handler_Command()
    {
        Test_Cannot_Action<Bark_Command>();
    }
}