using Objects_Solution;

namespace Step_1_OOP_Tests;

public class Fish_Tests : UnitTest_Base<IFIsh>
{
    [Test]
    public void Test_Get_Actions()
    {
        Test_Actions(Actions.Swim, Actions.Injure);
    }

    [Test]
    public void Test_Get_Injured_Actions()
    {
        Subject.Injure();
        Test_Actions(Actions.Heal);
    }

    [Test]
    public void Test_Swim()
    {
        Subject.Swim();
        Test_Was_Action(Actions.Swiming);
    }

    [Test]
    public void Test_Cannot_Swim()
    {
        Subject.Injure();
        Subject.Swim();
        Test_Cannot_Action(Actions.Swim);
    }
}