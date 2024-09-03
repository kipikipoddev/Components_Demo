using Objects_Solution;

namespace Objects_Solution_Tests;

public class Fish_Tests : UnitTest_Base<IFIsh>
{
    [Test]
    public void Test_Swim()
    {
        Subject.Swim();
        Test_Was_Action(Actions.Swiming);
    }

    [Test]
    public void Test_cant_Swim()
    {
        Subject.Injure();
        Subject.Swim();
        Test_Cant_Action(Actions.Swim);
    }
}