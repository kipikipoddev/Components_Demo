using Components_Solution;

namespace Components_Solution_Tests;

public class Actions_List_Command_Tests : UnitTest_Base
{
    [Test]
    public void Test_Meow_Command()
    {
        Subject.Add(new Did_Handler<Meow_Command>());
        Test_Was_Action<Meow_Command>();
    }
}